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
    public partial class Client : Form
    {
        public int created_from_form = 0;
        
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Статус' table. You can move, or remove it, as needed.
            this.статусTableAdapter.Fill(this.dBDataSet.Статус);
            // TODO: This line of code loads data into the 'dBDataSet.Клиент' table. You can move, or remove it, as needed.
            this.клиентTableAdapter.Fill(this.dBDataSet.Клиент);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            int qwe;
            if (created_from_form == 0)
                qwe = 1;
            else
                qwe = 2;
            Form ifrm = Application.OpenForms[qwe];
            ifrm.Show();
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
