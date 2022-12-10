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

namespace home1
{
    public partial class contactUsscs : Form
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
        public contactUsscs()
        {
            InitializeComponent();
        }

        private void contactUsscs_Load(object sender, EventArgs e)
        {
            btnSubmit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSubmit.Width, btnSubmit.Height, 30, 30));
            //txtbName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtbName.Width, txtbName.Height, 5, 5));
            //textBEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBEmail.Width,textBoxPhone.Height, 5, 5));
            //textBoxPhone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtbName.Width, txtbName.Height, 5, 5));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtbName.Text != "" && textBEmail.Text != "" && textBoxPhone.Text != "" && textBoxMessage.Text != "")
            {
                SqlConnection con = new SqlConnection("Server=localhost;Database=DocHouse_desktop;Trusted_Connection=True;");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert info(pat_name,pat_email,pat_phone,pat_message) values(@pat_name,@pat_email,@pat_phone,@pat_message)", con);
                cmd.Parameters.AddWithValue("@pat_name", txtbName.Text);
                System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (expr.IsMatch(textBEmail.Text))
                {
                    cmd.Parameters.AddWithValue("@pat_email", textBEmail.Text);
                }
                else
                {
                    MessageBox.Show("Your email in valid");
                }

                cmd.Parameters.AddWithValue("@pat_phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@pat_message", textBoxMessage.Text);
                cmd.ExecuteNonQuery();
                txtbName.Text = textBEmail.Text = textBoxPhone.Text = textBoxMessage.Text = "";
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("please provide details");
            }
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-D29UFPE;Initial Catalog=pataintdata;Integrated Security=True");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            home frm = new home();
            frm.Show();
            this.Hide();
        }
    }
}
