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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            производительTableAdapter.Insert( (textBox2.Text), (textBox3.Text));
            производительTableAdapter.Update(clockDataSet1.Производитель);
            Form2 f2 = new Form2();
            Hide();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Hide();
            f2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clockDataSet1.Производитель". При необходимости она может быть перемещена или удалена.
            this.производительTableAdapter.Fill(this.clockDataSet1.Производитель);

        }
    }
}
