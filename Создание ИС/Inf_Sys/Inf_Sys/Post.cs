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
    public partial class Post : Form
    {
        public Post()
        {
            InitializeComponent();
        }

        private void Post_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Должность' table. You can move, or remove it, as needed.
            this.должностьTableAdapter.Fill(this.dBDataSet.Должность);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            должностьBindingSource.EndEdit();
            должностьTableAdapter.Update(dBDataSet);
        }

        private void Post_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[1];
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
