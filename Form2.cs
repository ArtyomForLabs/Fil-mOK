using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fil_mOK
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void войтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog(this);
        }

        public void редакторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //pictureBox1.ImageLocation = "C:\\Users\\home\\Pictures\\1 мая\\DSC_4112.JPG";
        }

        public void label1_Click(object sender, EventArgs e)
        {
            room f4 = new room(sender,e);
            f4.ShowDialog();
        }

        public void label2_Click(object sender, EventArgs e)
        {
            room f4 = new room(sender, e);
            f4.ShowDialog();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.LightGray;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = label2.BackColor;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.BackColor = Color.LightGray;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = label1.BackColor;
        }
    }
}
