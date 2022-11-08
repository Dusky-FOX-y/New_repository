using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inf_Sys
{
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
        }

        private void Requests_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Клиент' table. You can move, or remove it, as needed.
            this.клиентTableAdapter.Fill(this.dBDataSet.Клиент);
            // TODO: This line of code loads data into the 'dBDataSet.Тип_предложения' table. You can move, or remove it, as needed.
            this.тип_предложенияTableAdapter.Fill(this.dBDataSet.Тип_предложения);
            // TODO: This line of code loads data into the 'dBDataSet.Тип_объекта' table. You can move, or remove it, as needed.
            this.тип_объектаTableAdapter.Fill(this.dBDataSet.Тип_объекта);
            // TODO: This line of code loads data into the 'dBDataSet.Статус' table. You can move, or remove it, as needed.
            this.статусTableAdapter.Fill(this.dBDataSet.Статус);
            // TODO: This line of code loads data into the 'dBDataSet.Ремонт' table. You can move, or remove it, as needed.
            this.ремонтTableAdapter.Fill(this.dBDataSet.Ремонт);
            // TODO: This line of code loads data into the 'dBDataSet._Объект_Запрос' table. You can move, or remove it, as needed.
            this.объект_ЗапросTableAdapter.Fill(this.dBDataSet._Объект_Запрос);

        }

        private void Requests_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form ifrm = Application.OpenForms[1];
            ifrm.Show();
        }


        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(richTextBox1.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                            }
                }
            }
            else
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox2.Text != "")
            {
                for (int i = 0; i < dataGridView6.RowCount; i++)
                {
                    dataGridView6.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView6.ColumnCount; j++)
                        if (dataGridView6.Rows[i].Cells[j].Value != null)
                            if (dataGridView6.Rows[i].Cells[j].Value.ToString().Contains(richTextBox2.Text))
                            {
                                dataGridView6.Rows[i].Selected = true;
                            }
                }
            }
            else
                for (int i = 0; i < dataGridView6.RowCount; i++)
                {
                    dataGridView6.Rows[i].Selected = false;
                }
                }

        private void button3_Click(object sender, EventArgs e)
        {
            объектЗапросBindingSource.EndEdit();
            объект_ЗапросTableAdapter.Update(dBDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            клиентBindingSource.EndEdit();
            клиентTableAdapter.Update(dBDataSet);
        }
    }
}
