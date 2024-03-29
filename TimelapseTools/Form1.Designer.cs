﻿namespace MergePics
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lableSourceFolderPath = new System.Windows.Forms.Label();
            this.labelFileCount = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.cbFileNamePrefix = new System.Windows.Forms.ComboBox();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.labelOutputfolderPath = new System.Windows.Forms.Label();
            this.fBDOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnGenerateMidFrame = new System.Windows.Forms.Button();
            this.btnAutoClick = new System.Windows.Forms.Button();
            this.tbAutoClickWait = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMidFrameReplace = new System.Windows.Forms.CheckBox();
            this.btnGammaCorrection = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPreviewSampleArea = new System.Windows.Forms.Button();
            this.tbThreshold = new System.Windows.Forms.TextBox();
            this.tbSampleSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbGammaCorrectionSample = new System.Windows.Forms.Label();
            this.btnSelectSample = new System.Windows.Forms.Button();
            this.cbRenameReplace = new System.Windows.Forms.CheckBox();
            this.cbRotateOptions = new System.Windows.Forms.ComboBox();
            this.btnManualImgRegistrationForm = new System.Windows.Forms.Button();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSequenceFolder = new System.Windows.Forms.Button();
            this.lbSequenceFolderPath = new System.Windows.Forms.Label();
            this.lbSequenceFolderFileCount = new System.Windows.Forms.Label();
            this.tbSamplePointsCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSamplePoints = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(136, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Source folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lableSourceFolderPath
            // 
            this.lableSourceFolderPath.AutoSize = true;
            this.lableSourceFolderPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableSourceFolderPath.Location = new System.Drawing.Point(154, 17);
            this.lableSourceFolderPath.Name = "lableSourceFolderPath";
            this.lableSourceFolderPath.Size = new System.Drawing.Size(10, 15);
            this.lableSourceFolderPath.TabIndex = 1;
            this.lableSourceFolderPath.Text = ":";
            // 
            // labelFileCount
            // 
            this.labelFileCount.AutoSize = true;
            this.labelFileCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileCount.Location = new System.Drawing.Point(154, 48);
            this.labelFileCount.Name = "labelFileCount";
            this.labelFileCount.Size = new System.Drawing.Size(76, 15);
            this.labelFileCount.TabIndex = 2;
            this.labelFileCount.Text = "Files count: 0";
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.Location = new System.Drawing.Point(12, 112);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(136, 23);
            this.btnRename.TabIndex = 3;
            this.btnRename.Text = "Rename files";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // cbFileNamePrefix
            // 
            this.cbFileNamePrefix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFileNamePrefix.FormattingEnabled = true;
            this.cbFileNamePrefix.Items.AddRange(new object[] {
            "ExactDateTime",
            "DateTimeWithFileName",
            "IntByName"});
            this.cbFileNamePrefix.Location = new System.Drawing.Point(157, 113);
            this.cbFileNamePrefix.Name = "cbFileNamePrefix";
            this.cbFileNamePrefix.Size = new System.Drawing.Size(121, 23);
            this.cbFileNamePrefix.TabIndex = 5;
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputFolder.Location = new System.Drawing.Point(12, 83);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(136, 23);
            this.btnOutputFolder.TabIndex = 6;
            this.btnOutputFolder.Text = "Output folder";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
            // 
            // labelOutputfolderPath
            // 
            this.labelOutputfolderPath.AutoSize = true;
            this.labelOutputfolderPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputfolderPath.Location = new System.Drawing.Point(154, 83);
            this.labelOutputfolderPath.Name = "labelOutputfolderPath";
            this.labelOutputfolderPath.Size = new System.Drawing.Size(10, 15);
            this.labelOutputfolderPath.TabIndex = 7;
            this.labelOutputfolderPath.Text = ":";
            // 
            // btnRotate
            // 
            this.btnRotate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotate.Location = new System.Drawing.Point(12, 141);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(136, 23);
            this.btnRotate.TabIndex = 8;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnGenerateMidFrame
            // 
            this.btnGenerateMidFrame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateMidFrame.Location = new System.Drawing.Point(12, 170);
            this.btnGenerateMidFrame.Name = "btnGenerateMidFrame";
            this.btnGenerateMidFrame.Size = new System.Drawing.Size(136, 23);
            this.btnGenerateMidFrame.TabIndex = 9;
            this.btnGenerateMidFrame.Text = "GenerateMidFrame";
            this.btnGenerateMidFrame.UseVisualStyleBackColor = true;
            this.btnGenerateMidFrame.Click += new System.EventHandler(this.btnGenerateMidFrame_Click);
            // 
            // btnAutoClick
            // 
            this.btnAutoClick.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoClick.Location = new System.Drawing.Point(12, 200);
            this.btnAutoClick.Name = "btnAutoClick";
            this.btnAutoClick.Size = new System.Drawing.Size(136, 23);
            this.btnAutoClick.TabIndex = 10;
            this.btnAutoClick.Text = "AutoClick";
            this.btnAutoClick.UseVisualStyleBackColor = true;
            this.btnAutoClick.Click += new System.EventHandler(this.btnAutoClick_Click);
            // 
            // tbAutoClickWait
            // 
            this.tbAutoClickWait.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAutoClickWait.Location = new System.Drawing.Point(224, 202);
            this.tbAutoClickWait.Name = "tbAutoClickWait";
            this.tbAutoClickWait.Size = new System.Drawing.Size(121, 23);
            this.tbAutoClickWait.TabIndex = 11;
            this.tbAutoClickWait.Text = "3000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Wait ms:";
            // 
            // cbMidFrameReplace
            // 
            this.cbMidFrameReplace.AutoSize = true;
            this.cbMidFrameReplace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMidFrameReplace.Location = new System.Drawing.Point(157, 176);
            this.cbMidFrameReplace.Name = "cbMidFrameReplace";
            this.cbMidFrameReplace.Size = new System.Drawing.Size(67, 19);
            this.cbMidFrameReplace.TabIndex = 13;
            this.cbMidFrameReplace.Text = "Replace";
            this.cbMidFrameReplace.UseVisualStyleBackColor = true;
            // 
            // btnGammaCorrection
            // 
            this.btnGammaCorrection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGammaCorrection.Location = new System.Drawing.Point(7, 151);
            this.btnGammaCorrection.Name = "btnGammaCorrection";
            this.btnGammaCorrection.Size = new System.Drawing.Size(196, 23);
            this.btnGammaCorrection.TabIndex = 15;
            this.btnGammaCorrection.Text = "Gamma correction";
            this.btnGammaCorrection.UseVisualStyleBackColor = true;
            this.btnGammaCorrection.Click += new System.EventHandler(this.btnGammaCorrection_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbSamplePoints);
            this.groupBox1.Controls.Add(this.tbSamplePointsCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPreviewSampleArea);
            this.groupBox1.Controls.Add(this.tbThreshold);
            this.groupBox1.Controls.Add(this.tbSampleSize);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbGammaCorrectionSample);
            this.groupBox1.Controls.Add(this.btnSelectSample);
            this.groupBox1.Controls.Add(this.btnGammaCorrection);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 180);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gamma correction";
            // 
            // btnPreviewSampleArea
            // 
            this.btnPreviewSampleArea.Location = new System.Drawing.Point(421, 151);
            this.btnPreviewSampleArea.Name = "btnPreviewSampleArea";
            this.btnPreviewSampleArea.Size = new System.Drawing.Size(171, 23);
            this.btnPreviewSampleArea.TabIndex = 23;
            this.btnPreviewSampleArea.Text = "Set or preview sample areas";
            this.btnPreviewSampleArea.UseVisualStyleBackColor = true;
            this.btnPreviewSampleArea.Click += new System.EventHandler(this.btnPreviewSampleArea_Click);
            // 
            // tbThreshold
            // 
            this.tbThreshold.Location = new System.Drawing.Point(161, 103);
            this.tbThreshold.Name = "tbThreshold";
            this.tbThreshold.Size = new System.Drawing.Size(100, 23);
            this.tbThreshold.TabIndex = 22;
            this.tbThreshold.Text = "5";
            // 
            // tbSampleSize
            // 
            this.tbSampleSize.Location = new System.Drawing.Point(161, 74);
            this.tbSampleSize.Name = "tbSampleSize";
            this.tbSampleSize.Size = new System.Drawing.Size(100, 23);
            this.tbSampleSize.TabIndex = 22;
            this.tbSampleSize.Text = "40";
            this.tbSampleSize.TextChanged += new System.EventHandler(this.tbSampleSize_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Threshold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Sample size px";
            // 
            // lbGammaCorrectionSample
            // 
            this.lbGammaCorrectionSample.AutoSize = true;
            this.lbGammaCorrectionSample.Location = new System.Drawing.Point(143, 26);
            this.lbGammaCorrectionSample.Name = "lbGammaCorrectionSample";
            this.lbGammaCorrectionSample.Size = new System.Drawing.Size(10, 15);
            this.lbGammaCorrectionSample.TabIndex = 20;
            this.lbGammaCorrectionSample.Text = ":";
            // 
            // btnSelectSample
            // 
            this.btnSelectSample.Location = new System.Drawing.Point(7, 22);
            this.btnSelectSample.Name = "btnSelectSample";
            this.btnSelectSample.Size = new System.Drawing.Size(129, 23);
            this.btnSelectSample.TabIndex = 19;
            this.btnSelectSample.Text = "Select sample image ";
            this.btnSelectSample.UseVisualStyleBackColor = true;
            this.btnSelectSample.Click += new System.EventHandler(this.btnSelectSample_Click);
            // 
            // cbRenameReplace
            // 
            this.cbRenameReplace.AutoSize = true;
            this.cbRenameReplace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRenameReplace.Location = new System.Drawing.Point(284, 115);
            this.cbRenameReplace.Name = "cbRenameReplace";
            this.cbRenameReplace.Size = new System.Drawing.Size(67, 19);
            this.cbRenameReplace.TabIndex = 13;
            this.cbRenameReplace.Text = "Replace";
            this.cbRenameReplace.UseVisualStyleBackColor = true;
            // 
            // cbRotateOptions
            // 
            this.cbRotateOptions.FormattingEnabled = true;
            this.cbRotateOptions.Location = new System.Drawing.Point(158, 144);
            this.cbRotateOptions.Name = "cbRotateOptions";
            this.cbRotateOptions.Size = new System.Drawing.Size(187, 20);
            this.cbRotateOptions.TabIndex = 20;
            // 
            // btnManualImgRegistrationForm
            // 
            this.btnManualImgRegistrationForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManualImgRegistrationForm.Location = new System.Drawing.Point(7, 84);
            this.btnManualImgRegistrationForm.Name = "btnManualImgRegistrationForm";
            this.btnManualImgRegistrationForm.Size = new System.Drawing.Size(212, 23);
            this.btnManualImgRegistrationForm.TabIndex = 21;
            this.btnManualImgRegistrationForm.Text = "Manual Img Registration Sequence";
            this.btnManualImgRegistrationForm.UseVisualStyleBackColor = true;
            this.btnManualImgRegistrationForm.Click += new System.EventHandler(this.btnManualImgRegistrationForm_Click);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(225, 86);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(123, 19);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "1 Point - Shift only";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb1);
            this.groupBox3.Controls.Add(this.btnManualImgRegistrationForm);
            this.groupBox3.Controls.Add(this.btnSequenceFolder);
            this.groupBox3.Controls.Add(this.lbSequenceFolderPath);
            this.groupBox3.Controls.Add(this.lbSequenceFolderFileCount);
            this.groupBox3.Location = new System.Drawing.Point(12, 417);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 116);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registration Sequence";
            // 
            // btnSequenceFolder
            // 
            this.btnSequenceFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSequenceFolder.Location = new System.Drawing.Point(7, 30);
            this.btnSequenceFolder.Name = "btnSequenceFolder";
            this.btnSequenceFolder.Size = new System.Drawing.Size(136, 23);
            this.btnSequenceFolder.TabIndex = 0;
            this.btnSequenceFolder.Text = "Sequence folder";
            this.btnSequenceFolder.UseVisualStyleBackColor = true;
            this.btnSequenceFolder.Click += new System.EventHandler(this.btnSequenceFolder_Click);
            // 
            // lbSequenceFolderPath
            // 
            this.lbSequenceFolderPath.AutoSize = true;
            this.lbSequenceFolderPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSequenceFolderPath.Location = new System.Drawing.Point(149, 34);
            this.lbSequenceFolderPath.Name = "lbSequenceFolderPath";
            this.lbSequenceFolderPath.Size = new System.Drawing.Size(10, 15);
            this.lbSequenceFolderPath.TabIndex = 1;
            this.lbSequenceFolderPath.Text = ":";
            // 
            // lbSequenceFolderFileCount
            // 
            this.lbSequenceFolderFileCount.AutoSize = true;
            this.lbSequenceFolderFileCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSequenceFolderFileCount.Location = new System.Drawing.Point(149, 62);
            this.lbSequenceFolderFileCount.Name = "lbSequenceFolderFileCount";
            this.lbSequenceFolderFileCount.Size = new System.Drawing.Size(76, 15);
            this.lbSequenceFolderFileCount.TabIndex = 2;
            this.lbSequenceFolderFileCount.Text = "Files count: 0";
            // 
            // tbSamplePointsCount
            // 
            this.tbSamplePointsCount.Location = new System.Drawing.Point(161, 45);
            this.tbSamplePointsCount.Name = "tbSamplePointsCount";
            this.tbSamplePointsCount.Size = new System.Drawing.Size(100, 23);
            this.tbSamplePointsCount.TabIndex = 25;
            this.tbSamplePointsCount.Text = "40";
            this.tbSamplePointsCount.TextChanged += new System.EventHandler(this.tbSamplePointsCount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Number of sample points";
            // 
            // lbSamplePoints
            // 
            this.lbSamplePoints.FormattingEnabled = true;
            this.lbSamplePoints.ItemHeight = 15;
            this.lbSamplePoints.Location = new System.Drawing.Point(421, 48);
            this.lbSamplePoints.MultiColumn = true;
            this.lbSamplePoints.Name = "lbSamplePoints";
            this.lbSamplePoints.Size = new System.Drawing.Size(269, 94);
            this.lbSamplePoints.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Sample points :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 560);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbRotateOptions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbRenameReplace);
            this.Controls.Add(this.cbMidFrameReplace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAutoClickWait);
            this.Controls.Add(this.btnAutoClick);
            this.Controls.Add(this.btnGenerateMidFrame);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.labelOutputfolderPath);
            this.Controls.Add(this.btnOutputFolder);
            this.Controls.Add(this.cbFileNamePrefix);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.labelFileCount);
            this.Controls.Add(this.lableSourceFolderPath);
            this.Controls.Add(this.btnSelectFolder);
            this.Name = "Form1";
            this.Text = "TimeLapseTools";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lableSourceFolderPath;
        private System.Windows.Forms.Label labelFileCount;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.ComboBox cbFileNamePrefix;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.Label labelOutputfolderPath;
        private System.Windows.Forms.FolderBrowserDialog fBDOutput;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnGenerateMidFrame;
        private System.Windows.Forms.Button btnAutoClick;
        private System.Windows.Forms.TextBox tbAutoClickWait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbMidFrameReplace;
        private System.Windows.Forms.Button btnGammaCorrection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbGammaCorrectionSample;
        private System.Windows.Forms.Button btnSelectSample;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPreviewSampleArea;
        private System.Windows.Forms.TextBox tbSampleSize;
        private System.Windows.Forms.TextBox tbThreshold;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbRenameReplace;
        private System.Windows.Forms.ComboBox cbRotateOptions;
        private System.Windows.Forms.Button btnManualImgRegistrationForm;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSequenceFolder;
        private System.Windows.Forms.Label lbSequenceFolderPath;
        private System.Windows.Forms.Label lbSequenceFolderFileCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbSamplePoints;
        private System.Windows.Forms.TextBox tbSamplePointsCount;
        private System.Windows.Forms.Label label2;
    }
}

