﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyCapture2Managed;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Windows.Forms;

namespace CameraTest
{
    public class Camera
    {
        //Camera properties
        public enum Property { Shutter, Gain, Illuminance, FrameRate, AutoExposure, Brightness, Temperature, WhiteBalance };
        private ManagedGigECamera camera;
        private uint serialNumber;
        private CameraProperty autoExposure;
        private CameraProperty brightness;
        private CameraProperty frameRate;
        private CameraProperty gain;
        private CameraProperty shutter;
        private CameraProperty temperature;
        private CameraProperty whiteBalance;
        private double illuminance;
        //private double shutterSpeed;
        public event CameraFrameReceivedEventHandler CameraFrameReceived;
        public static readonly uint[] SerialNumbers = new uint[8]
        {
            13421033,
            13421041,
            13421043,
            13421046,
            13421051,
            13421053,
            13421056,
            13421057
        };

        /*
         * Camera constructor
         * 
         * Creates, initialises and connects to a new camera object, with specified serial number and display box.
         * Inputs: Camera serial number and optional picture box
         * Output: None
         */
        public Camera(uint serialNumber)
        {
            this.serialNumber = serialNumber;
            camera = new ManagedGigECamera();
            ManagedBusManager busManager = new ManagedBusManager();
            ManagedPGRGuid guid = busManager.GetCameraFromSerialNumber((uint)serialNumber);
            camera.Connect(guid);
            InitialiseCamera();
        }

        public static int GetNumberOfCameras()
        {
            ManagedBusManager busManager = new ManagedBusManager();
            return (int)busManager.GetNumOfCameras();
        }

        /*
         * InitialiseCamera
         * 
         * Initialises camera image settings and properties
         * 
         */

        private void InitialiseCamera()
        {
            //Image size = 1280x1024, raw8 format, no offset
            GigEImageSettings imageSettings = new GigEImageSettings();
            imageSettings.offsetX = 0;
            imageSettings.offsetY = 0;
            imageSettings.height = 1024;
            imageSettings.width = 1280;
            imageSettings.pixelFormat = PixelFormat.PixelFormatRaw8;
            camera.SetGigEImageSettings(imageSettings);

            //Exposure set automatically
            autoExposure = new CameraProperty(PropertyType.AutoExposure);
            autoExposure.onOff = true;
            autoExposure.autoManualMode = true;
            autoExposure.absControl = true;
            camera.SetProperty(autoExposure);

            //Brightness set automatically
            brightness = new CameraProperty(PropertyType.Brightness);
            brightness.onOff = true;
            brightness.autoManualMode = true;
            brightness.absControl = true;
            camera.SetProperty(brightness);

            //Frame rate set manually, initialised to 2.5fps
            frameRate = new CameraProperty(PropertyType.FrameRate);
            frameRate.onOff = true;
            frameRate.autoManualMode = false;
            frameRate.absControl = true;
            frameRate.absValue = 2.5F;
            camera.SetProperty(frameRate);

            //Shutter speed to be set manually, initialised to 100ms
            shutter = new CameraProperty(PropertyType.Shutter);
            shutter.onOff = true;
            shutter.autoManualMode = false;
            shutter.absControl = true;
            shutter.absValue = 100;
            camera.SetProperty(shutter);

            //Gain to be set automatically with specified range
            gain = new CameraProperty(PropertyType.Gain);
            gain.onOff = true;
            gain.autoManualMode = true;
            gain.absControl = true;
            camera.SetProperty(gain);
            camera.WriteRegister(0x10A0, 0xC30000FF);

            //White balance to be set automatically
            whiteBalance = new CameraProperty(PropertyType.WhiteBalance);
            whiteBalance.onOff = true;
            whiteBalance.autoManualMode = true;
            camera.SetProperty(whiteBalance);

            //Temperature property enabled
            temperature = new CameraProperty(PropertyType.Temperature);
            temperature.onOff = true;
            temperature.absControl = true;
            camera.SetProperty(temperature);

            //Initial illuminance
            illuminance = 0;
        }

        /*
         * SetProperty
         * 
         * Input: Property enum type and value
         * 
         * Output: No return. Sets specified camera property and value.
         */
        public void SetProperty(Property property, double value)
        {
            switch (property)
            {
                case Property.FrameRate:
                    frameRate.absValue = (float)value;
                    camera.SetProperty(frameRate);
                    break;

                case Property.Gain:
                    gain.absValue = (float)value;
                    camera.SetProperty(gain);
                    break;

                case Property.Illuminance:
                    illuminance = value;
                    break;

                case Property.Shutter:
                    shutter.absValue = (float) value;
                    camera.SetProperty(shutter);
                    break;
            }
        }
        
        /*
         * StartCapture
         * 
         * Starts capturing frames from camera and triggering specified callback.
         * 
         * Inputs: None
         * Outputs: None
         *
         */
        public string StartCapture()
        {
            try
            {
                camera.StartCapture(CameraFrameReceivedCallback);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            //start reading light sensor
            return null;
        }

        /*
         * CameraFrameReceivedCallback
         * 
         * Converts raw image to BGR format and fires frame received event to subscribing threads.
         * 
         * Inputs: StartCapture passes 
         * Outputs: None
         * 
         */
        private void CameraFrameReceivedCallback(ManagedImage rawImage)
        {
            //Get timestamp and convert image into necessary format
            DateTime time = DateTime.Now;
            ManagedImage convertedImage = new ManagedImage();
            rawImage.Convert(PixelFormat.PixelFormatBgr, convertedImage);
            Image<Bgr, Byte> image = new Image<Bgr, Byte>(convertedImage.bitmap);
            
            //Setup camera frame received event arguments and fire event
            CameraFrameReceivedEventArgs args = new CameraFrameReceivedEventArgs();
            args.image = image;
            args.time = time;
            args.serial = serialNumber;
            args.brightness = camera.GetProperty(PropertyType.Brightness).absValue;
            args.exposure = camera.GetProperty(PropertyType.AutoExposure).absValue;
            args.frameRate = camera.GetProperty(PropertyType.FrameRate).absValue;
            args.gain = camera.GetProperty(PropertyType.Gain).absValue;
            args.illuminance = illuminance;
            args.shutter = camera.GetProperty(PropertyType.Shutter).absValue;
            args.whiteBalanceA = (int) camera.GetProperty(PropertyType.WhiteBalance).valueA;
            args.whiteBalanceB = (int) camera.GetProperty(PropertyType.WhiteBalance).valueB;
            OnCameraFrameReceived(args);

            //Update shutter speed
            SetProperty(Property.Shutter, -0.1682 * illuminance + 210.43);
        }

        protected virtual void OnCameraFrameReceived(CameraFrameReceivedEventArgs e)
        {
            CameraFrameReceivedEventHandler handler = CameraFrameReceived;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public string StopCapture()
        {
            try
            {
                camera.StopCapture();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            //start reading light sensor
            return null;
        }

        public uint GetSerial()
        {
            return serialNumber;
        }

    }
}
