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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        string choice;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TJV0TVJ\\SQLEXPRESS;Initial Catalog=DocHouse;Integrated Security=True");
        private void login_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Choose your role";
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Patient");
            comboBox1.Items.Add("Doctor");
            comboBox1.Items.Add("Lab scientist");
            comboBox1.Items.Add("Pharmacist");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            home1 frm = new home1();
            frm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice = comboBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email, pass;

            email = emailBox.Text;
            pass = passBox.Text;

            if (choice == "Patient")
            {
                con.Open();
                string query = "SELECT * from register WHERE Email = '" + emailBox.Text + "' AND Password = '" + passBox.Text + "'";
                SqlDataAdapter sdm = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sdm.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome");
                    home frm = new home();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrond data");
                    login frm = new login();
                    frm.Show();
                    this.Hide();
                }
            }
            else if (choice == "Admin")
            {
                if (email == "admin@gmail.com" && pass == "admin")
                {
                    //admin frm = new admin();
                    //frm.show();
                    //this.hide();
                }
                else
                {
                    MessageBox.Show("Wrong data");
                    login frm = new login();
                    frm.Show();
                    this.Hide();

                }
            }




            else if (choice == "Doctor")
            {
                string query = "SELECT * from doctors WHERE s_email = '" + emailBox.Text + "' AND s_pass = '" + passBox.Text + "'";
                SqlDataAdapter sdm = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sdm.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome");
                    //doctor frm = new home();
                    //frm.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrond data");
                    login frm = new login();
                    frm.Show();
                    this.Hide();
                }

            }
            else if (choice == "Lab scientist")
            {
                con.Open();
                string query = "SELECT * from lab_scientist WHERE s_email = '" + emailBox.Text + "' AND s_pass = '" + passBox.Text + "'";
                SqlDataAdapter sdm = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sdm.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome");
                    //labScientist frm = new labScientist();
                    //frm.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrond data");
                    login frm = new login();
                    frm.Show();
                    this.Hide();
                }
            }
            else if (choice == "Pharmacist")
            {
                con.Open();
                string query = "SELECT * from pharmacist WHERE s_email = '" + emailBox.Text + "' AND s_pass = '" + passBox.Text + "'";
                SqlDataAdapter sdm = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sdm.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome");
                    //pharmacist frm = new pharmacist();
                    //frm.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrond data");
                    login frm = new login();
                    frm.Show();
                    this.Hide();
                }
            }
            else if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please choose your role");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forget frm = new forget();
            frm.Show();
            this.Hide();
        }
    }
}
