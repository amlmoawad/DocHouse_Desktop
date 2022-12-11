namespace home1
{
    partial class Chatting
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serverIptextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chattextBox = new System.Windows.Forms.TextBox();
            this.serverPorttextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clientIptextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clientPorttextBox = new System.Windows.Forms.TextBox();
            this.connectbutton = new System.Windows.Forms.Button();
            this.messagetextBox = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serverIptextBox
            // 
            this.serverIptextBox.Location = new System.Drawing.Point(133, 71);
            this.serverIptextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverIptextBox.Name = "serverIptextBox";
            this.serverIptextBox.Size = new System.Drawing.Size(145, 20);
            this.serverIptextBox.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold);
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(596, 65);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(98, 30);
            this.startButton.TabIndex = 87;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(92, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(310, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "PORT";
            // 
            // chattextBox
            // 
            this.chattextBox.Location = new System.Drawing.Point(57, 174);
            this.chattextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chattextBox.Multiline = true;
            this.chattextBox.Name = "chattextBox";
            this.chattextBox.Size = new System.Drawing.Size(637, 143);
            this.chattextBox.TabIndex = 15;
            // 
            // serverPorttextBox
            // 
            this.serverPorttextBox.Location = new System.Drawing.Point(387, 71);
            this.serverPorttextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverPorttextBox.Name = "serverPorttextBox";
            this.serverPorttextBox.Size = new System.Drawing.Size(145, 20);
            this.serverPorttextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(11, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(92, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "IP";
            // 
            // clientIptextBox
            // 
            this.clientIptextBox.Location = new System.Drawing.Point(133, 134);
            this.clientIptextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientIptextBox.Name = "clientIptextBox";
            this.clientIptextBox.Size = new System.Drawing.Size(145, 20);
            this.clientIptextBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(310, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "PORT";
            // 
            // clientPorttextBox
            // 
            this.clientPorttextBox.Location = new System.Drawing.Point(387, 134);
            this.clientPorttextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientPorttextBox.Name = "clientPorttextBox";
            this.clientPorttextBox.Size = new System.Drawing.Size(145, 20);
            this.clientPorttextBox.TabIndex = 21;
            // 
            // connectbutton
            // 
            this.connectbutton.BackColor = System.Drawing.Color.DarkOrchid;
            this.connectbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectbutton.FlatAppearance.BorderSize = 0;
            this.connectbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectbutton.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold);
            this.connectbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.connectbutton.Location = new System.Drawing.Point(596, 126);
            this.connectbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(98, 34);
            this.connectbutton.TabIndex = 22;
            this.connectbutton.Text = "CONNECT";
            this.connectbutton.UseVisualStyleBackColor = false;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click);
            // 
            // messagetextBox
            // 
            this.messagetextBox.Location = new System.Drawing.Point(57, 330);
            this.messagetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messagetextBox.Multiline = true;
            this.messagetextBox.Name = "messagetextBox";
            this.messagetextBox.Size = new System.Drawing.Size(637, 38);
            this.messagetextBox.TabIndex = 23;
            // 
            // sendbutton
            // 
            this.sendbutton.BackColor = System.Drawing.Color.DarkOrchid;
            this.sendbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sendbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendbutton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold);
            this.sendbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sendbutton.Location = new System.Drawing.Point(724, 330);
            this.sendbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(124, 37);
            this.sendbutton.TabIndex = 24;
            this.sendbutton.Text = "SEND";
            this.sendbutton.UseVisualStyleBackColor = false;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::home1.Properties.Resources.icon1;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 35);
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Chatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::home1.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 379);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.messagetextBox);
            this.Controls.Add(this.connectbutton);
            this.Controls.Add(this.clientPorttextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clientIptextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.serverPorttextBox);
            this.Controls.Add(this.chattextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.serverIptextBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Chatting";
            this.Text = "Chatting";
            this.Load += new System.EventHandler(this.Chatting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverIptextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox chattextBox;
        private System.Windows.Forms.TextBox serverPorttextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clientIptextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clientPorttextBox;
        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.TextBox messagetextBox;
        private System.Windows.Forms.Button sendbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}