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
        SqlConnection con = new SqlConnection("Server=localhost;Database=DocHouse_desktop;Trusted_Connection=True;");
        string query = "";
        public doctor()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            login.id = null;
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
            query = "select * from appointment where doctor_id=@did";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@did", login.id);
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

        private void label1_Click(object sender, EventArgs e)
        {
            Chatting ch = new Chatting();
            ch.Show();
            this.Hide();
        }
    }
}
