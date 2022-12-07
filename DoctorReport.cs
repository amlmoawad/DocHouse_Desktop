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
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-K745D94;Initial Catalog=DocHouse;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert report(Appointment_ID,Medical_Case,Required_Medicine,Rerquired_Examination) values(@Appointment_ID,@Medical_Case,@Required_Medicine,@Rerquired_Examination)", con);
                cmd.Parameters.AddWithValue("@Appointment_ID", textBoxId.Text);
                cmd.Parameters.AddWithValue("@Medical_Case", textBoxmidcase.Text);
                cmd.Parameters.AddWithValue("@Required_Medicine", textBoxreqmidcine.Text);
                cmd.Parameters.AddWithValue("@Rerquired_Examination", textBoxreqexamination.Text);
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
