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
    public partial class Patient : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K745D94;Initial Catalog=DocHouse;Integrated Security=True");
        string query = "";


        public Patient()
        {
            InitializeComponent();
        }

        private void Doc_profile_Click(object sender, EventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            home1 frm = new home1();
            frm.Show();
            this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            query = "select * appointment";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Appointments.DataSource = dt;
            con.Close();

        }

        private void Appointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

            con.Open();
            query = "select * report";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Reports.DataSource = dt;
            con.Close();


        }
    }
}
