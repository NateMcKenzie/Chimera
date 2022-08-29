using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chimera
{
    public partial class easterForm : Form
    {
        public easterForm()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Width < 550)
            {
                pictureBox1.Width += Width / 20;
                pictureBox1.Height += Width / 20;
                pictureBox1.Left = Width / 2 - pictureBox1.Width/2;
                pictureBox1.Top = Height / 2 - pictureBox1.Height / 2;
            }
            else
            {
                System.Threading.Thread.Sleep(3000);
                timer2.Start();
                timer1.Stop();
                pic2.BackgroundImage = Chimera.Properties.Resources.tsa2;
                pic2.BackgroundImageLayout = ImageLayout.Stretch;
                pic2.BackColor = Color.Transparent;
                pic2.Width = 900;
                pic2.Height = (int)(((double)Chimera.Properties.Resources.tsa2.Height / (double)Chimera.Properties.Resources.tsa2.Width) * Width);
                pic2.Left = pictureBox1.Left - 400 - pic2.Width;
                pictureBox1.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(pic2.Left < Width/2 - pic2.Width/2)
                pic2.Left += 30;
        }
    }
}
