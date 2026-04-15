namespace MonitoringKualitasAir
{
    partial class Petugas
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
            this.lblIDPetugas = new System.Windows.Forms.Label();
            this.txtIDPetugas = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lnlNamaPetugas = new System.Windows.Forms.Label();
            this.lblNoHP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaPetugas = new System.Windows.Forms.TextBox();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDPetugas
            // 
            this.lblIDPetugas.AutoSize = true;
            this.lblIDPetugas.Location = new System.Drawing.Point(44, 40);
            this.lblIDPetugas.Name = "lblIDPetugas";
            this.lblIDPetugas.Size = new System.Drawing.Size(73, 16);
            this.lblIDPetugas.TabIndex = 0;
            this.lblIDPetugas.Text = "ID Petugas";
            // 
            // txtIDPetugas
            // 
            this.txtIDPetugas.Location = new System.Drawing.Point(147, 33);
            this.txtIDPetugas.Name = "txtIDPetugas";
            this.txtIDPetugas.ReadOnly = true;
            this.txtIDPetugas.Size = new System.Drawing.Size(190, 22);
            this.txtIDPetugas.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConnect.Location = new System.Drawing.Point(379, 32);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(180, 41);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect Database";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lnlNamaPetugas
            // 
            this.lnlNamaPetugas.AutoSize = true;
            this.lnlNamaPetugas.Location = new System.Drawing.Point(44, 86);
            this.lnlNamaPetugas.Name = "lnlNamaPetugas";
            this.lnlNamaPetugas.Size = new System.Drawing.Size(97, 16);
            this.lnlNamaPetugas.TabIndex = 3;
            this.lnlNamaPetugas.Text = "Nama Petugas";
            // 
            // lblNoHP
            // 
            this.lblNoHP.AutoSize = true;
            this.lblNoHP.Location = new System.Drawing.Point(44, 140);
            this.lblNoHP.Name = "lblNoHP";
            this.lblNoHP.Size = new System.Drawing.Size(47, 16);
            this.lblNoHP.TabIndex = 4;
            this.lblNoHP.Text = "No HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 5;
            // 
            // txtNamaPetugas
            // 
            this.txtNamaPetugas.Location = new System.Drawing.Point(147, 80);
            this.txtNamaPetugas.Name = "txtNamaPetugas";
            this.txtNamaPetugas.Size = new System.Drawing.Size(190, 22);
            this.txtNamaPetugas.TabIndex = 6;
            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(147, 134);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(190, 22);
            this.txtNoHP.TabIndex = 7;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.Location = new System.Drawing.Point(591, 32);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(180, 41);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Menampilkan Data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInsert.Location = new System.Drawing.Point(379, 86);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(180, 33);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Menambah Data";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(591, 86);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 33);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Mengubah Data";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(491, 137);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 40);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Menghapus Data";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(689, 190);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(591, 395);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(155, 43);
            this.btnKembali.TabIndex = 13;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // Petugas
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
            this.Controls.Add(this.txtNoHP);
            this.Controls.Add(this.txtNamaPetugas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNoHP);
            this.Controls.Add(this.lnlNamaPetugas);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtIDPetugas);
            this.Controls.Add(this.lblIDPetugas);
            this.Name = "Petugas";
            this.Text = "Petugas";
            this.Load += new System.EventHandler(this.Petugas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDPetugas;
        private System.Windows.Forms.TextBox txtIDPetugas;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lnlNamaPetugas;
        private System.Windows.Forms.Label lblNoHP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaPetugas;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKembali;
    }
}