using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_register_MouseHover(object sender, EventArgs e)
        {
            this.button_register.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.buttom_H));
        }

        private void button_register_MouseLeave(object sender, EventArgs e)
        {
            this.button_register.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.buttom));
        }

        private void signin_MouseHover(object sender, EventArgs e)
        {
            this.signin.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.signin_h));
        }

        private void signin_MouseLeave(object sender, EventArgs e)
        {
            this.signin.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.signin));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // RETURN 0
        }
    }
}
