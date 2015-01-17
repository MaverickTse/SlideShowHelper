namespace SlideShowHelperEN
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
            this.label6 = new System.Windows.Forms.Label();
            this.numAudiorate = new System.Windows.Forms.NumericUpDown();
            this.numScale = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numFramerate = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.lblAudRate = new System.Windows.Forms.Label();
            this.lblFPS = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.GP_method = new System.Windows.Forms.GroupBox();
            this.rbnFX = new System.Windows.Forms.RadioButton();
            this.rbnSC = new System.Windows.Forms.RadioButton();
            this.GP_Tune = new System.Windows.Forms.GroupBox();
            this.numPattern = new System.Windows.Forms.NumericUpDown();
            this.lblMaxPatt = new System.Windows.Forms.Label();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.lblFrameB = new System.Windows.Forms.Label();
            this.lblframeA = new System.Windows.Forms.Label();
            this.numTranDur = new System.Windows.Forms.NumericUpDown();
            this.numImgDur = new System.Windows.Forms.NumericUpDown();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblTransDur = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lbl_BG = new System.Windows.Forms.Label();
            this.GP_filename = new System.Windows.Forms.GroupBox();
            this.cbJp = new System.Windows.Forms.CheckBox();
            this.cbAsVideo = new System.Windows.Forms.CheckBox();
            this.numImgCount = new System.Windows.Forms.NumericUpDown();
            this.lblImgCount = new System.Windows.Forms.Label();
            this.numDigits = new System.Windows.Forms.NumericUpDown();
            this.btnEXO = new System.Windows.Forms.Button();
            this.txtEXO = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblEXO = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.lblDigits = new System.Windows.Forms.Label();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.DlgColor = new System.Windows.Forms.ColorDialog();
            this.DlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.DlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.lnkCopyRight = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAudiorate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFramerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.GP_method.SuspendLayout();
            this.GP_Tune.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPattern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTranDur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImgDur)).BeginInit();
            this.GP_filename.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImgCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDigits)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numAudiorate);
            this.groupBox1.Controls.Add(this.numScale);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numFramerate);
            this.groupBox1.Controls.Add(this.numHeight);
            this.groupBox1.Controls.Add(this.numWidth);
            this.groupBox1.Controls.Add(this.lblAudRate);
            this.groupBox1.Controls.Add(this.lblFPS);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Controls.Add(this.lblWidth);
            this.groupBox1.Location = new System.Drawing.Point(24, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Setup";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hz";
            // 
            // numAudiorate
            // 
            this.numAudiorate.Location = new System.Drawing.Point(103, 91);
            this.numAudiorate.Maximum = new decimal(new int[] {
            320000,
            0,
            0,
            0});
            this.numAudiorate.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numAudiorate.Name = "numAudiorate";
            this.numAudiorate.Size = new System.Drawing.Size(120, 22);
            this.numAudiorate.TabIndex = 4;
            this.numAudiorate.Value = new decimal(new int[] {
            44100,
            0,
            0,
            0});
            // 
            // numScale
            // 
            this.numScale.Location = new System.Drawing.Point(271, 58);
            this.numScale.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numScale.Name = "numScale";
            this.numScale.Size = new System.Drawing.Size(120, 22);
            this.numScale.TabIndex = 3;
            this.numScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(8, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "/";
            // 
            // numFramerate
            // 
            this.numFramerate.Location = new System.Drawing.Point(103, 58);
            this.numFramerate.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numFramerate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFramerate.Name = "numFramerate";
            this.numFramerate.Size = new System.Drawing.Size(120, 22);
            this.numFramerate.TabIndex = 2;
            this.numFramerate.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(270, 25);
            this.numHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(120, 22);
            this.numHeight.TabIndex = 1;
            this.numHeight.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(82, 25);
            this.numWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 22);
            this.numWidth.TabIndex = 0;
            this.numWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // lblAudRate
            // 
            this.lblAudRate.AutoSize = true;
            this.lblAudRate.Location = new System.Drawing.Point(19, 96);
            this.lblAudRate.Name = "lblAudRate";
            this.lblAudRate.Size = new System.Drawing.Size(54, 12);
            this.lblAudRate.TabIndex = 3;
            this.lblAudRate.Text = "Audio rate";
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(19, 63);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(51, 12);
            this.lblFPS.TabIndex = 2;
            this.lblFPS.Text = "Framerate";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(218, 30);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(36, 12);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(19, 30);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(34, 12);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width";
            // 
            // GP_method
            // 
            this.GP_method.Controls.Add(this.rbnFX);
            this.GP_method.Controls.Add(this.rbnSC);
            this.GP_method.Location = new System.Drawing.Point(27, 170);
            this.GP_method.Name = "GP_method";
            this.GP_method.Size = new System.Drawing.Size(416, 67);
            this.GP_method.TabIndex = 1;
            this.GP_method.TabStop = false;
            this.GP_method.Text = "Transition method";
            // 
            // rbnFX
            // 
            this.rbnFX.AutoSize = true;
            this.rbnFX.Location = new System.Drawing.Point(184, 31);
            this.rbnFX.Name = "rbnFX";
            this.rbnFX.Size = new System.Drawing.Size(118, 16);
            this.rbnFX.TabIndex = 6;
            this.rbnFX.TabStop = true;
            this.rbnFX.Text = "FX:SimpleWrap_V2";
            this.rbnFX.UseVisualStyleBackColor = true;
            // 
            // rbnSC
            // 
            this.rbnSC.AutoSize = true;
            this.rbnSC.Location = new System.Drawing.Point(22, 31);
            this.rbnSC.Name = "rbnSC";
            this.rbnSC.Size = new System.Drawing.Size(117, 16);
            this.rbnSC.TabIndex = 5;
            this.rbnSC.TabStop = true;
            this.rbnSC.Text = "Scene change object";
            this.rbnSC.UseVisualStyleBackColor = true;
            // 
            // GP_Tune
            // 
            this.GP_Tune.Controls.Add(this.numPattern);
            this.GP_Tune.Controls.Add(this.lblMaxPatt);
            this.GP_Tune.Controls.Add(this.cbRandom);
            this.GP_Tune.Controls.Add(this.lblFrameB);
            this.GP_Tune.Controls.Add(this.lblframeA);
            this.GP_Tune.Controls.Add(this.numTranDur);
            this.GP_Tune.Controls.Add(this.numImgDur);
            this.GP_Tune.Controls.Add(this.btnColor);
            this.GP_Tune.Controls.Add(this.lblTransDur);
            this.GP_Tune.Controls.Add(this.lblDuration);
            this.GP_Tune.Controls.Add(this.lbl_BG);
            this.GP_Tune.Location = new System.Drawing.Point(29, 259);
            this.GP_Tune.Name = "GP_Tune";
            this.GP_Tune.Size = new System.Drawing.Size(414, 212);
            this.GP_Tune.TabIndex = 2;
            this.GP_Tune.TabStop = false;
            this.GP_Tune.Text = "Tuning";
            // 
            // numPattern
            // 
            this.numPattern.Enabled = false;
            this.numPattern.Location = new System.Drawing.Point(171, 178);
            this.numPattern.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numPattern.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPattern.Name = "numPattern";
            this.numPattern.Size = new System.Drawing.Size(75, 22);
            this.numPattern.TabIndex = 11;
            this.numPattern.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMaxPatt
            // 
            this.lblMaxPatt.AutoSize = true;
            this.lblMaxPatt.Location = new System.Drawing.Point(45, 183);
            this.lblMaxPatt.Name = "lblMaxPatt";
            this.lblMaxPatt.Size = new System.Drawing.Size(92, 12);
            this.lblMaxPatt.TabIndex = 9;
            this.lblMaxPatt.Text = "Max no. of pattern";
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(21, 151);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(178, 16);
            this.cbRandom.TabIndex = 10;
            this.cbRandom.Text = "Randomize Scene change pattern";
            this.cbRandom.UseVisualStyleBackColor = true;
            this.cbRandom.CheckedChanged += new System.EventHandler(this.cbRandom_CheckedChanged);
            // 
            // lblFrameB
            // 
            this.lblFrameB.AutoSize = true;
            this.lblFrameB.Location = new System.Drawing.Point(256, 115);
            this.lblFrameB.Name = "lblFrameB";
            this.lblFrameB.Size = new System.Drawing.Size(36, 12);
            this.lblFrameB.TabIndex = 7;
            this.lblFrameB.Text = "frames";
            // 
            // lblframeA
            // 
            this.lblframeA.AutoSize = true;
            this.lblframeA.Location = new System.Drawing.Point(256, 73);
            this.lblframeA.Name = "lblframeA";
            this.lblframeA.Size = new System.Drawing.Size(36, 12);
            this.lblframeA.TabIndex = 6;
            this.lblframeA.Text = "frames";
            // 
            // numTranDur
            // 
            this.numTranDur.Location = new System.Drawing.Point(171, 110);
            this.numTranDur.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numTranDur.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTranDur.Name = "numTranDur";
            this.numTranDur.Size = new System.Drawing.Size(78, 22);
            this.numTranDur.TabIndex = 9;
            this.numTranDur.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numTranDur.ValueChanged += new System.EventHandler(this.numTranDur_ValueChanged);
            // 
            // numImgDur
            // 
            this.numImgDur.Location = new System.Drawing.Point(171, 68);
            this.numImgDur.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numImgDur.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numImgDur.Name = "numImgDur";
            this.numImgDur.Size = new System.Drawing.Size(78, 22);
            this.numImgDur.TabIndex = 8;
            this.numImgDur.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numImgDur.ValueChanged += new System.EventHandler(this.numImgDur_ValueChanged);
            // 
            // btnColor
            // 
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(171, 25);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(78, 23);
            this.btnColor.TabIndex = 7;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblTransDur
            // 
            this.lblTransDur.AutoSize = true;
            this.lblTransDur.Location = new System.Drawing.Point(21, 115);
            this.lblTransDur.Name = "lblTransDur";
            this.lblTransDur.Size = new System.Drawing.Size(98, 12);
            this.lblTransDur.TabIndex = 2;
            this.lblTransDur.Text = "Transistion duration";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(21, 73);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(95, 12);
            this.lblDuration.TabIndex = 1;
            this.lblDuration.Text = "Duration per image";
            // 
            // lbl_BG
            // 
            this.lbl_BG.AutoSize = true;
            this.lbl_BG.Location = new System.Drawing.Point(21, 30);
            this.lbl_BG.Name = "lbl_BG";
            this.lbl_BG.Size = new System.Drawing.Size(90, 12);
            this.lbl_BG.TabIndex = 0;
            this.lbl_BG.Text = "Background color";
            // 
            // GP_filename
            // 
            this.GP_filename.Controls.Add(this.cbJp);
            this.GP_filename.Controls.Add(this.cbAsVideo);
            this.GP_filename.Controls.Add(this.numImgCount);
            this.GP_filename.Controls.Add(this.lblImgCount);
            this.GP_filename.Controls.Add(this.numDigits);
            this.GP_filename.Controls.Add(this.btnEXO);
            this.GP_filename.Controls.Add(this.txtEXO);
            this.GP_filename.Controls.Add(this.txtSuffix);
            this.GP_filename.Controls.Add(this.txtPrefix);
            this.GP_filename.Controls.Add(this.btnFolder);
            this.GP_filename.Controls.Add(this.txtFolder);
            this.GP_filename.Controls.Add(this.lblEXO);
            this.GP_filename.Controls.Add(this.lblSuffix);
            this.GP_filename.Controls.Add(this.lblDigits);
            this.GP_filename.Controls.Add(this.lblPrefix);
            this.GP_filename.Controls.Add(this.lblFolder);
            this.GP_filename.Location = new System.Drawing.Point(31, 485);
            this.GP_filename.Name = "GP_filename";
            this.GP_filename.Size = new System.Drawing.Size(411, 179);
            this.GP_filename.TabIndex = 3;
            this.GP_filename.TabStop = false;
            this.GP_filename.Text = "Filename";
            // 
            // cbJp
            // 
            this.cbJp.AutoSize = true;
            this.cbJp.Location = new System.Drawing.Point(160, 127);
            this.cbJp.Name = "cbJp";
            this.cbJp.Size = new System.Drawing.Size(90, 16);
            this.cbJp.TabIndex = 21;
            this.cbJp.Text = "Japanese EXO";
            this.cbJp.UseVisualStyleBackColor = true;
            // 
            // cbAsVideo
            // 
            this.cbAsVideo.AutoSize = true;
            this.cbAsVideo.Location = new System.Drawing.Point(204, 56);
            this.cbAsVideo.Name = "cbAsVideo";
            this.cbAsVideo.Size = new System.Drawing.Size(154, 16);
            this.cbAsVideo.TabIndex = 20;
            this.cbAsVideo.Text = "Load Image as Video object";
            this.cbAsVideo.UseVisualStyleBackColor = true;
            // 
            // numImgCount
            // 
            this.numImgCount.Location = new System.Drawing.Point(96, 53);
            this.numImgCount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numImgCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numImgCount.Name = "numImgCount";
            this.numImgCount.Size = new System.Drawing.Size(79, 22);
            this.numImgCount.TabIndex = 14;
            this.numImgCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numImgCount.ValueChanged += new System.EventHandler(this.numImgCount_ValueChanged);
            // 
            // lblImgCount
            // 
            this.lblImgCount.AutoSize = true;
            this.lblImgCount.Location = new System.Drawing.Point(19, 58);
            this.lblImgCount.Name = "lblImgCount";
            this.lblImgCount.Size = new System.Drawing.Size(67, 12);
            this.lblImgCount.TabIndex = 13;
            this.lblImgCount.Text = "No. of Image";
            // 
            // numDigits
            // 
            this.numDigits.Location = new System.Drawing.Point(160, 102);
            this.numDigits.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDigits.Name = "numDigits";
            this.numDigits.Size = new System.Drawing.Size(56, 22);
            this.numDigits.TabIndex = 16;
            this.numDigits.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDigits.ValueChanged += new System.EventHandler(this.numDigits_ValueChanged);
            // 
            // btnEXO
            // 
            this.btnEXO.Location = new System.Drawing.Point(292, 147);
            this.btnEXO.Name = "btnEXO";
            this.btnEXO.Size = new System.Drawing.Size(75, 23);
            this.btnEXO.TabIndex = 19;
            this.btnEXO.Text = "Browse";
            this.btnEXO.UseVisualStyleBackColor = true;
            this.btnEXO.Click += new System.EventHandler(this.btnEXO_Click);
            // 
            // txtEXO
            // 
            this.txtEXO.Location = new System.Drawing.Point(19, 147);
            this.txtEXO.Name = "txtEXO";
            this.txtEXO.Size = new System.Drawing.Size(263, 22);
            this.txtEXO.TabIndex = 18;
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(231, 102);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(136, 22);
            this.txtSuffix.TabIndex = 17;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(19, 102);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(132, 22);
            this.txtPrefix.TabIndex = 15;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(328, 22);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(73, 23);
            this.btnFolder.TabIndex = 13;
            this.btnFolder.Text = "Browse";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(96, 22);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(232, 22);
            this.txtFolder.TabIndex = 12;
            // 
            // lblEXO
            // 
            this.lblEXO.AutoSize = true;
            this.lblEXO.Location = new System.Drawing.Point(19, 129);
            this.lblEXO.Name = "lblEXO";
            this.lblEXO.Size = new System.Drawing.Size(46, 12);
            this.lblEXO.TabIndex = 4;
            this.lblEXO.Text = "EXO file";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(231, 83);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(34, 12);
            this.lblSuffix.TabIndex = 3;
            this.lblSuffix.Text = "Suffix";
            // 
            // lblDigits
            // 
            this.lblDigits.AutoSize = true;
            this.lblDigits.Location = new System.Drawing.Point(159, 83);
            this.lblDigits.Name = "lblDigits";
            this.lblDigits.Size = new System.Drawing.Size(32, 12);
            this.lblDigits.TabIndex = 2;
            this.lblDigits.Text = "Digits";
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(19, 83);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(33, 12);
            this.lblPrefix.TabIndex = 1;
            this.lblPrefix.Text = "Prefix";
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(19, 27);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(67, 12);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "Image Folder";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(357, 672);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "SaveEXO";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DlgSaveFile
            // 
            this.DlgSaveFile.Filter = "EXO file(*.exo)|*.exo";
            // 
            // lnkCopyRight
            // 
            this.lnkCopyRight.AutoSize = true;
            this.lnkCopyRight.Location = new System.Drawing.Point(25, 683);
            this.lnkCopyRight.Name = "lnkCopyRight";
            this.lnkCopyRight.Size = new System.Drawing.Size(180, 12);
            this.lnkCopyRight.TabIndex = 21;
            this.lnkCopyRight.TabStop = true;
            this.lnkCopyRight.Text = "Copyrighted by Maverick Tse (2014)";
            this.lnkCopyRight.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopyRight_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 707);
            this.Controls.Add(this.lnkCopyRight);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.GP_filename);
            this.Controls.Add(this.GP_Tune);
            this.Controls.Add(this.GP_method);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Slide Show Helper for AviUtl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAudiorate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFramerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.GP_method.ResumeLayout(false);
            this.GP_method.PerformLayout();
            this.GP_Tune.ResumeLayout(false);
            this.GP_Tune.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPattern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTranDur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImgDur)).EndInit();
            this.GP_filename.ResumeLayout(false);
            this.GP_filename.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImgCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDigits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numAudiorate;
        private System.Windows.Forms.NumericUpDown numScale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numFramerate;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label lblAudRate;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.GroupBox GP_method;
        private System.Windows.Forms.RadioButton rbnFX;
        private System.Windows.Forms.RadioButton rbnSC;
        private System.Windows.Forms.GroupBox GP_Tune;
        private System.Windows.Forms.Label lblTransDur;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lbl_BG;
        private System.Windows.Forms.NumericUpDown numPattern;
        private System.Windows.Forms.Label lblMaxPatt;
        private System.Windows.Forms.CheckBox cbRandom;
        private System.Windows.Forms.Label lblFrameB;
        private System.Windows.Forms.Label lblframeA;
        private System.Windows.Forms.NumericUpDown numTranDur;
        private System.Windows.Forms.NumericUpDown numImgDur;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.GroupBox GP_filename;
        private System.Windows.Forms.Button btnEXO;
        private System.Windows.Forms.TextBox txtEXO;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lblEXO;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.Label lblDigits;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.NumericUpDown numDigits;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numImgCount;
        private System.Windows.Forms.Label lblImgCount;
        private System.Windows.Forms.ColorDialog DlgColor;
        private System.Windows.Forms.FolderBrowserDialog DlgFolder;
        private System.Windows.Forms.SaveFileDialog DlgSaveFile;
        private System.Windows.Forms.LinkLabel lnkCopyRight;
        private System.Windows.Forms.CheckBox cbJp;
        private System.Windows.Forms.CheckBox cbAsVideo;
    }
}

