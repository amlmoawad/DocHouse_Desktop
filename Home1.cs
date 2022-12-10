using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home1
{
    public partial class home1 : Form
    {
        public home1()
        {
            InitializeComponent();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            home1 frm2 = new home1();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            contactUsscs frm2 = new contactUsscs();
            frm2.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            About_Us frm2 = new About_Us();
            frm2.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            join frm2 = new join();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            register frm2 = new register();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            login frm2 = new login();
            frm2.Show();
            this.Hide();
        }
    }
}
