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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            производствоTableAdapter.Insert(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text), int.Parse(textBox2.Text), (dateTimePicker1.Value));
            производствоTableAdapter.Fill(this.clockDataSet1.Производство);
            this.производствоTableAdapter.Update(this.clockDataSet1.Производство);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            Hide();
            f4.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clockDataSet1.Производитель". При необходимости она может быть перемещена или удалена.
            this.производительTableAdapter.Fill(this.clockDataSet1.Производитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clockDataSet1.Производство". При необходимости она может быть перемещена или удалена.
            this.производствоTableAdapter.Fill(this.clockDataSet1.Производство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clockDataSet1.Часы". При необходимости она может быть перемещена или удалена.
            this.часыTableAdapter.Fill(this.clockDataSet1.Часы);
        

        }
    }
}
