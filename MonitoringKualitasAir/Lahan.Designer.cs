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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lahan));
            this.lblLahan = new System.Windows.Forms.Label();
            this.txtIDLahan = new System.Windows.Forms.TextBox();
            this.lahanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMonitoringKualitasAirDataSet1 = new DBMonitoringKualitasAirDataSet1();
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
            this.idlahanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namalahanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luaslahanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lahanTableAdapter = new DBMonitoringKualitasAirDataSet1TableAdapters.LahanTableAdapter();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lahanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMonitoringKualitasAirDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.txtIDLahan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lahanBindingSource, "id_lahan", true));
            this.txtIDLahan.Location = new System.Drawing.Point(195, 43);
            this.txtIDLahan.Name = "txtIDLahan";
            this.txtIDLahan.ReadOnly = true;
            this.txtIDLahan.Size = new System.Drawing.Size(100, 22);
            this.txtIDLahan.TabIndex = 1;
            // 
            // lahanBindingSource
            // 
            this.lahanBindingSource.DataMember = "Lahan";
            this.lahanBindingSource.DataSource = this.dBMonitoringKualitasAirDataSet1;
            // 
            // dBMonitoringKualitasAirDataSet1
            // 
            this.dBMonitoringKualitasAirDataSet1.DataSetName = "DBMonitoringKualitasAirDataSet1";
            this.dBMonitoringKualitasAirDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConnect.Location = new System.Drawing.Point(404, 43);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(143, 38);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect Database";
            this.btnConnect.UseVisualStyleBackColor = false;
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
            this.txtNamaLahan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lahanBindingSource, "nama_lahan", true));
            this.txtNamaLahan.Location = new System.Drawing.Point(195, 85);
            this.txtNamaLahan.Name = "txtNamaLahan";
            this.txtNamaLahan.Size = new System.Drawing.Size(100, 22);
            this.txtNamaLahan.TabIndex = 6;
            // 
            // txtLokasi
            // 
            this.txtLokasi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lahanBindingSource, "lokasi", true));
            this.txtLokasi.Location = new System.Drawing.Point(195, 130);
            this.txtLokasi.Name = "txtLokasi";
            this.txtLokasi.Size = new System.Drawing.Size(100, 22);
            this.txtLokasi.TabIndex = 7;
            // 
            // txtLuasLahan
            // 
            this.txtLuasLahan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lahanBindingSource, "luas_lahan", true));
            this.txtLuasLahan.Location = new System.Drawing.Point(195, 167);
            this.txtLuasLahan.Name = "txtLuasLahan";
            this.txtLuasLahan.Size = new System.Drawing.Size(100, 22);
            this.txtLuasLahan.TabIndex = 8;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.Location = new System.Drawing.Point(583, 43);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(143, 38);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Menampilkan Data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInsert.Location = new System.Drawing.Point(404, 98);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(143, 35);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Menambahkan Data";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(583, 98);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 35);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Mengubah Data";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(492, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 37);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Menghapus Data";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlahanDataGridViewTextBoxColumn,
            this.namalahanDataGridViewTextBoxColumn,
            this.lokasiDataGridViewTextBoxColumn,
            this.luaslahanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lahanBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(48, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 182);
            this.dataGridView1.TabIndex = 13;
            // 
            // idlahanDataGridViewTextBoxColumn
            // 
            this.idlahanDataGridViewTextBoxColumn.DataPropertyName = "id_lahan";
            this.idlahanDataGridViewTextBoxColumn.HeaderText = "id_lahan";
            this.idlahanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idlahanDataGridViewTextBoxColumn.Name = "idlahanDataGridViewTextBoxColumn";
            this.idlahanDataGridViewTextBoxColumn.ReadOnly = true;
            this.idlahanDataGridViewTextBoxColumn.Width = 125;
            // 
            // namalahanDataGridViewTextBoxColumn
            // 
            this.namalahanDataGridViewTextBoxColumn.DataPropertyName = "nama_lahan";
            this.namalahanDataGridViewTextBoxColumn.HeaderText = "nama_lahan";
            this.namalahanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namalahanDataGridViewTextBoxColumn.Name = "namalahanDataGridViewTextBoxColumn";
            this.namalahanDataGridViewTextBoxColumn.Width = 125;
            // 
            // lokasiDataGridViewTextBoxColumn
            // 
            this.lokasiDataGridViewTextBoxColumn.DataPropertyName = "lokasi";
            this.lokasiDataGridViewTextBoxColumn.HeaderText = "lokasi";
            this.lokasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lokasiDataGridViewTextBoxColumn.Name = "lokasiDataGridViewTextBoxColumn";
            this.lokasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // luaslahanDataGridViewTextBoxColumn
            // 
            this.luaslahanDataGridViewTextBoxColumn.DataPropertyName = "luas_lahan";
            this.luaslahanDataGridViewTextBoxColumn.HeaderText = "luas_lahan";
            this.luaslahanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luaslahanDataGridViewTextBoxColumn.Name = "luaslahanDataGridViewTextBoxColumn";
            this.luaslahanDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(630, 400);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(143, 38);
            this.btnKembali.TabIndex = 14;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.lahanBindingSource;
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
            // lahanTableAdapter
            // 
            this.lahanTableAdapter.ClearBeforeFill = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(91, 421);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 16);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total Lahan";
            // 
            // Lahan
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
            ((System.ComponentModel.ISupportInitialize)(this.lahanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMonitoringKualitasAirDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
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
        private DBMonitoringKualitasAirDataSet1 dBMonitoringKualitasAirDataSet1;
        private System.Windows.Forms.BindingSource lahanBindingSource;
        private DBMonitoringKualitasAirDataSet1TableAdapters.LahanTableAdapter lahanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namalahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luaslahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTotal;
    }
}