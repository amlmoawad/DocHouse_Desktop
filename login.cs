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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace home1
{
    public partial class login : Form
    {
        public static string id = "";
        public static string login_email = "";
        public login()
        {
            InitializeComponent();
        }
        string choice;
        SqlConnection con = new SqlConnection("Server=localhost;Database=DocHouse_desktop;Trusted_Connection=True;");
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
                    login_email = emailBox.Text;
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
                    login_email = emailBox.Text;
                    Admin frm2 = new Admin();
                    frm2.Show();
                    this.Hide();
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
                string query = "SELECT * from doctors WHERE doc_email = '" + emailBox.Text + "' AND pass = '" + passBox.Text + "'";
                SqlDataAdapter sdm = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sdm.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    SqlConnection con = new SqlConnection("Server=localhost;Database=DocHouse_desktop;Trusted_Connection=True;");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select doc_id from doctors where doc_email = '" + emailBox.Text + "' AND pass = '" + passBox.Text + "'", con);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    comboBox2.DataSource = dt;
                    comboBox2.DisplayMember = "doc_id";
                    con.Close();
                    id = comboBox2.Text;
                    MessageBox.Show("Welcome");
                    doctor frm = new doctor();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong data");
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
                    SqlConnection con = new SqlConnection("Server=localhost;Database=DocHouse_desktop;Trusted_Connection=True;");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select s_id from lab_scientist where s_email = '" + emailBox.Text + "' AND s_pass = '" + passBox.Text + "'", con);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    comboBox2.DataSource = dt;
                    comboBox2.DisplayMember = "s_id";
                    con.Close();
                    id = comboBox2.Text;
                    MessageBox.Show("Welcome");
                    Lab frm = new Lab();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong data");
                    login frm = new login();
                    frm.Show();
                    this.Hide();
                }
            }
            else if (choice == "Pharmacist")
            {
                con.Open();
                string query = "SELECT * from pharmacist WHERE p_email = '" + emailBox.Text + "' AND p_pass = '" + passBox.Text + "'";
                SqlDataAdapter sdm = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sdm.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    SqlConnection con = new SqlConnection("Server=localhost;Database=DocHouse_desktop;Trusted_Connection=True;");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select p_id from pharmacist where p_email = '" + emailBox.Text + "' AND p_pass = '" + passBox.Text + "'", con);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    comboBox2.DataSource = dt;
                    comboBox2.DisplayMember = "p_id";
                    con.Close();
                    id = comboBox2.Text;
                    MessageBox.Show("Welcome");
                    pharmacist frm = new pharmacist();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong data");
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
