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
    public partial class AddRequest : Form
    {
        public AddRequest()
        {
            InitializeComponent();
        }

        private void AddRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Статус' table. You can move, or remove it, as needed.
            this.статусTableAdapter.Fill(this.dBDataSet.Статус);
            // TODO: This line of code loads data into the 'dBDataSet.Ремонт' table. You can move, or remove it, as needed.
            this.ремонтTableAdapter.Fill(this.dBDataSet.Ремонт);
            // TODO: This line of code loads data into the 'dBDataSet.Тип_объекта' table. You can move, or remove it, as needed.
            this.тип_объектаTableAdapter.Fill(this.dBDataSet.Тип_объекта);
            // TODO: This line of code loads data into the 'dBDataSet.Тип_предложения' table. You can move, or remove it, as needed.
            this.тип_предложенияTableAdapter.Fill(this.dBDataSet.Тип_предложения);
            // TODO: This line of code loads data into the 'dBDataSet.Клиент' table. You can move, or remove it, as needed.
            this.клиентTableAdapter.Fill(this.dBDataSet.Клиент);
            
            this.объект_ЗапросTableAdapter1.Fill(this.dBDataSet._Объект_Запрос);

            this.объект_Запрос_клиентаTableAdapter1.Fill(this.dBDataSet._Объект_Запрос_клиента);
            
            int id = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) > id)
                    id = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
            textBox1.Text = id.ToString();
            changeClient(id);
        }

        private void AddRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form ifrm = Application.OpenForms[1];
            ifrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool sep_bath, pres_balc;
            int offer_type, object_type, repair_type, rooms = 0, obj_floor = 0, bath_count = 0, costs = 0, client_id = 0, offer_id = 0;
            double obj_area = 0;
            float kitchen_area = 0, bath_area = 0, balcony_area = 0, cell_height = 0;
            string location = "", description = "";
            client_id = int.Parse(textBox1.Text);
            offer_type = comboBox1.SelectedIndex+1;
            object_type = comboBox2.SelectedIndex+1;
            repair_type = comboBox3.SelectedIndex+1;
            
            /*Ввод стоимости*/
            
            if (textBox2.Text != "")
            {
                try
                {
                    costs = int.Parse(textBox2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неправильно введена стоимость", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            /*Ввод локации*/
            
            location = textBox3.Text;

            /*Ввод площади объекта*/
            
            if (textBox4.Text != "")
            {
                try
                {
                    obj_area = Convert.ToDouble(textBox4.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неправильно введена площадь объекта", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            /*Ввод кол-ва комнат*/

            if (textBox5.Text != "")
            {
                try
                {
                    rooms = int.Parse(textBox5.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неправильно введено кол-во комнат!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            /*Ввод площади кухни*/

            if (textBox6.Text != "")
            {
                try
                {
                    kitchen_area = float.Parse(textBox6.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неправильно введена площадь кухни", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            /*Ввод площади санузла*/

            if (textBox6.Text != "")
            {
                try
                {
                    bath_area = float.Parse(textBox6.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неправильно введена площадь санузла", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            /*Ввод раздельность санузла*/

            sep_bath = checkBox1.Checked;

            /*Ввод кол-ва санузлов*/

            if (textBox8.Text != "")
            {
                try
                {
                    bath_count = int.Parse(textBox8.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неправильно введено кол-во санузлов!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            /*Ввод высоты потолков*/

            if (textBox9.Text != "")
            {
                try
                {
                    cell_height = float.Parse(textBox9.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неправильно введена высота потолков", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            /*Ввод этажа объекта*/

            if (textBox11.Text != "")
            {
                try
                {
                    obj_floor = int.Parse(textBox11.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неправильно введён этаж объекта!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            /*Ввод наличия балкона*/

            pres_balc = checkBox2.Checked;

            /*Ввод площади балкона*/

            if (textBox10.Text != "")
            {
                try
                {
                    balcony_area = float.Parse(textBox10.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неправильно введена площадь балкона", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }
            }

            /*Ввод описания объекта*/
            if (richTextBox1.Text != "")
                description = richTextBox1.Text;

            объект_ЗапросTableAdapter1.Insert(costs, location, obj_area, rooms, kitchen_area, bath_area, sep_bath, bath_count, cell_height, pres_balc, balcony_area, obj_floor, description, object_type, offer_type, repair_type, 2);


            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                if (int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()) > offer_id)
                    offer_id = int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString());
            }
            объект_Запрос_клиентаTableAdapter1.Insert(client_id, offer_id);
            MessageBox.Show("Запрос успешно добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void changeClient(int id)
        {
            if (id > dataGridView1.Rows.Count - 1)
            {
                MessageBox.Show("Такого клиента не существует", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string data = "", phone = "";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == id){
                    data = dataGridView1.Rows[i].Cells[1].Value.ToString() + ' ';
                    data += dataGridView1.Rows[i].Cells[2].Value.ToString() + ' ';
                    data += dataGridView1.Rows[i].Cells[3].Value.ToString();
                    phone = dataGridView1.Rows[i].Cells[4].Value.ToString();
                }
            }
            label4.Text = data;
            label5.Text = "+7 " + phone;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
                changeClient(int.Parse(textBox1.Text.ToString()));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.created_from_form = 1;
            client.Show();
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox10.Visible = true;
                label15.Visible = true;
            }
            else
            {
                textBox10.Visible = false;
                label15.Visible = false;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
                label16.Text = "Кол-во этажей объекта";
            else
                label16.Text = "Этаж объекта";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = Application.OpenForms[1];
            ifrm.Show();
            this.Close();
        }
    }
}
