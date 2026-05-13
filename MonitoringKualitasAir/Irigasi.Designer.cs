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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Irigasi));
            this.lblIrigasi = new System.Windows.Forms.Label();
            this.txtIDIrigasi = new System.Windows.Forms.TextBox();
            this.irigasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMonitoringKualitasAirDataSet2 = new DBMonitoringKualitasAirDataSet2();
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
            this.idirigasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namairigasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisirigasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKembali = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.irigasiTableAdapter = new DBMonitoringKualitasAirDataSet2TableAdapters.IrigasiTableAdapter();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.irigasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMonitoringKualitasAirDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.txtIDIrigasi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.irigasiBindingSource, "id_irigasi", true));
            this.txtIDIrigasi.Location = new System.Drawing.Point(135, 21);
            this.txtIDIrigasi.Name = "txtIDIrigasi";
            this.txtIDIrigasi.ReadOnly = true;
            this.txtIDIrigasi.Size = new System.Drawing.Size(100, 22);
            this.txtIDIrigasi.TabIndex = 1;
            // 
            // irigasiBindingSource
            // 
            this.irigasiBindingSource.DataMember = "Irigasi";
            this.irigasiBindingSource.DataSource = this.dBMonitoringKualitasAirDataSet2;
            // 
            // dBMonitoringKualitasAirDataSet2
            // 
            this.dBMonitoringKualitasAirDataSet2.DataSetName = "DBMonitoringKualitasAirDataSet2";
            this.dBMonitoringKualitasAirDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.txtNamaIrigasi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.irigasiBindingSource, "nama_irigasi", true));
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
            this.txtJenisIrigasi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.irigasiBindingSource, "jenis_irigasi", true));
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
            this.txtLokasi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.irigasiBindingSource, "lokasi", true));
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idirigasiDataGridViewTextBoxColumn,
            this.namairigasiDataGridViewTextBoxColumn,
            this.jenisirigasiDataGridViewTextBoxColumn,
            this.lokasiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.irigasiBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(22, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(752, 200);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idirigasiDataGridViewTextBoxColumn
            // 
            this.idirigasiDataGridViewTextBoxColumn.DataPropertyName = "id_irigasi";
            this.idirigasiDataGridViewTextBoxColumn.HeaderText = "id_irigasi";
            this.idirigasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idirigasiDataGridViewTextBoxColumn.Name = "idirigasiDataGridViewTextBoxColumn";
            this.idirigasiDataGridViewTextBoxColumn.ReadOnly = true;
            this.idirigasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // namairigasiDataGridViewTextBoxColumn
            // 
            this.namairigasiDataGridViewTextBoxColumn.DataPropertyName = "nama_irigasi";
            this.namairigasiDataGridViewTextBoxColumn.HeaderText = "nama_irigasi";
            this.namairigasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namairigasiDataGridViewTextBoxColumn.Name = "namairigasiDataGridViewTextBoxColumn";
            this.namairigasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // jenisirigasiDataGridViewTextBoxColumn
            // 
            this.jenisirigasiDataGridViewTextBoxColumn.DataPropertyName = "jenis_irigasi";
            this.jenisirigasiDataGridViewTextBoxColumn.HeaderText = "jenis_irigasi";
            this.jenisirigasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisirigasiDataGridViewTextBoxColumn.Name = "jenisirigasiDataGridViewTextBoxColumn";
            this.jenisirigasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // lokasiDataGridViewTextBoxColumn
            // 
            this.lokasiDataGridViewTextBoxColumn.DataPropertyName = "lokasi";
            this.lokasiDataGridViewTextBoxColumn.HeaderText = "lokasi";
            this.lokasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lokasiDataGridViewTextBoxColumn.Name = "lokasiDataGridViewTextBoxColumn";
            this.lokasiDataGridViewTextBoxColumn.Width = 125;
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
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.irigasiBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 31);
            this.bindingNavigator1.TabIndex = 15;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // irigasiTableAdapter
            // 
            this.irigasiTableAdapter.ClearBeforeFill = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(629, 165);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 16);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "jumlah Irigasi";
            // 
            // Irigasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.bindingNavigator1);
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
            ((System.ComponentModel.ISupportInitialize)(this.irigasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMonitoringKualitasAirDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DBMonitoringKualitasAirDataSet2 dBMonitoringKualitasAirDataSet2;
        private System.Windows.Forms.BindingSource irigasiBindingSource;
        private DBMonitoringKualitasAirDataSet2TableAdapters.IrigasiTableAdapter irigasiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idirigasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namairigasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisirigasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTotal;
    }
}