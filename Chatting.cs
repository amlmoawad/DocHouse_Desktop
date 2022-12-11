using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home1
{
    public partial class Chatting : Form
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
        private TcpClient client;
        public StreamReader str;
        public StreamWriter stw;
        public string recieve;
        private void Chatting_Load(object sender, EventArgs e)
        {
            startButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, startButton.Width, startButton.Height, 20, 20));
            connectbutton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, connectbutton.Width, connectbutton.Height, 20, 20));
            sendbutton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, sendbutton.Width, sendbutton.Height, 30, 30));
        }
        public string textToSend;
        public Chatting()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                    serverIptextBox.Text = address.ToString();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(serverPorttextBox.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            str = new StreamReader(client.GetStream());
            stw = new StreamWriter(client.GetStream());
            stw.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void connectbutton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse(clientIptextBox.Text), int.Parse(clientPorttextBox.Text));
            client.Connect(iPEnd);
            try
            {
                chattextBox.AppendText("conect to server" + "\n");
                stw = new StreamWriter(client.GetStream());
                str = new StreamReader(client.GetStream());
                stw.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = str.ReadLine();
                    this.chattextBox.Invoke(new MethodInvoker(delegate ()

                    {
                        chattextBox.AppendText("You : " + recieve + "\r\n");
                    }));
                    recieve = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                stw.WriteLine(textToSend);
                this.chattextBox.Invoke(new MethodInvoker(delegate ()
                {
                    chattextBox.AppendText("Me : " + textToSend + "\r\n");
                }));
            }

        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            if (messagetextBox.Text != "")
            {
                textToSend = messagetextBox.Text;
                backgroundWorker2.RunWorkerAsync();

            }
            messagetextBox.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            home frm = new home();
            frm.Show();
            this.Hide();
        }
    }
}
