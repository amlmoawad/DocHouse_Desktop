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
    public partial class Admin : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K745D94;Initial Catalog=DocHouse;Integrated Security=True");
        string query = "";
        public Admin()
        {
            InitializeComponent();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            query = "select * joinus";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            joinus.DataSource = dt;
            con.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            query = "select * appointment";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataAppointment.DataSource = dt;
            con.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            home1 frm = new home1();
            frm.Show();
            this.Hide();
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            query = "select * doctors";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            doctors.DataSource = dt;
            con.Close();
        }
    }
}
