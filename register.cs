using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        string choice;
        private void register_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Choose your security question";
            comboBox1.Items.Add("What is your pet name?");
            comboBox1.Items.Add("What is your uncle name?");
            comboBox1.Items.Add("What is your best friend name?");
            comboBox1.Items.Add("What is your favourite game name?");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fname.Text.Trim()))
            {
                errorProvider1.SetError(fname, "First name is required");
                return;
            }
            else
            {
                errorProvider1.SetError(fname, "First name is required");
            }


            if (string.IsNullOrEmpty(lname.Text.Trim()))
            {
                errorProvider1.SetError(lname, "Last name is required");
                return;
            }
            else
            {
                errorProvider1.SetError(lname, "last name is required");
            }


            if (string.IsNullOrEmpty(email.Text.Trim()))
            {
                errorProvider1.SetError(email, "Email Address is required");
                return;
            }
            else
            {
                errorProvider1.SetError(email, "Email Address is required");
            }


            if (string.IsNullOrEmpty(pass.Text.Trim()))
            {
                errorProvider1.SetError(pass, "Password is required");
                return;
            }
            else
            {
                errorProvider1.SetError(pass, "Password is required");
            }


            if (string.IsNullOrEmpty(phone.Text.Trim()))
            {
                errorProvider1.SetError(phone, "Phone number is required");
                return;
            }
            else
            {
                errorProvider1.SetError(phone, "Phone number is required");
            }


            if (string.IsNullOrEmpty(answerBox.Text.Trim()))
            {
                errorProvider1.SetError(answerBox, "Answer is required");
                return;
            }
            else
            {
                errorProvider1.SetError(answerBox, "Answer is required");
            }
            string checkBox = "Male";
            if (maleButton.Checked)
            {
                checkBox = "Male";
            }
            else
            {
                checkBox = "Female";
            }
            choice = comboBox1.SelectedItem.ToString();
            SqlConnection con = new SqlConnection("Server=localhost;Database=DocHouse_desktop;Trusted_Connection=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into register values('" + fname.Text + "','" + lname.Text + "','" + email.Text + "','" + pass.Text + "','" + phone.Text + "','" + checkBox + "','" + (int)(age.Value) + "','" + choice + "','" + answerBox.Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Welcome");
                login frm = new login();
                frm.ShowDialog();
                this.Hide();
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            home1 frm = new home1();
            frm.Show();
            this.Hide();
        }
    }
}
