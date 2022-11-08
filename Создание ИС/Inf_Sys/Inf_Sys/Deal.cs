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
    public partial class Deal : Form
    {
        public Deal()
        {
            InitializeComponent();
        }

        private void Deal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Сотрудник' table. You can move, or remove it, as needed.
            this.сотрудникTableAdapter.Fill(this.dBDataSet.Сотрудник);
            // TODO: This line of code loads data into the 'dBDataSet._Объект_Запрос_клиента' table. You can move, or remove it, as needed.
            this.объект_Запрос_клиентаTableAdapter.Fill(this.dBDataSet._Объект_Запрос_клиента);
            // TODO: This line of code loads data into the 'dBDataSet.Клиент' table. You can move, or remove it, as needed.
            this.клиентTableAdapter.Fill(this.dBDataSet.Клиент);
            // TODO: This line of code loads data into the 'dBDataSet.Статус' table. You can move, or remove it, as needed.
            this.статусTableAdapter.Fill(this.dBDataSet.Статус);
            // TODO: This line of code loads data into the 'dBDataSet.Сделка' table. You can move, or remove it, as needed.
            this.сделкаTableAdapter.Fill(this.dBDataSet.Сделка);

        }

        private void Deal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[1];
            ifrm.Show();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            сделкаBindingSource.EndEdit();
            сделкаTableAdapter.Update(dBDataSet);
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
    }
}
