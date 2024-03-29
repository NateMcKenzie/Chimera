﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace Chimera
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            
        }

        private void geneCutterButton_Click_1(object sender, EventArgs e)
        {
            
            Globals.name = nameTextBox.Text;
            Globals.name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Globals.name.ToLower());
            Globals.period = periodComboBox.Text;
            Globals.cutScreen = new geneCutter();
            Globals.cutScreen.Show();
            
            this.Hide();
        }


        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void periodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            validate();
        }
        private void validate()
        {
            if (nameTextBox.Text.Contains(" ") && !(periodComboBox.Text == ""))
            {
                geneCutterButton.Enabled = true;
                geneCutterButton.BackColor = Color.FromArgb(30, 230, 30);
            }
            else if (!nameTextBox.Text.Contains(" ") || periodComboBox.Text == "")
            {
                geneCutterButton.Enabled = false;
                geneCutterButton.BackColor = Color.FromArgb(255,30,30);
            }
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}