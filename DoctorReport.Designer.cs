namespace home1
{
    partial class DoctorReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxmidcase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxreqmidcine = new System.Windows.Forms.TextBox();
            this.textBoxreqexamination = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(525, 33);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(349, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // textBoxmidcase
            // 
            this.textBoxmidcase.Location = new System.Drawing.Point(526, 100);
            this.textBoxmidcase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxmidcase.Multiline = true;
            this.textBoxmidcase.Name = "textBoxmidcase";
            this.textBoxmidcase.Size = new System.Drawing.Size(351, 67);
            this.textBoxmidcase.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(526, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Appointment ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(526, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Medical Case";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(526, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Required Medicine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(525, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rerquired Examination";
            // 
            // textBoxreqmidcine
            // 
            this.textBoxreqmidcine.Location = new System.Drawing.Point(525, 219);
            this.textBoxreqmidcine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxreqmidcine.Multiline = true;
            this.textBoxreqmidcine.Name = "textBoxreqmidcine";
            this.textBoxreqmidcine.Size = new System.Drawing.Size(351, 67);
            this.textBoxreqmidcine.TabIndex = 8;
            // 
            // textBoxreqexamination
            // 
            this.textBoxreqexamination.Location = new System.Drawing.Point(525, 338);
            this.textBoxreqexamination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxreqexamination.Multiline = true;
            this.textBoxreqexamination.Name = "textBoxreqexamination";
            this.textBoxreqexamination.Size = new System.Drawing.Size(351, 67);
            this.textBoxreqexamination.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(321, 359);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(102, 36);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::home1.Properties.Resources.icon1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 24);
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(530, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 90;
            // 
            // DoctorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::home1.Properties.Resources.photo_٢٠٢٢_١٢_٠٣_١٩_١٦_٤٥;
            this.ClientSize = new System.Drawing.Size(933, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBoxreqexamination);
            this.Controls.Add(this.textBoxreqmidcine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxmidcase);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DoctorReport";
            this.Text = "DoctorReport";
            this.Load += new System.EventHandler(this.DoctorReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxmidcase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxreqmidcine;
        private System.Windows.Forms.TextBox textBoxreqexamination;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}