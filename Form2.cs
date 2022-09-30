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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clockDataSet1.Производитель". При необходимости она может быть перемещена или удалена.
            this.производительTableAdapter.Fill(this.clockDataSet1.Производитель);
           
      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Hide();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (matr1.CurrentRow != null)
                if (MessageBox.Show("Вы подтверждаете удаление?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    ((DataRowView)matr1.CurrentRow.DataBoundItem).Delete();
                else
                    MessageBox.Show("Операция удаления прервана", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Невозможно удаление пустой строки!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.производительTableAdapter.Update(this.clockDataSet1.Производитель);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.производительTableAdapter.Update(this.clockDataSet1.Производитель);
            Hide();
            f1.Show();
        }

        private void matr1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
