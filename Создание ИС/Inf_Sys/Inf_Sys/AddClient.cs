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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddClient_Load(object sender, EventArgs e)
        {

        }
        int adding = 0;
        private void AddClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (adding == 0)
            {
                Form ifrm = Application.OpenForms[1];
                ifrm.Show();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string surname, first_name, patronymic, phone_num, other_com;
            surname = textBox1.Text;
            first_name = textBox2.Text;
            patronymic = textBox3.Text;
            phone_num = maskedTextBox1.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace("+", "").Substring(1);
            other_com = textBox5.Text;
            if (first_name.Length == 0)
            {
                MessageBox.Show("Не введено имя!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (phone_num.Length != 10)
            {
                MessageBox.Show("Неправильно введён номер телеофона!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                клиентTableAdapter1.Insert(surname, first_name, patronymic, phone_num, other_com, 1);
                adding = 1;
                AddRequest addrequest = new AddRequest();
                addrequest.Show();
                Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
