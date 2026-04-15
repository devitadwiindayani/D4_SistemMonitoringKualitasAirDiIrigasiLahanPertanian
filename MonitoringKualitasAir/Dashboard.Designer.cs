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
            this.SuspendLayout();
            // 
            // btnPetugas
            // 
            this.btnPetugas.Location = new System.Drawing.Point(303, 95);
            this.btnPetugas.Name = "btnPetugas";
            this.btnPetugas.Size = new System.Drawing.Size(148, 51);
            this.btnPetugas.TabIndex = 0;
            this.btnPetugas.Text = "Data Petugas";
            this.btnPetugas.UseVisualStyleBackColor = true;
            this.btnPetugas.Click += new System.EventHandler(this.btnPetugas_Click);
            // 
            // btnLahan
            // 
            this.btnLahan.Location = new System.Drawing.Point(303, 152);
            this.btnLahan.Name = "btnLahan";
            this.btnLahan.Size = new System.Drawing.Size(148, 51);
            this.btnLahan.TabIndex = 1;
            this.btnLahan.Text = "Data Lahan";
            this.btnLahan.UseVisualStyleBackColor = true;
            this.btnLahan.Click += new System.EventHandler(this.btnLahan_Click);
            // 
            // btnIrigasi
            // 
            this.btnIrigasi.Location = new System.Drawing.Point(303, 209);
            this.btnIrigasi.Name = "btnIrigasi";
            this.btnIrigasi.Size = new System.Drawing.Size(148, 51);
            this.btnIrigasi.TabIndex = 2;
            this.btnIrigasi.Text = "Data Irigasi";
            this.btnIrigasi.UseVisualStyleBackColor = true;
            this.btnIrigasi.Click += new System.EventHandler(this.btnIrigasi_Click);
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.Location = new System.Drawing.Point(303, 266);
            this.btnMonitoring.Name = "btnMonitoring";
            this.btnMonitoring.Size = new System.Drawing.Size(148, 51);
            this.btnMonitoring.TabIndex = 3;
            this.btnMonitoring.Text = "Monitoring Kualitas Air";
            this.btnMonitoring.UseVisualStyleBackColor = true;
            this.btnMonitoring.Click += new System.EventHandler(this.btnMonitoring_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Location = new System.Drawing.Point(303, 323);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(148, 51);
            this.btnLaporan.TabIndex = 4;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}