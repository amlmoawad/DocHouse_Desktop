using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace home1
{
    public partial class DoctorReport : Form
    {
        public static string appointment_email="";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
           int nLeft,
           int nTop,
           int nRigth,
           int nBottom,
           int nWidthEllipse,
           int nHightEllipse
           );
        public DoctorReport()
        {
            InitializeComponent();
        }

        private void DoctorReport_Load(object sender, EventArgs e)
        {
            btnSubmit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSubmit.Width, btnSubmit.Height, 30, 30));
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "" && textBoxmidcase.Text != "" && textBoxreqmidcine.Text != "" && textBoxreqexamination.Text != "")
            {
                SqlConnection con = new SqlConnection("Server=localhost;Database=DocHouse_desktop;Trusted_Connection=True;");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select patient_email from appointment where appointment_id=@id", con);
                cmd1.Parameters.AddWithValue("@id", int.Parse(textBoxId.Text));
                SqlDataAdapter adapt = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "patient_email";
                appointment_email = comboBox1.Text;
                SqlCommand cmd = new SqlCommand("insert report(Appointment_ID,Medical_Case,Required_Medicine,Rerquired_Examination,email) values(@Appointment_ID,@Medical_Case,@Required_Medicine,@Rerquired_Examination,@email)", con);
                cmd.Parameters.AddWithValue("@Appointment_ID", textBoxId.Text);
                cmd.Parameters.AddWithValue("@Medical_Case", textBoxmidcase.Text);
                cmd.Parameters.AddWithValue("@Required_Medicine", textBoxreqmidcine.Text);
                cmd.Parameters.AddWithValue("@Rerquired_Examination", textBoxreqexamination.Text);
                cmd.Parameters.AddWithValue("@email", appointment_email);
                cmd.ExecuteNonQuery();
                textBoxId.Text = textBoxmidcase.Text = textBoxreqmidcine.Text = textBoxreqexamination.Text = "";
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("please provide details");
            }
        }
    }
}
