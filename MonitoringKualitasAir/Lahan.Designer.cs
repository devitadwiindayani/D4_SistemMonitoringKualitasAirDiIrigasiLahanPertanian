namespace MonitoringKualitasAir
{
    partial class Lahan
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
            this.lblLahan = new System.Windows.Forms.Label();
            this.txtIDLahan = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblNamaLahan = new System.Windows.Forms.Label();
            this.lblLokasi = new System.Windows.Forms.Label();
            this.lblLuasLahan = new System.Windows.Forms.Label();
            this.txtNamaLahan = new System.Windows.Forms.TextBox();
            this.txtLokasi = new System.Windows.Forms.TextBox();
            this.txtLuasLahan = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLahan
            // 
            this.lblLahan.AutoSize = true;
            this.lblLahan.Location = new System.Drawing.Point(77, 46);
            this.lblLahan.Name = "lblLahan";
            this.lblLahan.Size = new System.Drawing.Size(60, 16);
            this.lblLahan.TabIndex = 0;
            this.lblLahan.Text = "ID Lahan";
            // 
            // txtIDLahan
            // 
            this.txtIDLahan.Location = new System.Drawing.Point(195, 43);
            this.txtIDLahan.Name = "txtIDLahan";
            this.txtIDLahan.ReadOnly = true;
            this.txtIDLahan.Size = new System.Drawing.Size(100, 22);
            this.txtIDLahan.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(502, 46);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(143, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect Database";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblNamaLahan
            // 
            this.lblNamaLahan.AutoSize = true;
            this.lblNamaLahan.Location = new System.Drawing.Point(77, 88);
            this.lblNamaLahan.Name = "lblNamaLahan";
            this.lblNamaLahan.Size = new System.Drawing.Size(84, 16);
            this.lblNamaLahan.TabIndex = 3;
            this.lblNamaLahan.Text = "Nama Lahan";
            // 
            // lblLokasi
            // 
            this.lblLokasi.AutoSize = true;
            this.lblLokasi.Location = new System.Drawing.Point(77, 136);
            this.lblLokasi.Name = "lblLokasi";
            this.lblLokasi.Size = new System.Drawing.Size(47, 16);
            this.lblLokasi.TabIndex = 4;
            this.lblLokasi.Text = "Lokasi";
            // 
            // lblLuasLahan
            // 
            this.lblLuasLahan.AutoSize = true;
            this.lblLuasLahan.Location = new System.Drawing.Point(77, 173);
            this.lblLuasLahan.Name = "lblLuasLahan";
            this.lblLuasLahan.Size = new System.Drawing.Size(76, 16);
            this.lblLuasLahan.TabIndex = 5;
            this.lblLuasLahan.Text = "Luas Lahan";
            // 
            // txtNamaLahan
            // 
            this.txtNamaLahan.Location = new System.Drawing.Point(195, 85);
            this.txtNamaLahan.Name = "txtNamaLahan";
            this.txtNamaLahan.Size = new System.Drawing.Size(100, 22);
            this.txtNamaLahan.TabIndex = 6;
            // 
            // txtLokasi
            // 
            this.txtLokasi.Location = new System.Drawing.Point(195, 130);
            this.txtLokasi.Name = "txtLokasi";
            this.txtLokasi.Size = new System.Drawing.Size(100, 22);
            this.txtLokasi.TabIndex = 7;
            // 
            // txtLuasLahan
            // 
            this.txtLuasLahan.Location = new System.Drawing.Point(195, 167);
            this.txtLuasLahan.Name = "txtLuasLahan";
            this.txtLuasLahan.Size = new System.Drawing.Size(100, 22);
            this.txtLuasLahan.TabIndex = 8;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(502, 81);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(143, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Menampilkan Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(502, 110);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(143, 23);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Menambahkan Data";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(502, 139);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Mengubah Data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(502, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Menghapus Data";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 182);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(630, 415);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(143, 23);
            this.btnKembali.TabIndex = 14;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtLuasLahan);
            this.Controls.Add(this.txtLokasi);
            this.Controls.Add(this.txtNamaLahan);
            this.Controls.Add(this.lblLuasLahan);
            this.Controls.Add(this.lblLokasi);
            this.Controls.Add(this.lblNamaLahan);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtIDLahan);
            this.Controls.Add(this.lblLahan);
            this.Name = "Lahan";
            this.Text = "Lahan";
            this.Load += new System.EventHandler(this.Lahan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLahan;
        private System.Windows.Forms.TextBox txtIDLahan;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblNamaLahan;
        private System.Windows.Forms.Label lblLokasi;
        private System.Windows.Forms.Label lblLuasLahan;
        private System.Windows.Forms.TextBox txtNamaLahan;
        private System.Windows.Forms.TextBox txtLokasi;
        private System.Windows.Forms.TextBox txtLuasLahan;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKembali;
    }
}