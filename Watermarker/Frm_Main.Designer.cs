namespace Simple_Image_Watermarker
{
    partial class Frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.tbImgDirPath = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbWatermarkImage = new System.Windows.Forms.TextBox();
            this.btnOpenImageDirFile = new System.Windows.Forms.Button();
            this.btnOpenWatermarkFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownMargin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rbBR = new System.Windows.Forms.RadioButton();
            this.rbMR = new System.Windows.Forms.RadioButton();
            this.rbTR = new System.Windows.Forms.RadioButton();
            this.rbBM = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbTM = new System.Windows.Forms.RadioButton();
            this.rbRep = new System.Windows.Forms.RadioButton();
            this.rbBL = new System.Windows.Forms.RadioButton();
            this.rbML = new System.Windows.Forms.RadioButton();
            this.rbTL = new System.Windows.Forms.RadioButton();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.lblScale = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbFolder = new System.Windows.Forms.RadioButton();
            this.rbSingleFile = new System.Windows.Forms.RadioButton();
            this.openFileDialogWatermarkImage = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogImages = new System.Windows.Forms.FolderBrowserDialog();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.tbSuffix = new System.Windows.Forms.TextBox();
            this.tbWatermarkFolderName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mainPnl = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownRotation = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCopyright = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            this.panel2.SuspendLayout();
            this.mainPnl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotation)).BeginInit();
            this.SuspendLayout();
            // 
            // tbImgDirPath
            // 
            this.tbImgDirPath.AllowDrop = true;
            this.tbImgDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImgDirPath.Location = new System.Drawing.Point(3, 75);
            this.tbImgDirPath.Name = "tbImgDirPath";
            this.tbImgDirPath.Size = new System.Drawing.Size(475, 20);
            this.tbImgDirPath.TabIndex = 11;
            this.tbImgDirPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbFileFolder_DragDrop);
            this.tbImgDirPath.DragOver += new System.Windows.Forms.DragEventHandler(this.tbFileFolder_DragOver);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbWatermarkImage
            // 
            this.tbWatermarkImage.AllowDrop = true;
            this.tbWatermarkImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWatermarkImage.Location = new System.Drawing.Point(3, 120);
            this.tbWatermarkImage.Name = "tbWatermarkImage";
            this.tbWatermarkImage.Size = new System.Drawing.Size(475, 20);
            this.tbWatermarkImage.TabIndex = 13;
            this.tbWatermarkImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbFileFolder_DragDrop);
            this.tbWatermarkImage.DragOver += new System.Windows.Forms.DragEventHandler(this.tbFileFolder_DragOver);
            // 
            // btnOpenImageDirFile
            // 
            this.btnOpenImageDirFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenImageDirFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenImageDirFile.Location = new System.Drawing.Point(484, 73);
            this.btnOpenImageDirFile.Name = "btnOpenImageDirFile";
            this.btnOpenImageDirFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImageDirFile.TabIndex = 12;
            this.btnOpenImageDirFile.Text = "Search";
            this.btnOpenImageDirFile.UseVisualStyleBackColor = true;
            this.btnOpenImageDirFile.Click += new System.EventHandler(this.btnOpenImageDirFile_Click);
            // 
            // btnOpenWatermarkFile
            // 
            this.btnOpenWatermarkFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenWatermarkFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenWatermarkFile.Location = new System.Drawing.Point(484, 118);
            this.btnOpenWatermarkFile.Name = "btnOpenWatermarkFile";
            this.btnOpenWatermarkFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenWatermarkFile.TabIndex = 14;
            this.btnOpenWatermarkFile.Text = "Search";
            this.btnOpenWatermarkFile.UseVisualStyleBackColor = true;
            this.btnOpenWatermarkFile.Click += new System.EventHandler(this.btnOpenWatermarkFile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.numericUpDownRotation);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numericUpDownMargin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbBR);
            this.panel1.Controls.Add(this.rbMR);
            this.panel1.Controls.Add(this.rbTR);
            this.panel1.Controls.Add(this.rbBM);
            this.panel1.Controls.Add(this.rbC);
            this.panel1.Controls.Add(this.rbTM);
            this.panel1.Controls.Add(this.rbRep);
            this.panel1.Controls.Add(this.rbBL);
            this.panel1.Controls.Add(this.rbML);
            this.panel1.Controls.Add(this.rbTL);
            this.panel1.Location = new System.Drawing.Point(3, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 120);
            this.panel1.TabIndex = 15;
            // 
            // numericUpDownMargin
            // 
            this.numericUpDownMargin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownMargin.Location = new System.Drawing.Point(119, 88);
            this.numericUpDownMargin.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownMargin.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericUpDownMargin.Name = "numericUpDownMargin";
            this.numericUpDownMargin.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownMargin.TabIndex = 30;
            this.numericUpDownMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMargin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMargin.ValueChanged += new System.EventHandler(this.numericUpDownMargin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Margin:";
            // 
            // rbBR
            // 
            this.rbBR.AutoSize = true;
            this.rbBR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbBR.Location = new System.Drawing.Point(273, 49);
            this.rbBR.Name = "rbBR";
            this.rbBR.Size = new System.Drawing.Size(86, 17);
            this.rbBR.TabIndex = 28;
            this.rbBR.Text = "Bottom Right";
            this.rbBR.UseVisualStyleBackColor = true;
            this.rbBR.CheckedChanged += new System.EventHandler(this.rbBR_CheckedChanged);
            // 
            // rbMR
            // 
            this.rbMR.AutoSize = true;
            this.rbMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMR.Location = new System.Drawing.Point(273, 26);
            this.rbMR.Name = "rbMR";
            this.rbMR.Size = new System.Drawing.Size(70, 17);
            this.rbMR.TabIndex = 25;
            this.rbMR.Text = "Mid Right";
            this.rbMR.UseVisualStyleBackColor = true;
            this.rbMR.CheckedChanged += new System.EventHandler(this.rbMR_CheckedChanged);
            // 
            // rbTR
            // 
            this.rbTR.AutoSize = true;
            this.rbTR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTR.Location = new System.Drawing.Point(273, 3);
            this.rbTR.Name = "rbTR";
            this.rbTR.Size = new System.Drawing.Size(72, 17);
            this.rbTR.TabIndex = 22;
            this.rbTR.Text = "Top Right";
            this.rbTR.UseVisualStyleBackColor = true;
            this.rbTR.CheckedChanged += new System.EventHandler(this.rbTR_CheckedChanged);
            // 
            // rbBM
            // 
            this.rbBM.AutoSize = true;
            this.rbBM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbBM.Location = new System.Drawing.Point(140, 49);
            this.rbBM.Name = "rbBM";
            this.rbBM.Size = new System.Drawing.Size(78, 17);
            this.rbBM.TabIndex = 27;
            this.rbBM.Text = "Bottom Mid";
            this.rbBM.UseVisualStyleBackColor = true;
            this.rbBM.CheckedChanged += new System.EventHandler(this.rbBM_CheckedChanged);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbC.Location = new System.Drawing.Point(140, 26);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(56, 17);
            this.rbC.TabIndex = 24;
            this.rbC.Text = "Center";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.CheckedChanged += new System.EventHandler(this.rbC_CheckedChanged);
            // 
            // rbTM
            // 
            this.rbTM.AutoSize = true;
            this.rbTM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTM.Location = new System.Drawing.Point(140, 3);
            this.rbTM.Name = "rbTM";
            this.rbTM.Size = new System.Drawing.Size(64, 17);
            this.rbTM.TabIndex = 21;
            this.rbTM.Text = "Top Mid";
            this.rbTM.UseVisualStyleBackColor = true;
            this.rbTM.CheckedChanged += new System.EventHandler(this.rbTM_CheckedChanged);
            // 
            // rbRep
            // 
            this.rbRep.AutoSize = true;
            this.rbRep.Checked = true;
            this.rbRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbRep.Location = new System.Drawing.Point(3, 88);
            this.rbRep.Name = "rbRep";
            this.rbRep.Size = new System.Drawing.Size(60, 17);
            this.rbRep.TabIndex = 29;
            this.rbRep.TabStop = true;
            this.rbRep.Text = "Repeat";
            this.rbRep.UseVisualStyleBackColor = true;
            this.rbRep.CheckedChanged += new System.EventHandler(this.rbRep_CheckedChanged);
            // 
            // rbBL
            // 
            this.rbBL.AutoSize = true;
            this.rbBL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbBL.Location = new System.Drawing.Point(3, 49);
            this.rbBL.Name = "rbBL";
            this.rbBL.Size = new System.Drawing.Size(79, 17);
            this.rbBL.TabIndex = 26;
            this.rbBL.Text = "Bottom Left";
            this.rbBL.UseVisualStyleBackColor = true;
            this.rbBL.CheckedChanged += new System.EventHandler(this.rbBL_CheckedChanged);
            // 
            // rbML
            // 
            this.rbML.AutoSize = true;
            this.rbML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbML.Location = new System.Drawing.Point(3, 26);
            this.rbML.Name = "rbML";
            this.rbML.Size = new System.Drawing.Size(63, 17);
            this.rbML.TabIndex = 23;
            this.rbML.Text = "Mid Left";
            this.rbML.UseVisualStyleBackColor = true;
            this.rbML.CheckedChanged += new System.EventHandler(this.rbML_CheckedChanged);
            // 
            // rbTL
            // 
            this.rbTL.AutoSize = true;
            this.rbTL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTL.Location = new System.Drawing.Point(3, 3);
            this.rbTL.Name = "rbTL";
            this.rbTL.Size = new System.Drawing.Size(65, 17);
            this.rbTL.TabIndex = 20;
            this.rbTL.Text = "Top Left";
            this.rbTL.UseVisualStyleBackColor = true;
            this.rbTL.CheckedChanged += new System.EventHandler(this.rbTL_CheckedChanged);
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarOpacity.AutoSize = false;
            this.trackBarOpacity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarOpacity.Location = new System.Drawing.Point(2, 314);
            this.trackBarOpacity.Maximum = 100;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(557, 24);
            this.trackBarOpacity.TabIndex = 40;
            this.trackBarOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarOpacity.Value = 10;
            this.trackBarOpacity.ValueChanged += new System.EventHandler(this.trackBarOpacity_ValueChanged);
            // 
            // lblOpacity
            // 
            this.lblOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(2, 298);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(69, 13);
            this.lblOpacity.TabIndex = 7;
            this.lblOpacity.Text = "Opacity: 10%";
            // 
            // trackBarScale
            // 
            this.trackBarScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarScale.AutoSize = false;
            this.trackBarScale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarScale.Location = new System.Drawing.Point(2, 362);
            this.trackBarScale.Maximum = 500;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(557, 24);
            this.trackBarScale.TabIndex = 41;
            this.trackBarScale.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarScale.Value = 100;
            this.trackBarScale.ValueChanged += new System.EventHandler(this.trackBarScale_ValueChanged);
            // 
            // lblScale
            // 
            this.lblScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(2, 346);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(121, 13);
            this.lblScale.TabIndex = 9;
            this.lblScale.Text = "Watermark Scale: 100%";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(12, 406);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(540, 23);
            this.btnStart.TabIndex = 50;
            this.btnStart.Text = "Start Watermarking";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.RestoreDirectory = true;
            this.openFileDialogImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogImage_FileOk);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbFolder);
            this.panel2.Controls.Add(this.rbSingleFile);
            this.panel2.Location = new System.Drawing.Point(42, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 24);
            this.panel2.TabIndex = 1;
            // 
            // rbFolder
            // 
            this.rbFolder.AutoSize = true;
            this.rbFolder.Checked = true;
            this.rbFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFolder.Location = new System.Drawing.Point(86, 3);
            this.rbFolder.Name = "rbFolder";
            this.rbFolder.Size = new System.Drawing.Size(88, 17);
            this.rbFolder.TabIndex = 3;
            this.rbFolder.TabStop = true;
            this.rbFolder.Text = "Whole Folder";
            this.rbFolder.UseVisualStyleBackColor = true;
            this.rbFolder.CheckedChanged += new System.EventHandler(this.rbFolder_CheckedChanged);
            // 
            // rbSingleFile
            // 
            this.rbSingleFile.AutoSize = true;
            this.rbSingleFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSingleFile.Location = new System.Drawing.Point(3, 3);
            this.rbSingleFile.Name = "rbSingleFile";
            this.rbSingleFile.Size = new System.Drawing.Size(73, 17);
            this.rbSingleFile.TabIndex = 2;
            this.rbSingleFile.Text = "Single File";
            this.rbSingleFile.UseVisualStyleBackColor = true;
            this.rbSingleFile.CheckedChanged += new System.EventHandler(this.rbSingleFile_CheckedChanged);
            // 
            // openFileDialogWatermarkImage
            // 
            this.openFileDialogWatermarkImage.FileName = "openFileDialog1";
            this.openFileDialogWatermarkImage.RestoreDirectory = true;
            this.openFileDialogWatermarkImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogWatermarkImage_FileOk);
            // 
            // folderBrowserDialogImages
            // 
            this.folderBrowserDialogImages.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(3, 59);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(76, 13);
            this.lblInput.TabIndex = 12;
            this.lblInput.Text = "Input Image/s:";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(3, 34);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(37, 13);
            this.lblMode.TabIndex = 13;
            this.lblMode.Text = "Mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Watermark Image:";
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(14, 390);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(24, 13);
            this.lblProgress.TabIndex = 15;
            this.lblProgress.Text = "0/0";
            // 
            // tbSuffix
            // 
            this.tbSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSuffix.Location = new System.Drawing.Point(373, 226);
            this.tbSuffix.Name = "tbSuffix";
            this.tbSuffix.Size = new System.Drawing.Size(186, 20);
            this.tbSuffix.TabIndex = 35;
            this.tbSuffix.Text = "_wm";
            // 
            // tbWatermarkFolderName
            // 
            this.tbWatermarkFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWatermarkFolderName.Location = new System.Drawing.Point(373, 270);
            this.tbWatermarkFolderName.Name = "tbWatermarkFolderName";
            this.tbWatermarkFolderName.Size = new System.Drawing.Size(186, 20);
            this.tbWatermarkFolderName.TabIndex = 36;
            this.tbWatermarkFolderName.Text = "watermarked";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Suffix:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Watermarked Folder-Name:";
            // 
            // mainPnl
            // 
            this.mainPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPnl.Controls.Add(this.label7);
            this.mainPnl.Controls.Add(this.tbCopyright);
            this.mainPnl.Controls.Add(this.label5);
            this.mainPnl.Controls.Add(this.lblMode);
            this.mainPnl.Controls.Add(this.tbImgDirPath);
            this.mainPnl.Controls.Add(this.label4);
            this.mainPnl.Controls.Add(this.tbWatermarkImage);
            this.mainPnl.Controls.Add(this.lblOpacity);
            this.mainPnl.Controls.Add(this.lblScale);
            this.mainPnl.Controls.Add(this.label3);
            this.mainPnl.Controls.Add(this.trackBarScale);
            this.mainPnl.Controls.Add(this.tbWatermarkFolderName);
            this.mainPnl.Controls.Add(this.trackBarOpacity);
            this.mainPnl.Controls.Add(this.btnOpenImageDirFile);
            this.mainPnl.Controls.Add(this.tbSuffix);
            this.mainPnl.Controls.Add(this.btnOpenWatermarkFile);
            this.mainPnl.Controls.Add(this.panel1);
            this.mainPnl.Controls.Add(this.label2);
            this.mainPnl.Controls.Add(this.lblInput);
            this.mainPnl.Controls.Add(this.panel2);
            this.mainPnl.Controls.Add(this.menuStrip1);
            this.mainPnl.Location = new System.Drawing.Point(-1, -1);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(567, 388);
            this.mainPnl.TabIndex = 20;
            this.mainPnl.Click += new System.EventHandler(this.mainPnl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Watermark Positioning:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            this.websiteToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            this.websiteToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ToolStripMenuItem_MouseMove);
            // 
            // numericUpDownRotation
            // 
            this.numericUpDownRotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownRotation.Location = new System.Drawing.Point(272, 88);
            this.numericUpDownRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownRotation.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDownRotation.Name = "numericUpDownRotation";
            this.numericUpDownRotation.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownRotation.TabIndex = 32;
            this.numericUpDownRotation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownRotation.ValueChanged += new System.EventHandler(this.numericUpDownRotation_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Rotation:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Metadata Copyright:";
            // 
            // tbCopyright
            // 
            this.tbCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCopyright.Location = new System.Drawing.Point(373, 186);
            this.tbCopyright.Name = "tbCopyright";
            this.tbCopyright.Size = new System.Drawing.Size(186, 20);
            this.tbCopyright.TabIndex = 34;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 441);
            this.Controls.Add(this.mainPnl);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(580, 480);
            this.Name = "Frm_Main";
            this.Text = "Simple Image Watermarker";
            this.Click += new System.EventHandler(this.Frm_Main_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mainPnl.ResumeLayout(false);
            this.mainPnl.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbImgDirPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbWatermarkImage;
        private System.Windows.Forms.Button btnOpenImageDirFile;
        private System.Windows.Forms.Button btnOpenWatermarkFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbBR;
        private System.Windows.Forms.RadioButton rbMR;
        private System.Windows.Forms.RadioButton rbTR;
        private System.Windows.Forms.RadioButton rbBM;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbTM;
        private System.Windows.Forms.RadioButton rbRep;
        private System.Windows.Forms.RadioButton rbBL;
        private System.Windows.Forms.RadioButton rbML;
        private System.Windows.Forms.RadioButton rbTL;
        private System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.NumericUpDown numericUpDownMargin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarScale;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbFolder;
        private System.Windows.Forms.RadioButton rbSingleFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogWatermarkImage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogImages;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.TextBox tbSuffix;
        private System.Windows.Forms.TextBox tbWatermarkFolderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDownRotation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCopyright;
    }
}

