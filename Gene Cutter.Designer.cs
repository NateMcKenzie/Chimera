namespace Chimera
{
    partial class geneCutter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(geneCutter));
            this.pushCounterclockwiseButton = new System.Windows.Forms.Button();
            this.pushClockwiseButton = new System.Windows.Forms.Button();
            this.enzymeCombo = new System.Windows.Forms.ComboBox();
            this.cutSiteLabel = new System.Windows.Forms.Label();
            this.cutGenesPanel = new System.Windows.Forms.Panel();
            this.bamGroupBox = new System.Windows.Forms.GroupBox();
            this.bamHumulinCheck = new System.Windows.Forms.CheckBox();
            this.bamHumiraCheck = new System.Windows.Forms.CheckBox();
            this.bamKANcheck = new System.Windows.Forms.CheckBox();
            this.bamAMPcheck = new System.Windows.Forms.CheckBox();
            this.ecoGroupBox = new System.Windows.Forms.GroupBox();
            this.ecoHumulinCheck = new System.Windows.Forms.CheckBox();
            this.ecoHumiraCheck = new System.Windows.Forms.CheckBox();
            this.ecoKANcheck = new System.Windows.Forms.CheckBox();
            this.ecoAMPcheck = new System.Windows.Forms.CheckBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.newDNAcombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mergeButton = new System.Windows.Forms.Button();
            this.cutBeginningButton = new System.Windows.Forms.Button();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.helpLabel = new System.Windows.Forms.Label();
            this.context = new System.Windows.Forms.Label();
            this.stepFourGif = new System.Windows.Forms.PictureBox();
            this.showStepFour = new System.Windows.Forms.Label();
            this.stepFour = new System.Windows.Forms.Label();
            this.stepThreeGif = new System.Windows.Forms.PictureBox();
            this.showStepThree = new System.Windows.Forms.Label();
            this.stepThree = new System.Windows.Forms.Label();
            this.stepTwoGif = new System.Windows.Forms.PictureBox();
            this.showStepTwo = new System.Windows.Forms.Label();
            this.stepTwo = new System.Windows.Forms.Label();
            this.stepOneGif = new System.Windows.Forms.PictureBox();
            this.showStepOne = new System.Windows.Forms.Label();
            this.stepOne = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.cutGenesPanel.SuspendLayout();
            this.bamGroupBox.SuspendLayout();
            this.ecoGroupBox.SuspendLayout();
            this.displayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepFourGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepThreeGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepTwoGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepOneGif)).BeginInit();
            this.SuspendLayout();
            // 
            // pushCounterclockwiseButton
            // 
            this.pushCounterclockwiseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pushCounterclockwiseButton.Location = new System.Drawing.Point(637, 43);
            this.pushCounterclockwiseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pushCounterclockwiseButton.Name = "pushCounterclockwiseButton";
            this.pushCounterclockwiseButton.Size = new System.Drawing.Size(47, 54);
            this.pushCounterclockwiseButton.TabIndex = 4;
            this.pushCounterclockwiseButton.TabStop = false;
            this.pushCounterclockwiseButton.Text = "⇨";
            this.pushCounterclockwiseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pushCounterclockwiseButton.UseVisualStyleBackColor = true;
            this.pushCounterclockwiseButton.Click += new System.EventHandler(this.pushCounterclockwiseButton_Click);
            // 
            // pushClockwiseButton
            // 
            this.pushClockwiseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pushClockwiseButton.Location = new System.Drawing.Point(151, 43);
            this.pushClockwiseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pushClockwiseButton.Name = "pushClockwiseButton";
            this.pushClockwiseButton.Size = new System.Drawing.Size(47, 58);
            this.pushClockwiseButton.TabIndex = 5;
            this.pushClockwiseButton.TabStop = false;
            this.pushClockwiseButton.Text = "⇦";
            this.pushClockwiseButton.UseVisualStyleBackColor = true;
            this.pushClockwiseButton.Click += new System.EventHandler(this.pushClockwiseButton_Click);
            // 
            // enzymeCombo
            // 
            this.enzymeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enzymeCombo.FormattingEnabled = true;
            this.enzymeCombo.Items.AddRange(new object[] {
            "EcoRI",
            "BamHI"});
            this.enzymeCombo.Location = new System.Drawing.Point(1060, 15);
            this.enzymeCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enzymeCombo.MaxDropDownItems = 2;
            this.enzymeCombo.Name = "enzymeCombo";
            this.enzymeCombo.Size = new System.Drawing.Size(160, 24);
            this.enzymeCombo.TabIndex = 6;
            this.enzymeCombo.TabStop = false;
            this.enzymeCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cutSiteLabel
            // 
            this.cutSiteLabel.AutoSize = true;
            this.cutSiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutSiteLabel.Location = new System.Drawing.Point(224, 49);
            this.cutSiteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cutSiteLabel.Name = "cutSiteLabel";
            this.cutSiteLabel.Size = new System.Drawing.Size(222, 46);
            this.cutSiteLabel.TabIndex = 9;
            this.cutSiteLabel.Text = "No enzyme";
            // 
            // cutGenesPanel
            // 
            this.cutGenesPanel.Controls.Add(this.bamGroupBox);
            this.cutGenesPanel.Controls.Add(this.ecoGroupBox);
            this.cutGenesPanel.Location = new System.Drawing.Point(717, -1);
            this.cutGenesPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cutGenesPanel.Name = "cutGenesPanel";
            this.cutGenesPanel.Size = new System.Drawing.Size(315, 101);
            this.cutGenesPanel.TabIndex = 10;
            // 
            // bamGroupBox
            // 
            this.bamGroupBox.Controls.Add(this.bamHumulinCheck);
            this.bamGroupBox.Controls.Add(this.bamHumiraCheck);
            this.bamGroupBox.Controls.Add(this.bamKANcheck);
            this.bamGroupBox.Controls.Add(this.bamAMPcheck);
            this.bamGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.bamGroupBox.Location = new System.Drawing.Point(0, 50);
            this.bamGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bamGroupBox.Name = "bamGroupBox";
            this.bamGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bamGroupBox.Size = new System.Drawing.Size(315, 50);
            this.bamGroupBox.TabIndex = 1;
            this.bamGroupBox.TabStop = false;
            this.bamGroupBox.Text = "BamHI";
            // 
            // bamHumulinCheck
            // 
            this.bamHumulinCheck.AutoCheck = false;
            this.bamHumulinCheck.AutoSize = true;
            this.bamHumulinCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.bamHumulinCheck.Location = new System.Drawing.Point(212, 19);
            this.bamHumulinCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bamHumulinCheck.Name = "bamHumulinCheck";
            this.bamHumulinCheck.Size = new System.Drawing.Size(81, 27);
            this.bamHumulinCheck.TabIndex = 3;
            this.bamHumulinCheck.TabStop = false;
            this.bamHumulinCheck.Text = "Humulin";
            this.bamHumulinCheck.UseVisualStyleBackColor = true;
            this.bamHumulinCheck.CheckedChanged += new System.EventHandler(this.bamHumulinCheck_CheckedChanged);
            // 
            // bamHumiraCheck
            // 
            this.bamHumiraCheck.AutoCheck = false;
            this.bamHumiraCheck.AutoSize = true;
            this.bamHumiraCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.bamHumiraCheck.Location = new System.Drawing.Point(137, 19);
            this.bamHumiraCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bamHumiraCheck.Name = "bamHumiraCheck";
            this.bamHumiraCheck.Size = new System.Drawing.Size(75, 27);
            this.bamHumiraCheck.TabIndex = 2;
            this.bamHumiraCheck.TabStop = false;
            this.bamHumiraCheck.Text = "Humira";
            this.bamHumiraCheck.UseVisualStyleBackColor = true;
            this.bamHumiraCheck.CheckedChanged += new System.EventHandler(this.bamHumiraCheck_CheckedChanged);
            // 
            // bamKANcheck
            // 
            this.bamKANcheck.AutoCheck = false;
            this.bamKANcheck.AutoSize = true;
            this.bamKANcheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.bamKANcheck.Location = new System.Drawing.Point(71, 19);
            this.bamKANcheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bamKANcheck.Name = "bamKANcheck";
            this.bamKANcheck.Size = new System.Drawing.Size(66, 27);
            this.bamKANcheck.TabIndex = 1;
            this.bamKANcheck.TabStop = false;
            this.bamKANcheck.Text = "pKAN";
            this.bamKANcheck.UseVisualStyleBackColor = true;
            this.bamKANcheck.CheckedChanged += new System.EventHandler(this.bamKANcheck_CheckedChanged);
            // 
            // bamAMPcheck
            // 
            this.bamAMPcheck.AutoCheck = false;
            this.bamAMPcheck.AutoSize = true;
            this.bamAMPcheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.bamAMPcheck.Location = new System.Drawing.Point(4, 19);
            this.bamAMPcheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bamAMPcheck.Name = "bamAMPcheck";
            this.bamAMPcheck.Size = new System.Drawing.Size(67, 27);
            this.bamAMPcheck.TabIndex = 0;
            this.bamAMPcheck.TabStop = false;
            this.bamAMPcheck.Text = "pAMP";
            this.bamAMPcheck.UseVisualStyleBackColor = true;
            this.bamAMPcheck.CheckedChanged += new System.EventHandler(this.bamAMPcheck_CheckedChanged);
            // 
            // ecoGroupBox
            // 
            this.ecoGroupBox.Controls.Add(this.ecoHumulinCheck);
            this.ecoGroupBox.Controls.Add(this.ecoHumiraCheck);
            this.ecoGroupBox.Controls.Add(this.ecoKANcheck);
            this.ecoGroupBox.Controls.Add(this.ecoAMPcheck);
            this.ecoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ecoGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ecoGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ecoGroupBox.Name = "ecoGroupBox";
            this.ecoGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ecoGroupBox.Size = new System.Drawing.Size(315, 50);
            this.ecoGroupBox.TabIndex = 0;
            this.ecoGroupBox.TabStop = false;
            this.ecoGroupBox.Text = "EcoRI";
            // 
            // ecoHumulinCheck
            // 
            this.ecoHumulinCheck.AutoCheck = false;
            this.ecoHumulinCheck.AutoSize = true;
            this.ecoHumulinCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.ecoHumulinCheck.Location = new System.Drawing.Point(212, 19);
            this.ecoHumulinCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ecoHumulinCheck.Name = "ecoHumulinCheck";
            this.ecoHumulinCheck.Size = new System.Drawing.Size(81, 27);
            this.ecoHumulinCheck.TabIndex = 3;
            this.ecoHumulinCheck.TabStop = false;
            this.ecoHumulinCheck.Text = "Humulin";
            this.ecoHumulinCheck.UseVisualStyleBackColor = true;
            this.ecoHumulinCheck.CheckedChanged += new System.EventHandler(this.ecoHumulinCheck_CheckedChanged);
            // 
            // ecoHumiraCheck
            // 
            this.ecoHumiraCheck.AutoCheck = false;
            this.ecoHumiraCheck.AutoSize = true;
            this.ecoHumiraCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.ecoHumiraCheck.Location = new System.Drawing.Point(137, 19);
            this.ecoHumiraCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ecoHumiraCheck.Name = "ecoHumiraCheck";
            this.ecoHumiraCheck.Size = new System.Drawing.Size(75, 27);
            this.ecoHumiraCheck.TabIndex = 2;
            this.ecoHumiraCheck.TabStop = false;
            this.ecoHumiraCheck.Text = "Humira";
            this.ecoHumiraCheck.UseVisualStyleBackColor = true;
            this.ecoHumiraCheck.CheckedChanged += new System.EventHandler(this.ecoHumiraCheck_CheckedChanged);
            // 
            // ecoKANcheck
            // 
            this.ecoKANcheck.AutoCheck = false;
            this.ecoKANcheck.AutoSize = true;
            this.ecoKANcheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.ecoKANcheck.Location = new System.Drawing.Point(71, 19);
            this.ecoKANcheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ecoKANcheck.Name = "ecoKANcheck";
            this.ecoKANcheck.Size = new System.Drawing.Size(66, 27);
            this.ecoKANcheck.TabIndex = 1;
            this.ecoKANcheck.TabStop = false;
            this.ecoKANcheck.Text = "pKAN";
            this.ecoKANcheck.UseVisualStyleBackColor = true;
            this.ecoKANcheck.CheckedChanged += new System.EventHandler(this.ecoKANcheck_CheckedChanged);
            // 
            // ecoAMPcheck
            // 
            this.ecoAMPcheck.AutoCheck = false;
            this.ecoAMPcheck.AutoSize = true;
            this.ecoAMPcheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.ecoAMPcheck.Location = new System.Drawing.Point(4, 19);
            this.ecoAMPcheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ecoAMPcheck.Name = "ecoAMPcheck";
            this.ecoAMPcheck.Size = new System.Drawing.Size(67, 27);
            this.ecoAMPcheck.TabIndex = 0;
            this.ecoAMPcheck.TabStop = false;
            this.ecoAMPcheck.Text = "pAMP";
            this.ecoAMPcheck.UseVisualStyleBackColor = true;
            this.ecoAMPcheck.CheckedChanged += new System.EventHandler(this.ecoAMPcheck_CheckedChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1248, 65);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(111, 26);
            this.resetButton.TabIndex = 11;
            this.resetButton.TabStop = false;
            this.resetButton.Text = "&Next Plasmid";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // newDNAcombo
            // 
            this.newDNAcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newDNAcombo.FormattingEnabled = true;
            this.newDNAcombo.Items.AddRange(new object[] {
            "pAMP",
            "pKAN",
            "Humira",
            "Humulin"});
            this.newDNAcombo.Location = new System.Drawing.Point(1060, 65);
            this.newDNAcombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newDNAcombo.Name = "newDNAcombo";
            this.newDNAcombo.Size = new System.Drawing.Size(160, 24);
            this.newDNAcombo.TabIndex = 12;
            this.newDNAcombo.TabStop = false;
            this.newDNAcombo.SelectedIndexChanged += new System.EventHandler(this.newDNAcombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cut Site:";
            // 
            // mergeButton
            // 
            this.mergeButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mergeButton.Enabled = false;
            this.mergeButton.Location = new System.Drawing.Point(16, 26);
            this.mergeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(127, 44);
            this.mergeButton.TabIndex = 14;
            this.mergeButton.TabStop = false;
            this.mergeButton.Text = "Merge Plasmids ⇨";
            this.mergeButton.UseVisualStyleBackColor = false;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // cutBeginningButton
            // 
            this.cutBeginningButton.BackgroundImage = global::Chimera.Properties.Resources.scissors;
            this.cutBeginningButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cutBeginningButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutBeginningButton.Location = new System.Drawing.Point(441, 8);
            this.cutBeginningButton.Margin = new System.Windows.Forms.Padding(4);
            this.cutBeginningButton.Name = "cutBeginningButton";
            this.cutBeginningButton.Size = new System.Drawing.Size(64, 39);
            this.cutBeginningButton.TabIndex = 8;
            this.cutBeginningButton.TabStop = false;
            this.cutBeginningButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cutBeginningButton.UseVisualStyleBackColor = true;
            this.cutBeginningButton.Click += new System.EventHandler(this.cutBeginningButton_Click);
            // 
            // displayPanel
            // 
            this.displayPanel.BackgroundImage = global::Chimera.Properties.Resources.Frame5;
            this.displayPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.displayPanel.Controls.Add(this.helpLabel);
            this.displayPanel.Controls.Add(this.context);
            this.displayPanel.Controls.Add(this.stepFourGif);
            this.displayPanel.Controls.Add(this.showStepFour);
            this.displayPanel.Controls.Add(this.stepFour);
            this.displayPanel.Controls.Add(this.stepThreeGif);
            this.displayPanel.Controls.Add(this.showStepThree);
            this.displayPanel.Controls.Add(this.stepThree);
            this.displayPanel.Controls.Add(this.stepTwoGif);
            this.displayPanel.Controls.Add(this.showStepTwo);
            this.displayPanel.Controls.Add(this.stepTwo);
            this.displayPanel.Controls.Add(this.stepOneGif);
            this.displayPanel.Controls.Add(this.showStepOne);
            this.displayPanel.Controls.Add(this.stepOne);
            this.displayPanel.Controls.Add(this.instructionLabel);
            this.displayPanel.Location = new System.Drawing.Point(16, 98);
            this.displayPanel.Margin = new System.Windows.Forms.Padding(4);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(1347, 1066);
            this.displayPanel.TabIndex = 2;
            this.displayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.displayPanel_Paint);
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel.ForeColor = System.Drawing.Color.Blue;
            this.helpLabel.Location = new System.Drawing.Point(597, 144);
            this.helpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(148, 29);
            this.helpLabel.TabIndex = 18;
            this.helpLabel.Text = "Need help?";
            this.helpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.helpLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // context
            // 
            this.context.AutoSize = true;
            this.context.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.context.Location = new System.Drawing.Point(160, 82);
            this.context.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(951, 50);
            this.context.TabIndex = 19;
            this.context.Text = resources.GetString("context.Text");
            this.context.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stepFourGif
            // 
            this.stepFourGif.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stepFourGif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stepFourGif.Image = ((System.Drawing.Image)(resources.GetObject("stepFourGif.Image")));
            this.stepFourGif.Location = new System.Drawing.Point(156, 522);
            this.stepFourGif.Margin = new System.Windows.Forms.Padding(4);
            this.stepFourGif.Name = "stepFourGif";
            this.stepFourGif.Size = new System.Drawing.Size(1035, 223);
            this.stepFourGif.TabIndex = 31;
            this.stepFourGif.TabStop = false;
            this.stepFourGif.Visible = false;
            // 
            // showStepFour
            // 
            this.showStepFour.AutoSize = true;
            this.showStepFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStepFour.ForeColor = System.Drawing.Color.Blue;
            this.showStepFour.Location = new System.Drawing.Point(153, 495);
            this.showStepFour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showStepFour.Name = "showStepFour";
            this.showStepFour.Size = new System.Drawing.Size(54, 20);
            this.showStepFour.TabIndex = 30;
            this.showStepFour.Text = "Show";
            this.showStepFour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showStepFour.Visible = false;
            this.showStepFour.Click += new System.EventHandler(this.showStepFour_Click);
            // 
            // stepFour
            // 
            this.stepFour.AutoSize = true;
            this.stepFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepFour.Location = new System.Drawing.Point(129, 442);
            this.stepFour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stepFour.Name = "stepFour";
            this.stepFour.Size = new System.Drawing.Size(647, 50);
            this.stepFour.TabIndex = 29;
            this.stepFour.Text = "4. Once you have cut out your second  nucleotide, click \"Merge Plasmids\"\r\n    on " +
    "the upper-left corner to create your transformed bacterium.";
            this.stepFour.Visible = false;
            // 
            // stepThreeGif
            // 
            this.stepThreeGif.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stepThreeGif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stepThreeGif.Image = ((System.Drawing.Image)(resources.GetObject("stepThreeGif.Image")));
            this.stepThreeGif.Location = new System.Drawing.Point(351, 522);
            this.stepThreeGif.Margin = new System.Windows.Forms.Padding(4);
            this.stepThreeGif.Name = "stepThreeGif";
            this.stepThreeGif.Size = new System.Drawing.Size(665, 208);
            this.stepThreeGif.TabIndex = 28;
            this.stepThreeGif.TabStop = false;
            this.stepThreeGif.Visible = false;
            // 
            // showStepThree
            // 
            this.showStepThree.AutoSize = true;
            this.showStepThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStepThree.ForeColor = System.Drawing.Color.Blue;
            this.showStepThree.Location = new System.Drawing.Point(153, 411);
            this.showStepThree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showStepThree.Name = "showStepThree";
            this.showStepThree.Size = new System.Drawing.Size(54, 20);
            this.showStepThree.TabIndex = 27;
            this.showStepThree.Text = "Show";
            this.showStepThree.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showStepThree.Visible = false;
            this.showStepThree.Click += new System.EventHandler(this.showStepThree_Click);
            // 
            // stepThree
            // 
            this.stepThree.AutoSize = true;
            this.stepThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepThree.Location = new System.Drawing.Point(129, 351);
            this.stepThree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stepThree.Name = "stepThree";
            this.stepThree.Size = new System.Drawing.Size(684, 50);
            this.stepThree.TabIndex = 26;
            this.stepThree.Text = "3. When you have successfully cut your nucleotides, selects new enzyme and\r\n    p" +
    "lasmid (shown in Step. 1) and click \"Next Plasmid\"\r\n";
            this.stepThree.Visible = false;
            // 
            // stepTwoGif
            // 
            this.stepTwoGif.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stepTwoGif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stepTwoGif.Image = ((System.Drawing.Image)(resources.GetObject("stepTwoGif.Image")));
            this.stepTwoGif.Location = new System.Drawing.Point(404, 522);
            this.stepTwoGif.Margin = new System.Windows.Forms.Padding(4);
            this.stepTwoGif.Name = "stepTwoGif";
            this.stepTwoGif.Size = new System.Drawing.Size(568, 213);
            this.stepTwoGif.TabIndex = 25;
            this.stepTwoGif.TabStop = false;
            this.stepTwoGif.Visible = false;
            // 
            // showStepTwo
            // 
            this.showStepTwo.AutoSize = true;
            this.showStepTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStepTwo.ForeColor = System.Drawing.Color.Blue;
            this.showStepTwo.Location = new System.Drawing.Point(153, 314);
            this.showStepTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showStepTwo.Name = "showStepTwo";
            this.showStepTwo.Size = new System.Drawing.Size(54, 20);
            this.showStepTwo.TabIndex = 24;
            this.showStepTwo.Text = "Show";
            this.showStepTwo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showStepTwo.Visible = false;
            this.showStepTwo.Click += new System.EventHandler(this.showStepTwo_Click);
            // 
            // stepTwo
            // 
            this.stepTwo.AutoSize = true;
            this.stepTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepTwo.Location = new System.Drawing.Point(129, 261);
            this.stepTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stepTwo.Name = "stepTwo";
            this.stepTwo.Size = new System.Drawing.Size(815, 50);
            this.stepTwo.TabIndex = 23;
            this.stepTwo.Text = "2. A set of nucleotides will appear at the Cut Site. Find the given pattern in th" +
    "e plasmid below. \r\n    Then use the cut function\r\n";
            this.stepTwo.Visible = false;
            // 
            // stepOneGif
            // 
            this.stepOneGif.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stepOneGif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stepOneGif.Image = ((System.Drawing.Image)(resources.GetObject("stepOneGif.Image")));
            this.stepOneGif.Location = new System.Drawing.Point(404, 539);
            this.stepOneGif.Margin = new System.Windows.Forms.Padding(4);
            this.stepOneGif.Name = "stepOneGif";
            this.stepOneGif.Size = new System.Drawing.Size(545, 168);
            this.stepOneGif.TabIndex = 22;
            this.stepOneGif.TabStop = false;
            this.stepOneGif.Visible = false;
            // 
            // showStepOne
            // 
            this.showStepOne.AutoSize = true;
            this.showStepOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStepOne.ForeColor = System.Drawing.Color.Blue;
            this.showStepOne.Location = new System.Drawing.Point(153, 225);
            this.showStepOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showStepOne.Name = "showStepOne";
            this.showStepOne.Size = new System.Drawing.Size(54, 20);
            this.showStepOne.TabIndex = 21;
            this.showStepOne.Text = "Show";
            this.showStepOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showStepOne.Visible = false;
            this.showStepOne.Click += new System.EventHandler(this.showStepOne_Click);
            // 
            // stepOne
            // 
            this.stepOne.AutoSize = true;
            this.stepOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepOne.Location = new System.Drawing.Point(129, 197);
            this.stepOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stepOne.Name = "stepOne";
            this.stepOne.Size = new System.Drawing.Size(446, 25);
            this.stepOne.TabIndex = 20;
            this.stepOne.Text = "1. Select your enzyme and plasmid in the top right.";
            this.stepOne.Visible = false;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(601, 144);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(146, 29);
            this.instructionLabel.TabIndex = 17;
            this.instructionLabel.Text = "Instructions";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.instructionLabel.Visible = false;
            // 
            // geneCutter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 1045);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newDNAcombo);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.cutGenesPanel);
            this.Controls.Add(this.enzymeCombo);
            this.Controls.Add(this.cutSiteLabel);
            this.Controls.Add(this.cutBeginningButton);
            this.Controls.Add(this.pushClockwiseButton);
            this.Controls.Add(this.pushCounterclockwiseButton);
            this.Controls.Add(this.displayPanel);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1399, 1092);
            this.MinimumSize = new System.Drawing.Size(1399, 1028);
            this.Name = "geneCutter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gene Cutter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.geneCutter_FormClosed);
            this.Shown += new System.EventHandler(this.geneCutter_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.geneCutter_KeyDown);
            this.cutGenesPanel.ResumeLayout(false);
            this.bamGroupBox.ResumeLayout(false);
            this.bamGroupBox.PerformLayout();
            this.ecoGroupBox.ResumeLayout(false);
            this.ecoGroupBox.PerformLayout();
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepFourGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepThreeGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepTwoGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepOneGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Button pushCounterclockwiseButton;
        private System.Windows.Forms.Button pushClockwiseButton;
        private System.Windows.Forms.ComboBox enzymeCombo;
        private System.Windows.Forms.Button cutBeginningButton;
        private System.Windows.Forms.Label cutSiteLabel;
        private System.Windows.Forms.Panel cutGenesPanel;
        private System.Windows.Forms.GroupBox bamGroupBox;
        private System.Windows.Forms.CheckBox bamHumulinCheck;
        private System.Windows.Forms.CheckBox bamHumiraCheck;
        private System.Windows.Forms.CheckBox bamKANcheck;
        private System.Windows.Forms.CheckBox bamAMPcheck;
        private System.Windows.Forms.GroupBox ecoGroupBox;
        private System.Windows.Forms.CheckBox ecoHumulinCheck;
        private System.Windows.Forms.CheckBox ecoHumiraCheck;
        private System.Windows.Forms.CheckBox ecoKANcheck;
        private System.Windows.Forms.CheckBox ecoAMPcheck;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox newDNAcombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Label stepOne;
        private System.Windows.Forms.Label context;
        private System.Windows.Forms.Label showStepOne;
        private System.Windows.Forms.PictureBox stepOneGif;
        private System.Windows.Forms.Label stepTwo;
        private System.Windows.Forms.Label showStepTwo;
        private System.Windows.Forms.PictureBox stepTwoGif;
        private System.Windows.Forms.Label showStepThree;
        private System.Windows.Forms.Label stepThree;
        private System.Windows.Forms.PictureBox stepThreeGif;
        private System.Windows.Forms.Label showStepFour;
        private System.Windows.Forms.Label stepFour;
        private System.Windows.Forms.PictureBox stepFourGif;
    }
}