﻿namespace PatchExtraction
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.runBtn = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.patchSizeComboBox = new System.Windows.Forms.ComboBox();
            this.fileName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileCountLabel = new System.Windows.Forms.Label();
            this.windowCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalLantanaLabel = new System.Windows.Forms.Label();
            this.totalNonLantanaLabel = new System.Windows.Forms.Label();
            this.totalUnusedLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskPictureBox = new System.Windows.Forms.PictureBox();
            this.thresholdPictureBox = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.patchPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 536);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lantana Patch Extractor";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.originalPictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.maskPictureBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.thresholdPictureBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.patchPictureBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 517);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalPictureBox.Location = new System.Drawing.Point(328, 3);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(319, 252);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalPictureBox.TabIndex = 2;
            this.originalPictureBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(319, 252);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.runBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBrowse, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(313, 44);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // runBtn
            // 
            this.runBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runBtn.Enabled = false;
            this.runBtn.Location = new System.Drawing.Point(3, 3);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(150, 38);
            this.runBtn.TabIndex = 0;
            this.runBtn.Text = "Run Patch Extractor";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowse.Location = new System.Drawing.Point(159, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(151, 38);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.patchSizeComboBox, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.fileName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.fileNameLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.fileCountLabel, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.windowCountLabel, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.totalLantanaLabel, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.totalNonLantanaLabel, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.totalUnusedLabel, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(313, 196);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // patchSizeComboBox
            // 
            this.patchSizeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patchSizeComboBox.FormattingEnabled = true;
            this.patchSizeComboBox.Items.AddRange(new object[] {
            "50",
            "75",
            "100",
            "125",
            "150"});
            this.patchSizeComboBox.Location = new System.Drawing.Point(159, 177);
            this.patchSizeComboBox.Name = "patchSizeComboBox";
            this.patchSizeComboBox.Size = new System.Drawing.Size(150, 21);
            this.patchSizeComboBox.TabIndex = 14;
            this.patchSizeComboBox.Text = "75";
            this.patchSizeComboBox.SelectedValueChanged += new System.EventHandler(this.patchSizeComboBox_SelectedValueChanged);
            // 
            // fileName
            // 
            this.fileName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(3, 8);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(57, 13);
            this.fileName.TabIndex = 0;
            this.fileName.Text = "File Name:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "File Count:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Window Count:";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(229, 8);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(10, 13);
            this.fileNameLabel.TabIndex = 6;
            this.fileNameLabel.Text = "-";
            // 
            // fileCountLabel
            // 
            this.fileCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileCountLabel.AutoSize = true;
            this.fileCountLabel.Location = new System.Drawing.Point(229, 37);
            this.fileCountLabel.Name = "fileCountLabel";
            this.fileCountLabel.Size = new System.Drawing.Size(10, 13);
            this.fileCountLabel.TabIndex = 7;
            this.fileCountLabel.Text = "-";
            // 
            // windowCountLabel
            // 
            this.windowCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.windowCountLabel.AutoSize = true;
            this.windowCountLabel.Location = new System.Drawing.Point(229, 66);
            this.windowCountLabel.Name = "windowCountLabel";
            this.windowCountLabel.Size = new System.Drawing.Size(10, 13);
            this.windowCountLabel.TabIndex = 8;
            this.windowCountLabel.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Lantana:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Non-Lantana:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Unused:";
            // 
            // totalLantanaLabel
            // 
            this.totalLantanaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalLantanaLabel.AutoSize = true;
            this.totalLantanaLabel.Location = new System.Drawing.Point(229, 95);
            this.totalLantanaLabel.Name = "totalLantanaLabel";
            this.totalLantanaLabel.Size = new System.Drawing.Size(10, 13);
            this.totalLantanaLabel.TabIndex = 9;
            this.totalLantanaLabel.Text = "-";
            // 
            // totalNonLantanaLabel
            // 
            this.totalNonLantanaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalNonLantanaLabel.AutoSize = true;
            this.totalNonLantanaLabel.Location = new System.Drawing.Point(229, 124);
            this.totalNonLantanaLabel.Name = "totalNonLantanaLabel";
            this.totalNonLantanaLabel.Size = new System.Drawing.Size(10, 13);
            this.totalNonLantanaLabel.TabIndex = 10;
            this.totalNonLantanaLabel.Text = "-";
            // 
            // totalUnusedLabel
            // 
            this.totalUnusedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalUnusedLabel.AutoSize = true;
            this.totalUnusedLabel.Location = new System.Drawing.Point(229, 153);
            this.totalUnusedLabel.Name = "totalUnusedLabel";
            this.totalUnusedLabel.Size = new System.Drawing.Size(10, 13);
            this.totalUnusedLabel.TabIndex = 11;
            this.totalUnusedLabel.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Patch Size:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskPictureBox
            // 
            this.maskPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskPictureBox.Location = new System.Drawing.Point(653, 3);
            this.maskPictureBox.Name = "maskPictureBox";
            this.maskPictureBox.Size = new System.Drawing.Size(321, 252);
            this.maskPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maskPictureBox.TabIndex = 5;
            this.maskPictureBox.TabStop = false;
            // 
            // thresholdPictureBox
            // 
            this.thresholdPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thresholdPictureBox.Location = new System.Drawing.Point(653, 261);
            this.thresholdPictureBox.Name = "thresholdPictureBox";
            this.thresholdPictureBox.Size = new System.Drawing.Size(321, 253);
            this.thresholdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thresholdPictureBox.TabIndex = 6;
            this.thresholdPictureBox.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(3, 261);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(319, 253);
            this.textBox.TabIndex = 7;
            // 
            // patchPictureBox
            // 
            this.patchPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patchPictureBox.Location = new System.Drawing.Point(328, 261);
            this.patchPictureBox.Name = "patchPictureBox";
            this.patchPictureBox.Size = new System.Drawing.Size(319, 253);
            this.patchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patchPictureBox.TabIndex = 3;
            this.patchPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 536);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.PictureBox patchPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileCountLabel;
        private System.Windows.Forms.Label windowCountLabel;
        private System.Windows.Forms.Label totalLantanaLabel;
        private System.Windows.Forms.Label totalNonLantanaLabel;
        private System.Windows.Forms.Label totalUnusedLabel;
        private System.Windows.Forms.PictureBox maskPictureBox;
        private System.Windows.Forms.PictureBox thresholdPictureBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox patchSizeComboBox;
        private System.Windows.Forms.Label label6;
    }
}

