using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.kamako.by");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start("https://vk.com/kamako_borisov");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ok.ru/group/51999232557185");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/KAMAKO.BY");
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Hide();
            f1.Show();
        }
    }
}
