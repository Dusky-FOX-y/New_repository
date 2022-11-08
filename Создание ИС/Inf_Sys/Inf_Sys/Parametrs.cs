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
    public partial class Parametrs : Form
    {
        public Parametrs()
        {
            InitializeComponent();
        }

        private void Parametrs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Ремонт' table. You can move, or remove it, as needed.
            this.ремонтTableAdapter.Fill(this.dBDataSet.Ремонт);
            // TODO: This line of code loads data into the 'dBDataSet.Тип_объекта' table. You can move, or remove it, as needed.
            this.тип_объектаTableAdapter.Fill(this.dBDataSet.Тип_объекта);
            // TODO: This line of code loads data into the 'dBDataSet.Тип_предложения' table. You can move, or remove it, as needed.
            this.тип_предложенияTableAdapter.Fill(this.dBDataSet.Тип_предложения);
            // TODO: This line of code loads data into the 'dBDataSet.Статус' table. You can move, or remove it, as needed.
            this.статусTableAdapter.Fill(this.dBDataSet.Статус);

        }

        private void Parametrs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[1];
            ifrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            статусBindingSource.EndEdit();
            статусTableAdapter.Update(dBDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            типПредложенияBindingSource.EndEdit();
            тип_предложенияTableAdapter.Update(dBDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            типОбъектаBindingSource.EndEdit();
            тип_объектаTableAdapter.Update(dBDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ремонтBindingSource.EndEdit();
            ремонтTableAdapter.Update(dBDataSet);
        }
    }
}
