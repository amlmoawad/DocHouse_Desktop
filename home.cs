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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            home frm2 = new home();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Chatting frm2 = new Chatting();
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
            login.login_email = null;
            DoctorReport.appointment_email = null;
            home1 frm2 = new home1();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            book frm2 = new book();
            frm2.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Book_Medicine frm2 = new Book_Medicine();
            frm2.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Examination_Reservation frm2 = new Examination_Reservation();
            frm2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Patient frm2 = new Patient();
            frm2.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
