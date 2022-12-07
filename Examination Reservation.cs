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
    public partial class Examination_Reservation : Form
    {
        public Examination_Reservation()
        {
            InitializeComponent();
        }


        string LabName = "";

        private void book_Load_1(object sender, EventArgs e)
        {
            comboBox1.Text = "Select Governorate";
            comboBox1.Items.Add("Dakahlia");
            comboBox1.Items.Add("Alexandria");
            comboBox1.Items.Add("Kafr ElSheikh");
            comboBox1.Items.Add("Gharbia");
            comboBox1.Items.Add("Cairo");

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K745D94;Initial Catalog=DocHouse;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select lab_name from lab_scientist", con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "lab_name";
            //comboBox3.Text = "Select Doctor";
            con.Close();
            LabName = comboBox2.Text;

        }



        private void button7_Click_1(object sender, EventArgs e)
        {
            LabName = comboBox2.Text;
            SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-K745D94;Initial Catalog=DocHouse;Integrated Security=True");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select s_id from lab_scientist where lab_name=@LabName", con1);
            cmd1.Parameters.AddWithValue("@LabName", LabName);
            DataTable dt1 = new DataTable();
            SqlDataAdapter adapt1 = new SqlDataAdapter(cmd1);
            adapt1.Fill(dt1);
            comboBox4.DataSource = dt1;
            comboBox4.DisplayMember = "s_id";
            con1.Close();

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K745D94;Initial Catalog=DocHouse;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into lab_reservation values(@f,@l,@e,@p,@g,@c,@pn,@re,@li)", con);
            cmd.Parameters.AddWithValue("@f", textBox1.Text);
            cmd.Parameters.AddWithValue("@l", textBox2.Text);
            cmd.Parameters.AddWithValue("@e", textBox3.Text);
            cmd.Parameters.AddWithValue("@p", textBox4.Text);
            cmd.Parameters.AddWithValue("@g", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@c", textBox5.Text);

            //MessageBox.Show("1");
            cmd.Parameters.AddWithValue("@pn", comboBox2.Text);
            // MessageBox.Show("2");
            cmd.Parameters.AddWithValue("@re", richTextBox1.Text);

            cmd.Parameters.AddWithValue("@li", comboBox4.Text);
            // MessageBox.Show("3");
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("YOUR APPOINTMENT HAS LANDED SAFELY");
        }


        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            home frm2 = new home();
            frm2.Show();
            this.Hide();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //contact frm2 = new contact();
            //frm2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //about frm2 = new about();
            //frm2.Show();
            this.Hide();
        }
    }
}
