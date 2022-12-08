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
    public partial class doctor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K745D94;Initial Catalog=DocHouse;Integrated Security=True");
        string query = "";
        public doctor()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            home1 frm = new home1();
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            query = "select * from appointment ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataAppointment.DataSource = dt;
            con.Close();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

    }
}
