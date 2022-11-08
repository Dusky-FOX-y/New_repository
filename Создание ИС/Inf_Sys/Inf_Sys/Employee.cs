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
    public partial class Employee : Form
    {
        public int opn_frm = 0;
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            int frm = 1;
            if (opn_frm != 0)
                frm = 2;
            Form ifrm = Application.OpenForms[frm];
            ifrm.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Должность' table. You can move, or remove it, as needed.
            this.должностьTableAdapter.Fill(this.dBDataSet.Должность);
            // TODO: This line of code loads data into the 'dBDataSet.Сотрудник' table. You can move, or remove it, as needed.
            this.сотрудникTableAdapter.Fill(this.dBDataSet.Сотрудник);

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

            сотрудникBindingSource.EndEdit();
            сотрудникTableAdapter.Update(dBDataSet);
        }
    }
}
