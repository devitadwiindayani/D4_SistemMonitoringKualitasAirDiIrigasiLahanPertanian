namespace MonitoringKualitasAir
{
    partial class Irigasi
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
            this.lblIrigasi = new System.Windows.Forms.Label();
            this.txtIDIrigasi = new System.Windows.Forms.TextBox();
            this.lblNamaIrigasi = new System.Windows.Forms.Label();
            this.txtNamaIrigasi = new System.Windows.Forms.TextBox();
            this.lblJenisIrigasi = new System.Windows.Forms.Label();
            this.txtJenisIrigasi = new System.Windows.Forms.TextBox();
            this.lblLokasi = new System.Windows.Forms.Label();
            this.txtLokasi = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIrigasi
            // 
            this.lblIrigasi.AutoSize = true;
            this.lblIrigasi.Location = new System.Drawing.Point(30, 28);
            this.lblIrigasi.Name = "lblIrigasi";
            this.lblIrigasi.Size = new System.Drawing.Size(59, 16);
            this.lblIrigasi.TabIndex = 0;
            this.lblIrigasi.Text = "ID Irigasi";
            // 
            // txtIDIrigasi
            // 
            this.txtIDIrigasi.Location = new System.Drawing.Point(135, 21);
            this.txtIDIrigasi.Name = "txtIDIrigasi";
            this.txtIDIrigasi.ReadOnly = true;
            this.txtIDIrigasi.Size = new System.Drawing.Size(100, 22);
            this.txtIDIrigasi.TabIndex = 1;
            // 
            // lblNamaIrigasi
            // 
            this.lblNamaIrigasi.AutoSize = true;
            this.lblNamaIrigasi.Location = new System.Drawing.Point(33, 62);
            this.lblNamaIrigasi.Name = "lblNamaIrigasi";
            this.lblNamaIrigasi.Size = new System.Drawing.Size(83, 16);
            this.lblNamaIrigasi.TabIndex = 2;
            this.lblNamaIrigasi.Text = "Nama Irigasi";
            // 
            // txtNamaIrigasi
            // 
            this.txtNamaIrigasi.Location = new System.Drawing.Point(135, 55);
            this.txtNamaIrigasi.Name = "txtNamaIrigasi";
            this.txtNamaIrigasi.Size = new System.Drawing.Size(161, 22);
            this.txtNamaIrigasi.TabIndex = 3;
            // 
            // lblJenisIrigasi
            // 
            this.lblJenisIrigasi.AutoSize = true;
            this.lblJenisIrigasi.Location = new System.Drawing.Point(33, 98);
            this.lblJenisIrigasi.Name = "lblJenisIrigasi";
            this.lblJenisIrigasi.Size = new System.Drawing.Size(78, 16);
            this.lblJenisIrigasi.TabIndex = 4;
            this.lblJenisIrigasi.Text = "Jenis Irigasi";
            // 
            // txtJenisIrigasi
            // 
            this.txtJenisIrigasi.Location = new System.Drawing.Point(135, 91);
            this.txtJenisIrigasi.Name = "txtJenisIrigasi";
            this.txtJenisIrigasi.Size = new System.Drawing.Size(161, 22);
            this.txtJenisIrigasi.TabIndex = 5;
            // 
            // lblLokasi
            // 
            this.lblLokasi.AutoSize = true;
            this.lblLokasi.Location = new System.Drawing.Point(33, 135);
            this.lblLokasi.Name = "lblLokasi";
            this.lblLokasi.Size = new System.Drawing.Size(47, 16);
            this.lblLokasi.TabIndex = 6;
            this.lblLokasi.Text = "Lokasi";
            // 
            // txtLokasi
            // 
            this.txtLokasi.Location = new System.Drawing.Point(135, 128);
            this.txtLokasi.Name = "txtLokasi";
            this.txtLokasi.Size = new System.Drawing.Size(161, 22);
            this.txtLokasi.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConnect.Location = new System.Drawing.Point(367, 20);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 50);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect Database";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.Location = new System.Drawing.Point(543, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(131, 50);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Menampilkan Data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInsert.Location = new System.Drawing.Point(543, 80);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(131, 49);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Menambah Data";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(366, 76);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 52);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Mengubah Data";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(456, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 47);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Menghapus Data";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(22, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(752, 200);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(643, 394);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(131, 44);
            this.btnKembali.TabIndex = 14;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // Irigasi
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
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtLokasi);
            this.Controls.Add(this.lblLokasi);
            this.Controls.Add(this.txtJenisIrigasi);
            this.Controls.Add(this.lblJenisIrigasi);
            this.Controls.Add(this.txtNamaIrigasi);
            this.Controls.Add(this.lblNamaIrigasi);
            this.Controls.Add(this.txtIDIrigasi);
            this.Controls.Add(this.lblIrigasi);
            this.Name = "Irigasi";
            this.Text = "Irigasi";
            this.Load += new System.EventHandler(this.Irigasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIrigasi;
        private System.Windows.Forms.TextBox txtIDIrigasi;
        private System.Windows.Forms.Label lblNamaIrigasi;
        private System.Windows.Forms.TextBox txtNamaIrigasi;
        private System.Windows.Forms.Label lblJenisIrigasi;
        private System.Windows.Forms.TextBox txtJenisIrigasi;
        private System.Windows.Forms.Label lblLokasi;
        private System.Windows.Forms.TextBox txtLokasi;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKembali;
    }
}