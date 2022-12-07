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
    public partial class forget : Form
    {
        public forget()
        {
            InitializeComponent();
        }

        string choice;
        string item;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K745D94;Initial Catalog=DocHouse;Integrated Security=True");

        private void forget_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "Choose your role";
            comboBox2.Items.Add("Patient");
            comboBox2.Items.Add("Doctor");
            comboBox2.Items.Add("Lab scientist");
            comboBox2.Items.Add("Pharmacist");
            comboBox1.Text = "Choose youe security question";



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            home1 frm = new home1();
            frm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("What is your pet name?");
            comboBox1.Items.Add("What is your uncle name?");
            comboBox1.Items.Add("What is your best friend name?");
            comboBox1.Items.Add("What is your favourite game name?");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            choice = comboBox2.SelectedItem.ToString();
            string choice2 = comboBox1.SelectedItem.ToString();
            string email = emailBox.Text;
            con.Open();
            if (choice == "Patient")
            {

                SqlCommand cmd = new SqlCommand("select answer from register where Email = '" + email + "'   AND security_question= '" + choice2 + "'", con);
                cmd.Parameters.AddWithValue("@Email", email);

                cmd.Parameters.AddWithValue("@choice2", choice2);



                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("update register set Password ='" + passBox1.Text + "' where Email = '" + email + "'", con);
                    cmd1.Parameters.AddWithValue("@Email", email);
                    cmd1.ExecuteNonQuery();
                    login frm = new login();
                    frm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Wrong data");
                }
            }
            else if (choice == "Doctor")
            {
                SqlCommand cmd = new SqlCommand("select answer from doctors where doc_email = '" + email + "'   AND security_question= '" + choice2 + "'", con);
                cmd.Parameters.AddWithValue("@Email", email);

                cmd.Parameters.AddWithValue("@choice2", choice2);



                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("update doctors set pass ='" + passBox1.Text + "' where doc_email = '" + email + "'", con);
                    cmd1.Parameters.AddWithValue("@Email", email);
                    cmd1.ExecuteNonQuery();
                    login frm = new login();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong data");
                }
            }
            else if (choice == "Lab scientist")
            {
                SqlCommand cmd = new SqlCommand("select answer from lab_scientist where s_email = '" + email + "'   AND security_question= '" + choice2 + "'", con);
                cmd.Parameters.AddWithValue("@Email", email);

                cmd.Parameters.AddWithValue("@choice2", choice2);



                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("update lab_scientist set s_pass ='" + passBox1.Text + "' where s_email = '" + email + "'", con);
                    cmd1.Parameters.AddWithValue("@Email", email);
                    cmd1.ExecuteNonQuery();
                    login frm = new login();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong data");
                }
            }
            else if (choice == "Pharmacist")
            {
                SqlCommand cmd = new SqlCommand("select answer from pharmacist where p_email = '" + email + "'   AND security_question = '" + choice2 + "'", con);
                cmd.Parameters.AddWithValue("@Email", email);

                cmd.Parameters.AddWithValue("@choice2", choice2);



                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("update pharmacist set p_pass ='" + passBox1.Text + "' where p_email = '" + email + "'", con);
                    cmd1.Parameters.AddWithValue("@Email", email);
                    cmd1.ExecuteNonQuery();
                    login frm = new login();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong data");
                }
            }
            con.Close();
        }
    }
}
