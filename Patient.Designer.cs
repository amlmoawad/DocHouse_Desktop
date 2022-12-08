namespace home1
{
    partial class Patient
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Appointments = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Reports = new System.Windows.Forms.DataGridView();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Appointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reports)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::home1.Properties.Resources.icon1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 52);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(28, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(222, 38);
            this.label19.TabIndex = 45;
            this.label19.Text = "Appointments";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(34, 597);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(169, 53);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(89)))), ((int)(((byte)(234)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(89)))), ((int)(((byte)(234)))));
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.TabIndex = 44;
            this.kryptonButton1.Values.Text = "Show apponitments";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // Appointments
            // 
            this.Appointments.BackgroundColor = System.Drawing.Color.White;
            this.Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Appointments.Location = new System.Drawing.Point(34, 119);
            this.Appointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Appointments.Name = "Appointments";
            this.Appointments.RowHeadersWidth = 51;
            this.Appointments.RowTemplate.Height = 24;
            this.Appointments.Size = new System.Drawing.Size(433, 472);
            this.Appointments.TabIndex = 43;
            this.Appointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Appointments_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(1009, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 32);
            this.label10.TabIndex = 42;
            this.label10.Text = "Log out";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(478, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 38);
            this.label1.TabIndex = 52;
            this.label1.Text = "Reports";
            // 
            // Reports
            // 
            this.Reports.BackgroundColor = System.Drawing.Color.White;
            this.Reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reports.Location = new System.Drawing.Point(484, 119);
            this.Reports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reports.Name = "Reports";
            this.Reports.RowHeadersWidth = 51;
            this.Reports.RowTemplate.Height = 24;
            this.Reports.Size = new System.Drawing.Size(405, 472);
            this.Reports.TabIndex = 50;
            this.Reports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton3.Location = new System.Drawing.Point(484, 597);
            this.kryptonButton3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton3.Size = new System.Drawing.Size(169, 53);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(89)))), ((int)(((byte)(234)))));
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(89)))), ((int)(((byte)(234)))));
            this.kryptonButton3.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Rounding = 20;
            this.kryptonButton3.TabIndex = 53;
            this.kryptonButton3.Values.Text = "Show Reports";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::home1.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1131, 681);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reports);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.Appointments);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Patient";
            this.Text = "Patient Profile";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Appointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.DataGridView Appointments;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Reports;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
    }
}