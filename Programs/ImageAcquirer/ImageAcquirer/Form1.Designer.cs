﻿namespace ImageAcquirer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.systemButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.whiteBalanceBlueLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.whiteBalanceRedLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.exposureValueLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gainLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.shutterSpeedLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.illuminanceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cameraComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(249, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(732, 556);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.systemButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cameraComboBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(240, 556);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // systemButton
            // 
            this.systemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemButton.Location = new System.Drawing.Point(3, 3);
            this.systemButton.Name = "systemButton";
            this.systemButton.Size = new System.Drawing.Size(234, 258);
            this.systemButton.TabIndex = 0;
            this.systemButton.Text = "Start";
            this.systemButton.UseVisualStyleBackColor = true;
            this.systemButton.Click += new System.EventHandler(this.systemButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.whiteBalanceBlueLabel, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.whiteBalanceRedLabel, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.brightnessLabel, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.exposureValueLabel, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.gainLabel, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.shutterSpeedLabel, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.illuminanceLabel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.imageNumberLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 294);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(234, 259);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // whiteBalanceBlueLabel
            // 
            this.whiteBalanceBlueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.whiteBalanceBlueLabel.AutoSize = true;
            this.whiteBalanceBlueLabel.Location = new System.Drawing.Point(170, 235);
            this.whiteBalanceBlueLabel.Name = "whiteBalanceBlueLabel";
            this.whiteBalanceBlueLabel.Size = new System.Drawing.Size(10, 13);
            this.whiteBalanceBlueLabel.TabIndex = 15;
            this.whiteBalanceBlueLabel.Text = "-";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "White Balance (Blue):";
            // 
            // whiteBalanceRedLabel
            // 
            this.whiteBalanceRedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.whiteBalanceRedLabel.AutoSize = true;
            this.whiteBalanceRedLabel.Location = new System.Drawing.Point(170, 201);
            this.whiteBalanceRedLabel.Name = "whiteBalanceRedLabel";
            this.whiteBalanceRedLabel.Size = new System.Drawing.Size(10, 13);
            this.whiteBalanceRedLabel.TabIndex = 13;
            this.whiteBalanceRedLabel.Text = "-";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "White Balance (Red):";
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(170, 169);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(10, 13);
            this.brightnessLabel.TabIndex = 11;
            this.brightnessLabel.Text = "-";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Brightness (%):";
            // 
            // exposureValueLabel
            // 
            this.exposureValueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exposureValueLabel.AutoSize = true;
            this.exposureValueLabel.Location = new System.Drawing.Point(170, 137);
            this.exposureValueLabel.Name = "exposureValueLabel";
            this.exposureValueLabel.Size = new System.Drawing.Size(10, 13);
            this.exposureValueLabel.TabIndex = 9;
            this.exposureValueLabel.Text = "-";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Exposure Value (EV):";
            // 
            // gainLabel
            // 
            this.gainLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gainLabel.AutoSize = true;
            this.gainLabel.Location = new System.Drawing.Point(170, 105);
            this.gainLabel.Name = "gainLabel";
            this.gainLabel.Size = new System.Drawing.Size(10, 13);
            this.gainLabel.TabIndex = 7;
            this.gainLabel.Text = "-";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gain (dB)";
            // 
            // shutterSpeedLabel
            // 
            this.shutterSpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shutterSpeedLabel.AutoSize = true;
            this.shutterSpeedLabel.Location = new System.Drawing.Point(170, 73);
            this.shutterSpeedLabel.Name = "shutterSpeedLabel";
            this.shutterSpeedLabel.Size = new System.Drawing.Size(10, 13);
            this.shutterSpeedLabel.TabIndex = 5;
            this.shutterSpeedLabel.Text = "-";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Shutter Speed (ms):";
            // 
            // illuminanceLabel
            // 
            this.illuminanceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.illuminanceLabel.AutoSize = true;
            this.illuminanceLabel.Location = new System.Drawing.Point(170, 41);
            this.illuminanceLabel.Name = "illuminanceLabel";
            this.illuminanceLabel.Size = new System.Drawing.Size(10, 13);
            this.illuminanceLabel.TabIndex = 3;
            this.illuminanceLabel.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Illuminance (lux):";
            // 
            // imageNumberLabel
            // 
            this.imageNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageNumberLabel.AutoSize = true;
            this.imageNumberLabel.Location = new System.Drawing.Point(170, 9);
            this.imageNumberLabel.Name = "imageNumberLabel";
            this.imageNumberLabel.Size = new System.Drawing.Size(10, 13);
            this.imageNumberLabel.TabIndex = 1;
            this.imageNumberLabel.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Number:";
            // 
            // cameraComboBox
            // 
            this.cameraComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cameraComboBox.FormattingEnabled = true;
            this.cameraComboBox.Items.AddRange(new object[] {
            "None",
            "13421033",
            "13421041",
            "13421043",
            "13421046",
            "13421051",
            "13421053",
            "13421056",
            "13421057"});
            this.cameraComboBox.Location = new System.Drawing.Point(3, 267);
            this.cameraComboBox.Name = "cameraComboBox";
            this.cameraComboBox.Size = new System.Drawing.Size(234, 21);
            this.cameraComboBox.TabIndex = 2;
            this.cameraComboBox.TextUpdate += new System.EventHandler(this.cameraComboBox_TextUpdate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Image Acquirer";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button systemButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label whiteBalanceBlueLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label whiteBalanceRedLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label exposureValueLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label gainLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label shutterSpeedLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label illuminanceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label imageNumberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cameraComboBox;
    }
}

