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
    public partial class Form1 : Form
    {
        
        string s,s1;
        double a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clockDataSet1.Производитель". При необходимости она может быть перемещена или удалена.
            this.производительTableAdapter.Fill(this.clockDataSet1.Производитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clockDataSet1.Производство". При необходимости она может быть перемещена или удалена.
            this.производствоTableAdapter.Fill(this.clockDataSet1.Производство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clockDataSet1.Часы". При необходимости она может быть перемещена или удалена.
            this.часыTableAdapter.Fill(this.clockDataSet1.Часы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clockDataSet.Производитель". При необходимости она может быть перемещена или удалена.
           

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                часыbindingSource.EndEdit();
                часыTableAdapter.Update(this.clockDataSet1.Часы);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                часыbindingSource.ResetBindings(false);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (matr.CurrentRow != null)
                if (MessageBox.Show("Вы подтверждаете удаление?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    ((DataRowView)matr.CurrentRow.DataBoundItem).Delete();
                else
                    MessageBox.Show("Операция удаления прервана", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Невозможно удаление пустой строки!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.часыTableAdapter.Update(this.clockDataSet1.Часы);
        }

        private void справочникГруппToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Hide();
            f2.Show();
        }

        private void справочникПродукцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            Hide();
            f4.Show();
        }

        private void справочникЕдиницИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file:D:\\WindowsFormsApplication1\\bin\\Debug\\Help.chm");
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            Hide();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Show();
        }

   
        Bitmap bmp;
        private void button6_Click(object sender, EventArgs e)
        {
            int height = matr.Height;
            matr.Height = matr.RowCount * matr.RowTemplate.Height * 2;
            bmp = new Bitmap(matr.Width, matr.Height);
            matr.DrawToBitmap(bmp, new Rectangle(0, 0, matr.Width, matr.Height));
            matr.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
   

        private void button3_Click(object sender, EventArgs e)
        {
            if (matr.CurrentRow != null)
                if (MessageBox.Show("Вы подтверждаете удаление?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    ((DataRowView)matr.CurrentRow.DataBoundItem).Delete();
                else
                    MessageBox.Show("Операция удаления прервана", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Невозможно удаление пустой строки!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.часыTableAdapter.Update(this.clockDataSet1.Часы);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < matr.RowCount; i++)
                {
                    matr.Rows[i].Selected = false;
                    for (int j = 0; j < matr.ColumnCount; j++)
                        if (matr.Rows[i].Cells[j].Value != null)
                            if (matr.Rows[i].Cells[j].Value.ToString().Contains(textBox6.Text))
                            {
                                matr.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Focus();

                this.clockDataSet1.Часы.AddЧасыRow(this.clockDataSet1.Часы.NewЧасыRow());

                часыbindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                часыbindingSource.ResetBindings(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Focus();

                this.clockDataSet1.Часы.AddЧасыRow(this.clockDataSet1.Часы.NewЧасыRow());

                часыbindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                часыbindingSource.ResetBindings(false);
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                часыbindingSource.EndEdit();
                часыTableAdapter.Update(this.clockDataSet1.Часы);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                часыbindingSource.ResetBindings(false);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            matr.Sort(matr.Columns[2], ListSortDirection.Ascending);
        }

        private void matr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            matr.Sort(matr.Columns[2], ListSortDirection.Descending);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            matr.Sort(matr.Columns[1], ListSortDirection.Ascending);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            matr.Sort(matr.Columns[1], ListSortDirection.Descending);
        }

        
      
  

     

      
    }
}
