﻿using System;
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
    public partial class Book_Medicine : Form
    {
        public Book_Medicine()
        {
            InitializeComponent();
        }


        string PharmacyName = "";

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
            SqlCommand cmd = new SqlCommand("select pharmacy_name from pharmacist", con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "pharmacy_name";
            //comboBox3.Text = "Select Doctor";
            con.Close();
            PharmacyName = comboBox2.Text;

        }

  

        private void button7_Click_1(object sender, EventArgs e)
        {
            PharmacyName = comboBox2.Text;
            SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-K745D94;Initial Catalog=DocHouse;Integrated Security=True");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select p_id from pharmacist where pharmacy_name=@PharmacyName", con1);
            cmd1.Parameters.AddWithValue("@PharmacyName", PharmacyName);
            DataTable dt1 = new DataTable();
            SqlDataAdapter adapt1 = new SqlDataAdapter(cmd1);
            adapt1.Fill(dt1);
            comboBox4.DataSource = dt1;
            comboBox4.DisplayMember = "p_id";
            con1.Close();
           
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K745D94;Initial Catalog=DocHouse;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into medicine_reservation values(@f,@l,@e,@p,@g,@c,@pn,@rm,@pi)", con);
            cmd.Parameters.AddWithValue("@f", textBox1.Text);
            cmd.Parameters.AddWithValue("@l", textBox2.Text);
            cmd.Parameters.AddWithValue("@e", textBox3.Text);
            cmd.Parameters.AddWithValue("@p", textBox4.Text);
            cmd.Parameters.AddWithValue("@g", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@c", textBox5.Text);

            //MessageBox.Show("1");
            cmd.Parameters.AddWithValue("@pn", comboBox2.Text);
            // MessageBox.Show("2");
            cmd.Parameters.AddWithValue("@rm", richTextBox1.Text);

            cmd.Parameters.AddWithValue("@pi", comboBox4.Text);
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
