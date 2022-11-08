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
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass, log, spec;
            log = textBox1.Text;
            pass = textBox2.Text;
            if (pass == "12345" && log == "admin")
            {
                spec = comboBox1.Text;
                switch (spec)
                {
                    case "Риелтор":
                        Main main = new Main();
                        cls(main);
                        break;
                    case "Бухгалтер":
                        Buh buh = new Buh();
                        cls(buh);
                        break;
                    case "Кадровик":
                        Kadr kadr = new Kadr();
                        cls(kadr);
                        break;
                    default:
                        MessageBox.Show("Выберите специализацию", "Ошибка выбора специализации", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;
                }
            }
            else
                MessageBox.Show("Пароль или логин неверны", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void cls(Form frm)
        {
            frm.Show(this);
            Hide();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Startup_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Выйти из программы ?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Close();
        }

        Point lastpoint;

        private void Startup_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void Startup_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Startup_Load(object sender, EventArgs e)
        {

        }
    }
}
