namespace MonitoringKualitasAir
{
    partial class Dashboard
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
            this.btnPetugas = new System.Windows.Forms.Button();
            this.btnLahan = new System.Windows.Forms.Button();
            this.btnIrigasi = new System.Windows.Forms.Button();
            this.btnMonitoring = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPetugas
            // 
            this.btnPetugas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPetugas.Location = new System.Drawing.Point(119, 152);
            this.btnPetugas.Name = "btnPetugas";
            this.btnPetugas.Size = new System.Drawing.Size(148, 51);
            this.btnPetugas.TabIndex = 0;
            this.btnPetugas.Text = "Data Petugas";
            this.btnPetugas.UseVisualStyleBackColor = false;
            this.btnPetugas.Click += new System.EventHandler(this.btnPetugas_Click);
            // 
            // btnLahan
            // 
            this.btnLahan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLahan.Location = new System.Drawing.Point(303, 152);
            this.btnLahan.Name = "btnLahan";
            this.btnLahan.Size = new System.Drawing.Size(148, 51);
            this.btnLahan.TabIndex = 1;
            this.btnLahan.Text = "Data Lahan";
            this.btnLahan.UseVisualStyleBackColor = false;
            this.btnLahan.Click += new System.EventHandler(this.btnLahan_Click);
            // 
            // btnIrigasi
            // 
            this.btnIrigasi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIrigasi.Location = new System.Drawing.Point(492, 152);
            this.btnIrigasi.Name = "btnIrigasi";
            this.btnIrigasi.Size = new System.Drawing.Size(148, 51);
            this.btnIrigasi.TabIndex = 2;
            this.btnIrigasi.Text = "Data Irigasi";
            this.btnIrigasi.UseVisualStyleBackColor = false;
            this.btnIrigasi.Click += new System.EventHandler(this.btnIrigasi_Click);
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMonitoring.Location = new System.Drawing.Point(200, 232);
            this.btnMonitoring.Name = "btnMonitoring";
            this.btnMonitoring.Size = new System.Drawing.Size(148, 51);
            this.btnMonitoring.TabIndex = 3;
            this.btnMonitoring.Text = "Monitoring Kualitas Air";
            this.btnMonitoring.UseVisualStyleBackColor = false;
            this.btnMonitoring.Click += new System.EventHandler(this.btnMonitoring_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLaporan.Location = new System.Drawing.Point(385, 232);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(148, 51);
            this.btnLaporan.TabIndex = 4;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(308, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu Utama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.Location = new System.Drawing.Point(597, 368);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 54);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnMonitoring);
            this.Controls.Add(this.btnIrigasi);
            this.Controls.Add(this.btnLahan);
            this.Controls.Add(this.btnPetugas);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPetugas;
        private System.Windows.Forms.Button btnLahan;
        private System.Windows.Forms.Button btnIrigasi;
        private System.Windows.Forms.Button btnMonitoring;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}