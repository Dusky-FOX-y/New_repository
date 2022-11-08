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
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
        }

        private void Income_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Доходы' table. You can move, or remove it, as needed.
            this.доходыTableAdapter.Fill(this.dBDataSet.Доходы);

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

        private void button1_Click(object sender, EventArgs e)
        {
            доходыBindingSource.EndEdit();
            доходыTableAdapter.Update(dBDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            employee.opn_frm = 1;
            this.Hide();
        }

        private void Income_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[1];
            ifrm.Show();
        }
    }
}
