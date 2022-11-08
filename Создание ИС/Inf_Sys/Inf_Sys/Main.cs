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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            cls(client);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Requests requests = new Requests();
            cls(requests);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            cls(addClient);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddRequest addRequest = new AddRequest();
            cls(addRequest);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            cls(employee);
        }

        private void cls(Form frm)
        {
            frm.Show(this);
            Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        int clos_from_btn = 0 ;
        
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (clos_from_btn == 0)
            {
                Form ifrm = Application.OpenForms[0];
                ifrm.Show();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            clos_from_btn = 1;
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Parametrs parametrs = new Parametrs();
            parametrs.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Deal deal = new Deal();
            deal.Show();
            this.Hide();
        }
    }
}
