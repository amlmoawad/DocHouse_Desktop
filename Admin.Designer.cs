using TestStack.BDDfy.Configuration;

namespace home1
{
    partial class Admin
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
            this.ShowDoctor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.joinus = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.showAppointment = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DataAppointment = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.doctors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.joinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctors)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowDoctor
            // 
            this.ShowDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowDoctor.Location = new System.Drawing.Point(12, 443);
            this.ShowDoctor.Name = "ShowDoctor";
            this.ShowDoctor.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ShowDoctor.Size = new System.Drawing.Size(145, 43);
            this.ShowDoctor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(89)))), ((int)(((byte)(234)))));
            this.ShowDoctor.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(89)))), ((int)(((byte)(234)))));
            this.ShowDoctor.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.ShowDoctor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ShowDoctor.StateCommon.Border.Rounding = 20;
            this.ShowDoctor.TabIndex = 61;
            this.ShowDoctor.Values.Text = "Show Doctors";
            this.ShowDoctor.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(470, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 60;
            this.label1.Text = "Doctors";
            // 
            // joinus
            // 
            this.joinus.BackgroundColor = System.Drawing.Color.White;
            this.joinus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.joinus.Location = new System.Drawing.Point(12, 258);
            this.joinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.joinus.Name = "joinus";
            this.joinus.RowHeadersWidth = 51;
            this.joinus.RowTemplate.Height = 24;
            this.joinus.Size = new System.Drawing.Size(396, 180);
            this.joinus.TabIndex = 59;
            this.joinus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::home1.Properties.Resources.icon1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 36);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(20, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(178, 31);
            this.label19.TabIndex = 57;
            this.label19.Text = "Appointments";
            // 
            // showAppointment
            // 
            this.showAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAppointment.Location = new System.Drawing.Point(721, 168);
            this.showAppointment.Name = "showAppointment";
            this.showAppointment.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.showAppointment.Size = new System.Drawing.Size(105, 43);
            this.showAppointment.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(89)))), ((int)(((byte)(234)))));
            this.showAppointment.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(89)))), ((int)(((byte)(234)))));
            this.showAppointment.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.showAppointment.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.showAppointment.StateCommon.Border.Rounding = 20;
            this.showAppointment.TabIndex = 56;
            this.showAppointment.Values.Text = "Apponitments";
            this.showAppointment.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // DataAppointment
            // 
            this.DataAppointment.BackgroundColor = System.Drawing.Color.White;
            this.DataAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAppointment.Location = new System.Drawing.Point(12, 64);
            this.DataAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataAppointment.Name = "DataAppointment";
            this.DataAppointment.RowHeadersWidth = 51;
            this.DataAppointment.RowTemplate.Height = 24;
            this.DataAppointment.Size = new System.Drawing.Size(703, 147);
            this.DataAppointment.TabIndex = 55;
            this.DataAppointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(882, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 54;
            this.label10.Text = "Log out";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(730, 443);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(145, 43);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(89)))), ((int)(((byte)(234)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(89)))), ((int)(((byte)(234)))));
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.TabIndex = 64;
            this.kryptonButton1.Values.Text = "Show Doctors";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 31);
            this.label2.TabIndex = 63;
            this.label2.Text = "Doctors Who want to join";
            // 
            // doctors
            // 
            this.doctors.BackgroundColor = System.Drawing.Color.White;
            this.doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctors.Location = new System.Drawing.Point(458, 258);
            this.doctors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctors.Name = "doctors";
            this.doctors.RowHeadersWidth = 51;
            this.doctors.RowTemplate.Height = 24;
            this.doctors.Size = new System.Drawing.Size(394, 180);
            this.doctors.TabIndex = 62;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::home1.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 488);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.doctors);
            this.Controls.Add(this.ShowDoctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.joinus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.showAppointment);
            this.Controls.Add(this.DataAppointment);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.joinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton ShowDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView joinus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
        private ComponentFactory.Krypton.Toolkit.KryptonButton showAppointment;
        private System.Windows.Forms.DataGridView DataAppointment;
        private System.Windows.Forms.Label label10;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView doctors;
    }
}