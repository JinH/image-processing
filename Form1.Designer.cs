namespace ImageProcessing
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
            this.components = new System.ComponentModel.Container();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnNegative = new System.Windows.Forms.Button();
            this.GBBrightness = new System.Windows.Forms.GroupBox();
            this.lblDashes = new System.Windows.Forms.Label();
            this.btnLighten = new System.Windows.Forms.Button();
            this.btnDarken = new System.Windows.Forms.Button();
            this.btnSunset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GBFilters = new System.Windows.Forms.GroupBox();
            this.btnViolet = new System.Windows.Forms.Button();
            this.btnIndigo = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.btnVerticalFlip = new System.Windows.Forms.Button();
            this.ttIndigo = new System.Windows.Forms.Button();
            this.btnHorizontalFlip = new System.Windows.Forms.Button();
            this.ttBrowse = new System.Windows.Forms.ToolTip(this.components);
            this.ttDarken = new System.Windows.Forms.ToolTip(this.components);
            this.ttLighten = new System.Windows.Forms.ToolTip(this.components);
            this.ttNegative = new System.Windows.Forms.ToolTip(this.components);
            this.ttSunset = new System.Windows.Forms.ToolTip(this.components);
            this.ttGrayscale = new System.Windows.Forms.ToolTip(this.components);
            this.ttHorizontalFlip = new System.Windows.Forms.ToolTip(this.components);
            this.ttVerticalFlip = new System.Windows.Forms.ToolTip(this.components);
            this.tt180Degrees = new System.Windows.Forms.ToolTip(this.components);
            this.ttRed = new System.Windows.Forms.ToolTip(this.components);
            this.ttOrange = new System.Windows.Forms.ToolTip(this.components);
            this.ttGreen = new System.Windows.Forms.ToolTip(this.components);
            this.ttYellow = new System.Windows.Forms.ToolTip(this.components);
            this.ttBlue = new System.Windows.Forms.ToolTip(this.components);
            this.ttViolet = new System.Windows.Forms.ToolTip(this.components);
            this.Indigo = new System.Windows.Forms.ToolTip(this.components);
            this.btnSwitch = new System.Windows.Forms.Button();
            this.ttSwitch = new System.Windows.Forms.ToolTip(this.components);
            this.btnPolarize = new System.Windows.Forms.Button();
            this.btnBlur = new System.Windows.Forms.Button();
            this.GBEasy = new System.Windows.Forms.GroupBox();
            this.GBMedium = new System.Windows.Forms.GroupBox();
            this.GBPixellate = new System.Windows.Forms.GroupBox();
            this.CBPixellate = new System.Windows.Forms.ComboBox();
            this.btnPixellate = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.VSBScoll = new System.Windows.Forms.VScrollBar();
            this.GBHard = new System.Windows.Forms.GroupBox();
            this.GBZoom = new System.Windows.Forms.GroupBox();
            this.CBMagnification = new System.Windows.Forms.ComboBox();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnRecursion = new System.Windows.Forms.Button();
            this.ttPolarize = new System.Windows.Forms.ToolTip(this.components);
            this.ttBlur = new System.Windows.Forms.ToolTip(this.components);
            this.ttSort = new System.Windows.Forms.ToolTip(this.components);
            this.ttPixellate = new System.Windows.Forms.ToolTip(this.components);
            this.ttRecursion = new System.Windows.Forms.ToolTip(this.components);
            this.ttZoom = new System.Windows.Forms.ToolTip(this.components);
            this.RTBSteganography = new System.Windows.Forms.RichTextBox();
            this.GBSteganography = new System.Windows.Forms.GroupBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.ttRead = new System.Windows.Forms.ToolTip(this.components);
            this.ttWrite = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.GBBrightness.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.GBFilters.SuspendLayout();
            this.GBEasy.SuspendLayout();
            this.GBMedium.SuspendLayout();
            this.GBPixellate.SuspendLayout();
            this.GBHard.SuspendLayout();
            this.GBZoom.SuspendLayout();
            this.GBSteganography.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(565, 303);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.ttBrowse.SetToolTip(this.btnBrowse, "Click to browse for an image");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(337, 54);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(320, 240);
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // btnNegative
            // 
            this.btnNegative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNegative.ForeColor = System.Drawing.Color.Yellow;
            this.btnNegative.Location = new System.Drawing.Point(0, 19);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(99, 23);
            this.btnNegative.TabIndex = 6;
            this.btnNegative.Text = "Negative";
            this.ttNegative.SetToolTip(this.btnNegative, "Click to make the image negative. ");
            this.btnNegative.UseVisualStyleBackColor = false;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // GBBrightness
            // 
            this.GBBrightness.Controls.Add(this.lblDashes);
            this.GBBrightness.Controls.Add(this.btnLighten);
            this.GBBrightness.Controls.Add(this.btnDarken);
            this.GBBrightness.Location = new System.Drawing.Point(12, 54);
            this.GBBrightness.Name = "GBBrightness";
            this.GBBrightness.Size = new System.Drawing.Size(204, 100);
            this.GBBrightness.TabIndex = 2;
            this.GBBrightness.TabStop = false;
            this.GBBrightness.Text = "Brightness";
            // 
            // lblDashes
            // 
            this.lblDashes.AutoSize = true;
            this.lblDashes.Location = new System.Drawing.Point(70, 45);
            this.lblDashes.Name = "lblDashes";
            this.lblDashes.Size = new System.Drawing.Size(64, 13);
            this.lblDashes.TabIndex = 9;
            this.lblDashes.Text = "-------------------";
            // 
            // btnLighten
            // 
            this.btnLighten.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLighten.Location = new System.Drawing.Point(138, 30);
            this.btnLighten.Name = "btnLighten";
            this.btnLighten.Size = new System.Drawing.Size(45, 45);
            this.btnLighten.TabIndex = 4;
            this.btnLighten.Text = "+";
            this.ttLighten.SetToolTip(this.btnLighten, "Click to lighten the image. ");
            this.btnLighten.UseVisualStyleBackColor = true;
            this.btnLighten.Click += new System.EventHandler(this.btnLighten_Click);
            // 
            // btnDarken
            // 
            this.btnDarken.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarken.Location = new System.Drawing.Point(19, 30);
            this.btnDarken.Name = "btnDarken";
            this.btnDarken.Size = new System.Drawing.Size(45, 45);
            this.btnDarken.TabIndex = 3;
            this.btnDarken.Text = "-";
            this.ttDarken.SetToolTip(this.btnDarken, "Click to darken the image.\r\n");
            this.btnDarken.UseVisualStyleBackColor = true;
            this.btnDarken.Click += new System.EventHandler(this.btnDarken_Click);
            // 
            // btnSunset
            // 
            this.btnSunset.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSunset.Location = new System.Drawing.Point(105, 19);
            this.btnSunset.Name = "btnSunset";
            this.btnSunset.Size = new System.Drawing.Size(99, 23);
            this.btnSunset.TabIndex = 7;
            this.btnSunset.Text = "Sunset";
            this.ttSunset.SetToolTip(this.btnSunset, "Click to apply a sunset effect to the target image. ");
            this.btnSunset.UseVisualStyleBackColor = false;
            this.btnSunset.Click += new System.EventHandler(this.btnSunset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestoreToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // RestoreToolStripMenuItem
            // 
            this.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem";
            this.RestoreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.RestoreToolStripMenuItem.Text = "Restore";
            this.RestoreToolStripMenuItem.Click += new System.EventHandler(this.RestoreToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // GBFilters
            // 
            this.GBFilters.Controls.Add(this.btnViolet);
            this.GBFilters.Controls.Add(this.btnIndigo);
            this.GBFilters.Controls.Add(this.btnBlue);
            this.GBFilters.Controls.Add(this.btnGreen);
            this.GBFilters.Controls.Add(this.btnYellow);
            this.GBFilters.Controls.Add(this.btnOrange);
            this.GBFilters.Controls.Add(this.btnRed);
            this.GBFilters.Location = new System.Drawing.Point(222, 54);
            this.GBFilters.Name = "GBFilters";
            this.GBFilters.Size = new System.Drawing.Size(109, 280);
            this.GBFilters.TabIndex = 13;
            this.GBFilters.TabStop = false;
            this.GBFilters.Text = "Filters";
            // 
            // btnViolet
            // 
            this.btnViolet.BackColor = System.Drawing.Color.Violet;
            this.btnViolet.Location = new System.Drawing.Point(17, 204);
            this.btnViolet.Name = "btnViolet";
            this.btnViolet.Size = new System.Drawing.Size(75, 23);
            this.btnViolet.TabIndex = 20;
            this.btnViolet.Text = "Violet";
            this.ttViolet.SetToolTip(this.btnViolet, "Click to apply a violet filter onto the image.");
            this.btnViolet.UseVisualStyleBackColor = false;
            this.btnViolet.Click += new System.EventHandler(this.btnViolet_Click);
            // 
            // btnIndigo
            // 
            this.btnIndigo.BackColor = System.Drawing.Color.Indigo;
            this.btnIndigo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIndigo.Location = new System.Drawing.Point(17, 175);
            this.btnIndigo.Name = "btnIndigo";
            this.btnIndigo.Size = new System.Drawing.Size(75, 23);
            this.btnIndigo.TabIndex = 19;
            this.btnIndigo.Text = "Indigo";
            this.Indigo.SetToolTip(this.btnIndigo, "Click to apply an indigo filter onto the image.");
            this.btnIndigo.UseVisualStyleBackColor = false;
            this.btnIndigo.Click += new System.EventHandler(this.btnIndigo_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBlue.Location = new System.Drawing.Point(17, 146);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBlue.TabIndex = 18;
            this.btnBlue.Text = "Blue";
            this.ttBlue.SetToolTip(this.btnBlue, "Click to apply a blue filter onto the image.");
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(17, 117);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(75, 23);
            this.btnGreen.TabIndex = 17;
            this.btnGreen.Text = "Green";
            this.ttGreen.SetToolTip(this.btnGreen, "Click to apply a green filter onto the image.");
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(17, 88);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(75, 23);
            this.btnYellow.TabIndex = 16;
            this.btnYellow.Text = "Yellow";
            this.ttYellow.SetToolTip(this.btnYellow, "Click to apply a yellow filter onto the image.");
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.Location = new System.Drawing.Point(17, 59);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(75, 23);
            this.btnOrange.TabIndex = 15;
            this.btnOrange.Text = "Orange";
            this.ttOrange.SetToolTip(this.btnOrange, "Click to apply an orange filter onto the image.");
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(17, 30);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 14;
            this.btnRed.Text = "Red";
            this.ttRed.SetToolTip(this.btnRed, "Click to apply a red filter onto the image.");
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.BackColor = System.Drawing.Color.Silver;
            this.btnGrayscale.Location = new System.Drawing.Point(0, 48);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(204, 23);
            this.btnGrayscale.TabIndex = 8;
            this.btnGrayscale.Text = "Convert to Grayscale";
            this.ttGrayscale.SetToolTip(this.btnGrayscale, "Click to convert to grayscale. ");
            this.btnGrayscale.UseVisualStyleBackColor = false;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // btnVerticalFlip
            // 
            this.btnVerticalFlip.Location = new System.Drawing.Point(105, 77);
            this.btnVerticalFlip.Name = "btnVerticalFlip";
            this.btnVerticalFlip.Size = new System.Drawing.Size(99, 23);
            this.btnVerticalFlip.TabIndex = 10;
            this.btnVerticalFlip.Text = "Flip Vertically";
            this.ttVerticalFlip.SetToolTip(this.btnVerticalFlip, "Click to flip the image vertically. ");
            this.btnVerticalFlip.UseVisualStyleBackColor = true;
            this.btnVerticalFlip.Click += new System.EventHandler(this.btnVerticalFlip_Click);
            // 
            // ttIndigo
            // 
            this.ttIndigo.Location = new System.Drawing.Point(0, 106);
            this.ttIndigo.Name = "ttIndigo";
            this.ttIndigo.Size = new System.Drawing.Size(204, 23);
            this.ttIndigo.TabIndex = 11;
            this.ttIndigo.Text = "Rotate 180 Degrees";
            this.tt180Degrees.SetToolTip(this.ttIndigo, "Click to rotate the image 180 degrees. ");
            this.ttIndigo.UseVisualStyleBackColor = true;
            this.ttIndigo.Click += new System.EventHandler(this.btn180Degrees_Click);
            // 
            // btnHorizontalFlip
            // 
            this.btnHorizontalFlip.Location = new System.Drawing.Point(0, 77);
            this.btnHorizontalFlip.Name = "btnHorizontalFlip";
            this.btnHorizontalFlip.Size = new System.Drawing.Size(99, 23);
            this.btnHorizontalFlip.TabIndex = 9;
            this.btnHorizontalFlip.Text = "Flip Horizontally";
            this.ttHorizontalFlip.SetToolTip(this.btnHorizontalFlip, "Click to flip the image horizontally. ");
            this.btnHorizontalFlip.UseVisualStyleBackColor = true;
            this.btnHorizontalFlip.Click += new System.EventHandler(this.btnHorizontalFlip_Click);
            // 
            // ttBrowse
            // 
            this.ttBrowse.IsBalloon = true;
            // 
            // ttDarken
            // 
            this.ttDarken.IsBalloon = true;
            // 
            // ttLighten
            // 
            this.ttLighten.IsBalloon = true;
            // 
            // ttNegative
            // 
            this.ttNegative.IsBalloon = true;
            // 
            // ttSunset
            // 
            this.ttSunset.IsBalloon = true;
            // 
            // ttGrayscale
            // 
            this.ttGrayscale.IsBalloon = true;
            // 
            // ttHorizontalFlip
            // 
            this.ttHorizontalFlip.IsBalloon = true;
            // 
            // ttVerticalFlip
            // 
            this.ttVerticalFlip.IsBalloon = true;
            // 
            // tt180Degrees
            // 
            this.tt180Degrees.IsBalloon = true;
            // 
            // ttRed
            // 
            this.ttRed.IsBalloon = true;
            // 
            // ttOrange
            // 
            this.ttOrange.IsBalloon = true;
            // 
            // ttGreen
            // 
            this.ttGreen.IsBalloon = true;
            // 
            // ttYellow
            // 
            this.ttYellow.IsBalloon = true;
            // 
            // ttBlue
            // 
            this.ttBlue.IsBalloon = true;
            // 
            // ttViolet
            // 
            this.ttViolet.IsBalloon = true;
            // 
            // Indigo
            // 
            this.Indigo.IsBalloon = true;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(6, 45);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 24;
            this.btnSwitch.Text = "Switch";
            this.ttSwitch.SetToolTip(this.btnSwitch, "Click to switch the top-left corner  with the bottom-right corner of the image.");
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // ttSwitch
            // 
            this.ttSwitch.IsBalloon = true;
            // 
            // btnPolarize
            // 
            this.btnPolarize.BackColor = System.Drawing.Color.Black;
            this.btnPolarize.ForeColor = System.Drawing.Color.White;
            this.btnPolarize.Location = new System.Drawing.Point(0, 135);
            this.btnPolarize.Name = "btnPolarize";
            this.btnPolarize.Size = new System.Drawing.Size(204, 23);
            this.btnPolarize.TabIndex = 12;
            this.btnPolarize.Text = "Polarize";
            this.ttPolarize.SetToolTip(this.btnPolarize, "Click to polarize the image. ");
            this.btnPolarize.UseVisualStyleBackColor = false;
            this.btnPolarize.Click += new System.EventHandler(this.btnPolarize_Click);
            // 
            // btnBlur
            // 
            this.btnBlur.Location = new System.Drawing.Point(6, 19);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(75, 23);
            this.btnBlur.TabIndex = 22;
            this.btnBlur.Text = "Blur";
            this.ttBlur.SetToolTip(this.btnBlur, "Click to blur the image.");
            this.btnBlur.UseVisualStyleBackColor = true;
            this.btnBlur.Click += new System.EventHandler(this.btnBlur_Click);
            // 
            // GBEasy
            // 
            this.GBEasy.Controls.Add(this.btnNegative);
            this.GBEasy.Controls.Add(this.btnSunset);
            this.GBEasy.Controls.Add(this.btnPolarize);
            this.GBEasy.Controls.Add(this.btnGrayscale);
            this.GBEasy.Controls.Add(this.btnHorizontalFlip);
            this.GBEasy.Controls.Add(this.ttIndigo);
            this.GBEasy.Controls.Add(this.btnVerticalFlip);
            this.GBEasy.Location = new System.Drawing.Point(12, 168);
            this.GBEasy.Name = "GBEasy";
            this.GBEasy.Size = new System.Drawing.Size(204, 166);
            this.GBEasy.TabIndex = 5;
            this.GBEasy.TabStop = false;
            this.GBEasy.Text = "Easy";
            // 
            // GBMedium
            // 
            this.GBMedium.Controls.Add(this.GBPixellate);
            this.GBMedium.Controls.Add(this.btnSort);
            this.GBMedium.Controls.Add(this.btnBlur);
            this.GBMedium.Controls.Add(this.btnSwitch);
            this.GBMedium.Location = new System.Drawing.Point(689, 54);
            this.GBMedium.Name = "GBMedium";
            this.GBMedium.Size = new System.Drawing.Size(169, 140);
            this.GBMedium.TabIndex = 21;
            this.GBMedium.TabStop = false;
            this.GBMedium.Text = "Medium";
            // 
            // GBPixellate
            // 
            this.GBPixellate.Controls.Add(this.CBPixellate);
            this.GBPixellate.Controls.Add(this.btnPixellate);
            this.GBPixellate.Location = new System.Drawing.Point(0, 74);
            this.GBPixellate.Name = "GBPixellate";
            this.GBPixellate.Size = new System.Drawing.Size(169, 56);
            this.GBPixellate.TabIndex = 25;
            this.GBPixellate.TabStop = false;
            this.GBPixellate.Text = "Pixellate";
            // 
            // CBPixellate
            // 
            this.CBPixellate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPixellate.FormattingEnabled = true;
            this.CBPixellate.Items.AddRange(new object[] {
            "4 x 4 ",
            "8 x 8"});
            this.CBPixellate.Location = new System.Drawing.Point(87, 21);
            this.CBPixellate.Name = "CBPixellate";
            this.CBPixellate.Size = new System.Drawing.Size(75, 21);
            this.CBPixellate.TabIndex = 27;
            // 
            // btnPixellate
            // 
            this.btnPixellate.Location = new System.Drawing.Point(6, 19);
            this.btnPixellate.Name = "btnPixellate";
            this.btnPixellate.Size = new System.Drawing.Size(75, 23);
            this.btnPixellate.TabIndex = 26;
            this.btnPixellate.Text = "Pixellate";
            this.ttPixellate.SetToolTip(this.btnPixellate, "Click to pixellate the image.");
            this.btnPixellate.UseVisualStyleBackColor = true;
            this.btnPixellate.Click += new System.EventHandler(this.btnPixellate_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(87, 19);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 23;
            this.btnSort.Text = "Sort";
            this.ttSort.SetToolTip(this.btnSort, "Click to sort the image.");
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // VSBScoll
            // 
            this.VSBScoll.Location = new System.Drawing.Point(660, 54);
            this.VSBScoll.Name = "VSBScoll";
            this.VSBScoll.Size = new System.Drawing.Size(22, 272);
            this.VSBScoll.TabIndex = 1;
            this.VSBScoll.TabStop = true;
            this.VSBScoll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VSBScoll_Scroll);
            // 
            // GBHard
            // 
            this.GBHard.Controls.Add(this.GBZoom);
            this.GBHard.Controls.Add(this.btnRecursion);
            this.GBHard.Location = new System.Drawing.Point(685, 231);
            this.GBHard.Name = "GBHard";
            this.GBHard.Size = new System.Drawing.Size(169, 103);
            this.GBHard.TabIndex = 28;
            this.GBHard.TabStop = false;
            this.GBHard.Text = "Hard";
            // 
            // GBZoom
            // 
            this.GBZoom.Controls.Add(this.CBMagnification);
            this.GBZoom.Controls.Add(this.btnZoom);
            this.GBZoom.Location = new System.Drawing.Point(0, 48);
            this.GBZoom.Name = "GBZoom";
            this.GBZoom.Size = new System.Drawing.Size(169, 47);
            this.GBZoom.TabIndex = 30;
            this.GBZoom.TabStop = false;
            this.GBZoom.Text = "Zoom";
            // 
            // CBMagnification
            // 
            this.CBMagnification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMagnification.FormattingEnabled = true;
            this.CBMagnification.Items.AddRange(new object[] {
            "x 1",
            "x 1.5",
            "x 2",
            "x 2.5",
            "x 3",
            "x 3.5",
            "x 4",
            "x 4.5",
            "x 5"});
            this.CBMagnification.Location = new System.Drawing.Point(87, 19);
            this.CBMagnification.Name = "CBMagnification";
            this.CBMagnification.Size = new System.Drawing.Size(75, 21);
            this.CBMagnification.TabIndex = 32;
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(6, 19);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(75, 23);
            this.btnZoom.TabIndex = 31;
            this.btnZoom.Text = "Zoom";
            this.ttZoom.SetToolTip(this.btnZoom, "Click to zoom in on the picture pending on the magnification.");
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnRecursion
            // 
            this.btnRecursion.Location = new System.Drawing.Point(6, 19);
            this.btnRecursion.Name = "btnRecursion";
            this.btnRecursion.Size = new System.Drawing.Size(75, 23);
            this.btnRecursion.TabIndex = 29;
            this.btnRecursion.Text = "Recursion";
            this.ttRecursion.SetToolTip(this.btnRecursion, "Click to divide the image into four tiles and to reoccur the image.");
            this.btnRecursion.UseVisualStyleBackColor = true;
            this.btnRecursion.Click += new System.EventHandler(this.btnRecursion_Click);
            // 
            // ttPolarize
            // 
            this.ttPolarize.IsBalloon = true;
            // 
            // ttBlur
            // 
            this.ttBlur.IsBalloon = true;
            // 
            // ttSort
            // 
            this.ttSort.IsBalloon = true;
            // 
            // ttPixellate
            // 
            this.ttPixellate.IsBalloon = true;
            // 
            // ttRecursion
            // 
            this.ttRecursion.IsBalloon = true;
            // 
            // ttZoom
            // 
            this.ttZoom.IsBalloon = true;
            // 
            // RTBSteganography
            // 
            this.RTBSteganography.Location = new System.Drawing.Point(6, 19);
            this.RTBSteganography.Name = "RTBSteganography";
            this.RTBSteganography.Size = new System.Drawing.Size(209, 137);
            this.RTBSteganography.TabIndex = 34;
            this.RTBSteganography.Text = "";
            // 
            // GBSteganography
            // 
            this.GBSteganography.Controls.Add(this.btnWrite);
            this.GBSteganography.Controls.Add(this.btnRead);
            this.GBSteganography.Controls.Add(this.RTBSteganography);
            this.GBSteganography.Location = new System.Drawing.Point(874, 54);
            this.GBSteganography.Name = "GBSteganography";
            this.GBSteganography.Size = new System.Drawing.Size(221, 280);
            this.GBSteganography.TabIndex = 33;
            this.GBSteganography.TabStop = false;
            this.GBSteganography.Text = "Steganography";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(841, 341);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(254, 13);
            this.lblCredit.TabIndex = 37;
            this.lblCredit.Text = "Music: Turkish March by Wolfgang Amadeus Mozart";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(6, 162);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(209, 23);
            this.btnWrite.TabIndex = 35;
            this.btnWrite.Text = "Write";
            this.ttWrite.SetToolTip(this.btnWrite, "Click to encrypt and input the message into the image.");
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(6, 191);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(209, 23);
            this.btnRead.TabIndex = 36;
            this.btnRead.Text = "Read";
            this.ttRead.SetToolTip(this.btnRead, "Click to extract the message from the image. ");
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // ttRead
            // 
            this.ttRead.IsBalloon = true;
            // 
            // ttWrite
            // 
            this.ttWrite.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 360);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.GBSteganography);
            this.Controls.Add(this.GBHard);
            this.Controls.Add(this.VSBScoll);
            this.Controls.Add(this.GBMedium);
            this.Controls.Add(this.GBEasy);
            this.Controls.Add(this.GBFilters);
            this.Controls.Add(this.GBBrightness);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.GBBrightness.ResumeLayout(false);
            this.GBBrightness.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GBFilters.ResumeLayout(false);
            this.GBEasy.ResumeLayout(false);
            this.GBMedium.ResumeLayout(false);
            this.GBPixellate.ResumeLayout(false);
            this.GBHard.ResumeLayout(false);
            this.GBZoom.ResumeLayout(false);
            this.GBSteganography.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.GroupBox GBBrightness;
        private System.Windows.Forms.Button btnLighten;
        private System.Windows.Forms.Button btnDarken;
        private System.Windows.Forms.Label lblDashes;
        private System.Windows.Forms.Button btnSunset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox GBFilters;
        private System.Windows.Forms.Button btnViolet;
        private System.Windows.Forms.Button btnIndigo;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnVerticalFlip;
        private System.Windows.Forms.Button ttIndigo;
        private System.Windows.Forms.Button btnHorizontalFlip;
        private System.Windows.Forms.ToolTip ttBrowse;
        private System.Windows.Forms.ToolTip ttDarken;
        private System.Windows.Forms.ToolTip ttLighten;
        private System.Windows.Forms.ToolTip ttNegative;
        private System.Windows.Forms.ToolTip ttSunset;
        private System.Windows.Forms.ToolTip ttGrayscale;
        private System.Windows.Forms.ToolTip ttHorizontalFlip;
        private System.Windows.Forms.ToolTip ttVerticalFlip;
        private System.Windows.Forms.ToolTip tt180Degrees;
        private System.Windows.Forms.ToolTip ttRed;
        private System.Windows.Forms.ToolTip ttOrange;
        private System.Windows.Forms.ToolTip ttGreen;
        private System.Windows.Forms.ToolTip ttYellow;
        private System.Windows.Forms.ToolTip ttBlue;
        private System.Windows.Forms.ToolTip ttViolet;
        private System.Windows.Forms.ToolTip Indigo;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.ToolTip ttSwitch;
        private System.Windows.Forms.ToolStripMenuItem RestoreToolStripMenuItem;
        private System.Windows.Forms.Button btnPolarize;
        private System.Windows.Forms.Button btnBlur;
        private System.Windows.Forms.GroupBox GBEasy;
        private System.Windows.Forms.GroupBox GBMedium;
        private System.Windows.Forms.Button btnPixellate;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.VScrollBar VSBScoll;
        private System.Windows.Forms.GroupBox GBHard;
        private System.Windows.Forms.ToolTip ttPolarize;
        private System.Windows.Forms.ToolTip ttBlur;
        private System.Windows.Forms.ToolTip ttPixellate;
        private System.Windows.Forms.ToolTip ttSort;
        private System.Windows.Forms.Button btnRecursion;
        private System.Windows.Forms.ToolTip ttRecursion;
        private System.Windows.Forms.ComboBox CBMagnification;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.ToolTip ttZoom;
        private System.Windows.Forms.ComboBox CBPixellate;
        private System.Windows.Forms.GroupBox GBPixellate;
        private System.Windows.Forms.GroupBox GBZoom;
        private System.Windows.Forms.RichTextBox RTBSteganography;
        private System.Windows.Forms.GroupBox GBSteganography;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ToolTip ttRead;
        private System.Windows.Forms.ToolTip ttWrite;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label lblCredit;
    }
}

