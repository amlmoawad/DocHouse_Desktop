namespace home1
{
    partial class doctor
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
            this.label10 = new System.Windows.Forms.Label();
            this.DataAppointment = new System.Windows.Forms.DataGridView();
            this.showAppointment = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(1009, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "Log out";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // DataAppointment
            // 
            this.DataAppointment.BackgroundColor = System.Drawing.Color.White;
            this.DataAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAppointment.Location = new System.Drawing.Point(34, 147);
            this.DataAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataAppointment.Name = "DataAppointment";
            this.DataAppointment.RowHeadersWidth = 51;
            this.DataAppointment.RowTemplate.Height = 24;
            this.DataAppointment.Size = new System.Drawing.Size(892, 440);
            this.DataAppointment.TabIndex = 20;
            this.DataAppointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // showAppointment
            // 
            this.showAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAppointment.Location = new System.Drawing.Point(34, 593);
            this.showAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.showAppointment.Name = "showAppointment";
            this.showAppointment.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.showAppointment.Size = new System.Drawing.Size(157, 63);
            this.showAppointment.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(89)))), ((int)(((byte)(234)))));
            this.showAppointment.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(89)))), ((int)(((byte)(234)))));
            this.showAppointment.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.showAppointment.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.showAppointment.StateCommon.Border.Rounding = 20;
            this.showAppointment.TabIndex = 27;
            this.showAppointment.Values.Text = "Show apponitments";
            this.showAppointment.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(28, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(222, 38);
            this.label19.TabIndex = 36;
            this.label19.Text = "Appointments";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::home1.Properties.Resources.icon1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 52);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::home1.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1131, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.showAppointment);
            this.Controls.Add(this.DataAppointment);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "doctor";
            this.Text = "Doctor Profile";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DataAppointment;
        private ComponentFactory.Krypton.Toolkit.KryptonButton showAppointment;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}