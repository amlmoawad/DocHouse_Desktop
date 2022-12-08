namespace home1
{
    partial class pharmacist
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
            this.DataReports = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataReports)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::home1.Properties.Resources.icon1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 52);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(26, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 38);
            this.label19.TabIndex = 52;
            this.label19.Text = "Reports";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(32, 585);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(157, 63);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(89)))), ((int)(((byte)(234)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(89)))), ((int)(((byte)(234)))));
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.TabIndex = 51;
            this.kryptonButton1.Values.Text = "Show Reports";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // DataReports
            // 
            this.DataReports.BackgroundColor = System.Drawing.Color.White;
            this.DataReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataReports.Location = new System.Drawing.Point(32, 136);
            this.DataReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataReports.Name = "DataReports";
            this.DataReports.RowHeadersWidth = 51;
            this.DataReports.RowTemplate.Height = 24;
            this.DataReports.Size = new System.Drawing.Size(867, 443);
            this.DataReports.TabIndex = 50;
            this.DataReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataReports_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(986, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 32);
            this.label10.TabIndex = 49;
            this.label10.Text = "Log out";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::home1.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1131, 682);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.DataReports);
            this.Controls.Add(this.label10);
            this.Name = "pharmacist";
            this.Text = "pharmacist";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.DataGridView DataReports;
        private System.Windows.Forms.Label label10;
    }
}