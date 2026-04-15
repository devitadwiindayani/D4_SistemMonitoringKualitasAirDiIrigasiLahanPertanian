namespace MonitoringKualitasAir
{
    partial class MonitoringKualitasAir
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIDMonitoring = new System.Windows.Forms.TextBox();
            this.txtPH = new System.Windows.Forms.TextBox();
            this.txtIDPetugas = new System.Windows.Forms.TextBox();
            this.txtIDIrigasi = new System.Windows.Forms.TextBox();
            this.txtIDLahan = new System.Windows.Forms.TextBox();
            this.btnKoneksi = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.dptTanggal = new System.Windows.Forms.DateTimePicker();
            this.cmbKondisi = new System.Windows.Forms.ComboBox();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Monitoring";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "kondisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "pH Air";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Petugas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Irigasi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID Lahan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tanggal";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1262, 203);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtIDMonitoring
            // 
            this.txtIDMonitoring.Location = new System.Drawing.Point(140, 25);
            this.txtIDMonitoring.Name = "txtIDMonitoring";
            this.txtIDMonitoring.ReadOnly = true;
            this.txtIDMonitoring.Size = new System.Drawing.Size(100, 22);
            this.txtIDMonitoring.TabIndex = 8;
            this.txtIDMonitoring.TextChanged += new System.EventHandler(this.txtIDMonitoring_TextChanged);
            // 
            // txtPH
            // 
            this.txtPH.Location = new System.Drawing.Point(140, 195);
            this.txtPH.Name = "txtPH";
            this.txtPH.Size = new System.Drawing.Size(100, 22);
            this.txtPH.TabIndex = 10;
            this.txtPH.TextChanged += new System.EventHandler(this.txtPH_TextChanged);
            // 
            // txtIDPetugas
            // 
            this.txtIDPetugas.Location = new System.Drawing.Point(140, 130);
            this.txtIDPetugas.Name = "txtIDPetugas";
            this.txtIDPetugas.Size = new System.Drawing.Size(100, 22);
            this.txtIDPetugas.TabIndex = 12;
            this.txtIDPetugas.TextChanged += new System.EventHandler(this.txtIDPetugas_TextChanged);
            // 
            // txtIDIrigasi
            // 
            this.txtIDIrigasi.Location = new System.Drawing.Point(140, 92);
            this.txtIDIrigasi.Name = "txtIDIrigasi";
            this.txtIDIrigasi.Size = new System.Drawing.Size(100, 22);
            this.txtIDIrigasi.TabIndex = 13;
            this.txtIDIrigasi.TextChanged += new System.EventHandler(this.txtIDIrigasi_TextChanged);
            // 
            // txtIDLahan
            // 
            this.txtIDLahan.Location = new System.Drawing.Point(140, 57);
            this.txtIDLahan.Name = "txtIDLahan";
            this.txtIDLahan.Size = new System.Drawing.Size(100, 22);
            this.txtIDLahan.TabIndex = 14;
            this.txtIDLahan.TextChanged += new System.EventHandler(this.txtIDLahan_TextChanged);
            // 
            // btnKoneksi
            // 
            this.btnKoneksi.Location = new System.Drawing.Point(432, 31);
            this.btnKoneksi.Name = "btnKoneksi";
            this.btnKoneksi.Size = new System.Drawing.Size(140, 23);
            this.btnKoneksi.TabIndex = 15;
            this.btnKoneksi.Text = "Koneksi Data";
            this.btnKoneksi.UseVisualStyleBackColor = true;
            this.btnKoneksi.Click += new System.EventHandler(this.btnKoneksi_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(432, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "HapusData";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(432, 136);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Edit Data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(432, 101);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(140, 23);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Tampilkan Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(432, 69);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(140, 23);
            this.btnSimpan.TabIndex = 19;
            this.btnSimpan.Text = "Menambah Data";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Keterangan";
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(140, 260);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(100, 22);
            this.txtKeterangan.TabIndex = 21;
            this.txtKeterangan.TextChanged += new System.EventHandler(this.txtKeterangan_TextChanged);
            // 
            // dptTanggal
            // 
            this.dptTanggal.Location = new System.Drawing.Point(140, 162);
            this.dptTanggal.Name = "dptTanggal";
            this.dptTanggal.Size = new System.Drawing.Size(200, 22);
            this.dptTanggal.TabIndex = 22;
            this.dptTanggal.ValueChanged += new System.EventHandler(this.dptTanggal_ValueChanged);
            // 
            // cmbKondisi
            // 
            this.cmbKondisi.FormattingEnabled = true;
            this.cmbKondisi.Location = new System.Drawing.Point(140, 228);
            this.cmbKondisi.Name = "cmbKondisi";
            this.cmbKondisi.Size = new System.Drawing.Size(121, 24);
            this.cmbKondisi.TabIndex = 23;
            this.cmbKondisi.SelectedIndexChanged += new System.EventHandler(this.cmbKondisi_SelectedIndexChanged);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(1133, 259);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(140, 23);
            this.btnKembali.TabIndex = 24;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // MonitoringKualitasAir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 520);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.cmbKondisi);
            this.Controls.Add(this.dptTanggal);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnKoneksi);
            this.Controls.Add(this.txtIDLahan);
            this.Controls.Add(this.txtIDIrigasi);
            this.Controls.Add(this.txtIDPetugas);
            this.Controls.Add(this.txtPH);
            this.Controls.Add(this.txtIDMonitoring);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MonitoringKualitasAir";
            this.Text = "MonitoringKualitasAir";
            this.Load += new System.EventHandler(this.MonitoringKualitasAir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIDMonitoring;
        private System.Windows.Forms.TextBox txtPH;
        private System.Windows.Forms.TextBox txtIDPetugas;
        private System.Windows.Forms.TextBox txtIDIrigasi;
        private System.Windows.Forms.TextBox txtIDLahan;
        private System.Windows.Forms.Button btnKoneksi;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.DateTimePicker dptTanggal;
        private System.Windows.Forms.ComboBox cmbKondisi;
        private System.Windows.Forms.Button btnKembali;
    }
}