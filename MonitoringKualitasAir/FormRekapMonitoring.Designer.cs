namespace MonitoringKualitasAir
{
    partial class FormRekapMonitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRekapMonitoring));
            this.lblRekapData = new System.Windows.Forms.Label();
            this.lblNamaLahan = new System.Windows.Forms.Label();
            this.cmbFilterLahan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTahun = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRekapData
            // 
            this.lblRekapData.AutoSize = true;
            this.lblRekapData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRekapData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRekapData.Location = new System.Drawing.Point(271, 26);
            this.lblRekapData.Name = "lblRekapData";
            this.lblRekapData.Size = new System.Drawing.Size(248, 20);
            this.lblRekapData.TabIndex = 0;
            this.lblRekapData.Text = "REKAP DATA MONITORING";
            // 
            // lblNamaLahan
            // 
            this.lblNamaLahan.AutoSize = true;
            this.lblNamaLahan.Location = new System.Drawing.Point(42, 75);
            this.lblNamaLahan.Name = "lblNamaLahan";
            this.lblNamaLahan.Size = new System.Drawing.Size(84, 16);
            this.lblNamaLahan.TabIndex = 1;
            this.lblNamaLahan.Text = "Nama Lahan";
            // 
            // cmbFilterLahan
            // 
            this.cmbFilterLahan.FormattingEnabled = true;
            this.cmbFilterLahan.Location = new System.Drawing.Point(151, 66);
            this.cmbFilterLahan.Name = "cmbFilterLahan";
            this.cmbFilterLahan.Size = new System.Drawing.Size(121, 24);
            this.cmbFilterLahan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tahun Monitoring";
            // 
            // dtpTahun
            // 
            this.dtpTahun.Location = new System.Drawing.Point(442, 67);
            this.dtpTahun.Name = "dtpTahun";
            this.dtpTahun.Size = new System.Drawing.Size(200, 22);
            this.dtpTahun.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(693, 66);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(693, 415);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(75, 23);
            this.btnCetak.TabIndex = 6;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(723, 242);
            this.dataGridView1.TabIndex = 7;
            // 
            // FormRekapMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtpTahun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFilterLahan);
            this.Controls.Add(this.lblNamaLahan);
            this.Controls.Add(this.lblRekapData);
            this.Name = "FormRekapMonitoring";
            this.Text = "FormRekapMonitoring";
            this.Load += new System.EventHandler(this.FormRekapMonitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRekapData;
        private System.Windows.Forms.Label lblNamaLahan;
        private System.Windows.Forms.ComboBox cmbFilterLahan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTahun;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}