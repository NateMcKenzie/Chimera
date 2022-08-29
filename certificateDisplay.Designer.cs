namespace Chimera
{
    partial class certificateDisplay
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
            this.printCert = new System.Windows.Forms.Button();
            this.printCert1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.backButton = new System.Windows.Forms.Button();
            this.certPicture = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.icon = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.certPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // printCert
            // 
            this.printCert.Location = new System.Drawing.Point(288, 15);
            this.printCert.Margin = new System.Windows.Forms.Padding(4);
            this.printCert.Name = "printCert";
            this.printCert.Size = new System.Drawing.Size(100, 28);
            this.printCert.TabIndex = 1;
            this.printCert.Text = "&Print";
            this.printCert.UseVisualStyleBackColor = true;
            this.printCert.Click += new System.EventHandler(this.printCert_Click);
            // 
            // printCert1
            // 
            this.printCert1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCert1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printCert1;
            this.printDialog1.UseEXDialog = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(36, 15);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 28);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "&Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // certPicture
            // 
            this.certPicture.Location = new System.Drawing.Point(119, 85);
            this.certPicture.Margin = new System.Windows.Forms.Padding(4);
            this.certPicture.Name = "certPicture";
            this.certPicture.Size = new System.Drawing.Size(133, 62);
            this.certPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.certPicture.TabIndex = 0;
            this.certPicture.TabStop = false;
            this.certPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.certPicture_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // icon
            // 
            this.icon.Location = new System.Drawing.Point(0, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(100, 50);
            this.icon.TabIndex = 3;
            this.icon.TabStop = false;
            this.icon.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // certificateDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 853);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.printCert);
            this.Controls.Add(this.certPicture);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "certificateDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "certificateDisplay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.certificateDisplay_FormClosed);
            this.Load += new System.EventHandler(this.certificateDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.certPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox certPicture;
        private System.Windows.Forms.Button printCert;
        private System.Drawing.Printing.PrintDocument printCert1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Timer timer2;
    }
}