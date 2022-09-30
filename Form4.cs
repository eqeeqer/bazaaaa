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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clockDataSet1.Производство". При необходимости она может быть перемещена или удалена.
            this.производствоTableAdapter.Fill(this.clockDataSet1.Производство);
     

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            Hide();
            f5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
              if (matr2.CurrentRow != null)
                if (MessageBox.Show("Вы подтверждаете удаление?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    ((DataRowView)matr2.CurrentRow.DataBoundItem).Delete();
                else
                    MessageBox.Show("Операция удаления прервана", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Невозможно удаление пустой строки!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
              this.производствоTableAdapter.Update(this.clockDataSet1.Производство);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.производствоTableAdapter.Update(this.clockDataSet1.Производство);
            Hide();
            f1.Show();
        }
    }
}
