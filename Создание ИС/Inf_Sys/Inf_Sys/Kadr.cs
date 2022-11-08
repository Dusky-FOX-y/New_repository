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
    public partial class Kadr : Form
    {
        public Kadr()
        {
            InitializeComponent();
        }

        private void Kadr_Load(object sender, EventArgs e)
        {

        }
        int cls_frm_btn = 0;
        private void Kadr_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cls_frm_btn == 0)
            {
                Form ifrm = Application.OpenForms[0];
                ifrm.Show();
            }
            else
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls_frm_btn = 1;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Post post = new Post(); 
            post.Show();
            this.Hide();
        }
    }
}