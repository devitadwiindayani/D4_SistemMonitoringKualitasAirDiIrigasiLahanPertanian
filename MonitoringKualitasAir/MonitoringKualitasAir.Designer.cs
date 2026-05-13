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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoringKualitasAir));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmonitoringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlahanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idirigasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpetugasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalmonitoringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phairDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kondisiairDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitoringKualitasAirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMonitoringKualitasAirDataSet3 = new DBMonitoringKualitasAirDataSet3();
            this.txtIDMonitoring = new System.Windows.Forms.TextBox();
            this.vwMonitoringKualitasAirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMonitoringKualitasAirDataSet4 = new DBMonitoringKualitasAirDataSet4();
            this.txtPH = new System.Windows.Forms.TextBox();
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
            this.monitoringKualitasAirTableAdapter = new DBMonitoringKualitasAirDataSet3TableAdapters.MonitoringKualitasAirTableAdapter();
            this.cmbLahan = new System.Windows.Forms.ComboBox();
            this.cmbPetugas = new System.Windows.Forms.ComboBox();
            this.cmbIrigasi = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnResetData = new System.Windows.Forms.Button();
            this.btnInjectionMonitoring = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.vw_MonitoringKualitasAirTableAdapter = new DBMonitoringKualitasAirDataSet4TableAdapters.vw_MonitoringKualitasAirTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringKualitasAirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMonitoringKualitasAirDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMonitoringKualitasAirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMonitoringKualitasAirDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama Petugas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nama Irigasi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nama Lahan";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmonitoringDataGridViewTextBoxColumn,
            this.idlahanDataGridViewTextBoxColumn,
            this.idirigasiDataGridViewTextBoxColumn,
            this.idpetugasDataGridViewTextBoxColumn,
            this.tanggalmonitoringDataGridViewTextBoxColumn,
            this.phairDataGridViewTextBoxColumn,
            this.kondisiairDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwMonitoringKualitasAirBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1262, 184);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idmonitoringDataGridViewTextBoxColumn
            // 
            this.idmonitoringDataGridViewTextBoxColumn.DataPropertyName = "id_monitoring";
            this.idmonitoringDataGridViewTextBoxColumn.HeaderText = "id_monitoring";
            this.idmonitoringDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idmonitoringDataGridViewTextBoxColumn.Name = "idmonitoringDataGridViewTextBoxColumn";
            this.idmonitoringDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmonitoringDataGridViewTextBoxColumn.Width = 125;
            // 
            // idlahanDataGridViewTextBoxColumn
            // 
            this.idlahanDataGridViewTextBoxColumn.DataPropertyName = "id_lahan";
            this.idlahanDataGridViewTextBoxColumn.HeaderText = "id_lahan";
            this.idlahanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idlahanDataGridViewTextBoxColumn.Name = "idlahanDataGridViewTextBoxColumn";
            this.idlahanDataGridViewTextBoxColumn.Width = 125;
            // 
            // idirigasiDataGridViewTextBoxColumn
            // 
            this.idirigasiDataGridViewTextBoxColumn.DataPropertyName = "id_irigasi";
            this.idirigasiDataGridViewTextBoxColumn.HeaderText = "id_irigasi";
            this.idirigasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idirigasiDataGridViewTextBoxColumn.Name = "idirigasiDataGridViewTextBoxColumn";
            this.idirigasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpetugasDataGridViewTextBoxColumn
            // 
            this.idpetugasDataGridViewTextBoxColumn.DataPropertyName = "id_petugas";
            this.idpetugasDataGridViewTextBoxColumn.HeaderText = "id_petugas";
            this.idpetugasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpetugasDataGridViewTextBoxColumn.Name = "idpetugasDataGridViewTextBoxColumn";
            this.idpetugasDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalmonitoringDataGridViewTextBoxColumn
            // 
            this.tanggalmonitoringDataGridViewTextBoxColumn.DataPropertyName = "tanggal_monitoring";
            this.tanggalmonitoringDataGridViewTextBoxColumn.HeaderText = "tanggal_monitoring";
            this.tanggalmonitoringDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalmonitoringDataGridViewTextBoxColumn.Name = "tanggalmonitoringDataGridViewTextBoxColumn";
            this.tanggalmonitoringDataGridViewTextBoxColumn.Width = 125;
            // 
            // phairDataGridViewTextBoxColumn
            // 
            this.phairDataGridViewTextBoxColumn.DataPropertyName = "ph_air";
            this.phairDataGridViewTextBoxColumn.HeaderText = "ph_air";
            this.phairDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phairDataGridViewTextBoxColumn.Name = "phairDataGridViewTextBoxColumn";
            this.phairDataGridViewTextBoxColumn.Width = 125;
            // 
            // kondisiairDataGridViewTextBoxColumn
            // 
            this.kondisiairDataGridViewTextBoxColumn.DataPropertyName = "kondisi_air";
            this.kondisiairDataGridViewTextBoxColumn.HeaderText = "kondisi_air";
            this.kondisiairDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kondisiairDataGridViewTextBoxColumn.Name = "kondisiairDataGridViewTextBoxColumn";
            this.kondisiairDataGridViewTextBoxColumn.Width = 125;
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.Width = 125;
            // 
            // monitoringKualitasAirBindingSource
            // 
            this.monitoringKualitasAirBindingSource.DataMember = "MonitoringKualitasAir";
            this.monitoringKualitasAirBindingSource.DataSource = this.dBMonitoringKualitasAirDataSet3;
            // 
            // dBMonitoringKualitasAirDataSet3
            // 
            this.dBMonitoringKualitasAirDataSet3.DataSetName = "DBMonitoringKualitasAirDataSet3";
            this.dBMonitoringKualitasAirDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIDMonitoring
            // 
            this.txtIDMonitoring.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwMonitoringKualitasAirBindingSource, "id_monitoring", true));
            this.txtIDMonitoring.Location = new System.Drawing.Point(140, 25);
            this.txtIDMonitoring.Name = "txtIDMonitoring";
            this.txtIDMonitoring.ReadOnly = true;
            this.txtIDMonitoring.Size = new System.Drawing.Size(100, 22);
            this.txtIDMonitoring.TabIndex = 8;
            this.txtIDMonitoring.TextChanged += new System.EventHandler(this.txtIDMonitoring_TextChanged);
            // 
            // vwMonitoringKualitasAirBindingSource
            // 
            this.vwMonitoringKualitasAirBindingSource.DataMember = "vw_MonitoringKualitasAir";
            this.vwMonitoringKualitasAirBindingSource.DataSource = this.dBMonitoringKualitasAirDataSet4;
            // 
            // dBMonitoringKualitasAirDataSet4
            // 
            this.dBMonitoringKualitasAirDataSet4.DataSetName = "DBMonitoringKualitasAirDataSet4";
            this.dBMonitoringKualitasAirDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPH
            // 
            this.txtPH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwMonitoringKualitasAirBindingSource, "ph_air", true));
            this.txtPH.Location = new System.Drawing.Point(140, 195);
            this.txtPH.Name = "txtPH";
            this.txtPH.Size = new System.Drawing.Size(100, 22);
            this.txtPH.TabIndex = 10;
            this.txtPH.TextChanged += new System.EventHandler(this.txtPH_TextChanged);
            // 
            // btnKoneksi
            // 
            this.btnKoneksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKoneksi.Location = new System.Drawing.Point(432, 30);
            this.btnKoneksi.Name = "btnKoneksi";
            this.btnKoneksi.Size = new System.Drawing.Size(140, 42);
            this.btnKoneksi.TabIndex = 15;
            this.btnKoneksi.Text = "Koneksi Data";
            this.btnKoneksi.UseVisualStyleBackColor = false;
            this.btnKoneksi.Click += new System.EventHandler(this.btnKoneksi_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(432, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 38);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "HapusData";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(432, 169);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 39);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Edit Data";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.Location = new System.Drawing.Point(432, 129);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(140, 34);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Tampilkan Data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSimpan.Location = new System.Drawing.Point(432, 78);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(140, 45);
            this.btnSimpan.TabIndex = 19;
            this.btnSimpan.Text = "Menambah Data";
            this.btnSimpan.UseVisualStyleBackColor = false;
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
            this.txtKeterangan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwMonitoringKualitasAirBindingSource, "keterangan", true));
            this.txtKeterangan.Location = new System.Drawing.Point(140, 260);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(100, 22);
            this.txtKeterangan.TabIndex = 21;
            this.txtKeterangan.TextChanged += new System.EventHandler(this.txtKeterangan_TextChanged);
            // 
            // dptTanggal
            // 
            this.dptTanggal.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vwMonitoringKualitasAirBindingSource, "tanggal_monitoring", true));
            this.dptTanggal.Location = new System.Drawing.Point(140, 162);
            this.dptTanggal.Name = "dptTanggal";
            this.dptTanggal.Size = new System.Drawing.Size(200, 22);
            this.dptTanggal.TabIndex = 22;
            this.dptTanggal.ValueChanged += new System.EventHandler(this.dptTanggal_ValueChanged);
            // 
            // cmbKondisi
            // 
            this.cmbKondisi.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwMonitoringKualitasAirBindingSource, "kondisi_air", true));
            this.cmbKondisi.FormattingEnabled = true;
            this.cmbKondisi.Location = new System.Drawing.Point(140, 228);
            this.cmbKondisi.Name = "cmbKondisi";
            this.cmbKondisi.Size = new System.Drawing.Size(121, 24);
            this.cmbKondisi.TabIndex = 23;
            this.cmbKondisi.SelectedIndexChanged += new System.EventHandler(this.cmbKondisi_SelectedIndexChanged);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(1133, 236);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(140, 46);
            this.btnKembali.TabIndex = 24;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.vwMonitoringKualitasAirBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1318, 27);
            this.bindingNavigator1.TabIndex = 25;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // monitoringKualitasAirTableAdapter
            // 
            this.monitoringKualitasAirTableAdapter.ClearBeforeFill = true;
            // 
            // cmbLahan
            // 
            this.cmbLahan.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwMonitoringKualitasAirBindingSource, "nama_lahan", true));
            this.cmbLahan.FormattingEnabled = true;
            this.cmbLahan.Location = new System.Drawing.Point(140, 55);
            this.cmbLahan.Name = "cmbLahan";
            this.cmbLahan.Size = new System.Drawing.Size(121, 24);
            this.cmbLahan.TabIndex = 26;
            this.cmbLahan.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // cmbPetugas
            // 
            this.cmbPetugas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwMonitoringKualitasAirBindingSource, "nama_petugas", true));
            this.cmbPetugas.FormattingEnabled = true;
            this.cmbPetugas.Location = new System.Drawing.Point(140, 129);
            this.cmbPetugas.Name = "cmbPetugas";
            this.cmbPetugas.Size = new System.Drawing.Size(121, 24);
            this.cmbPetugas.TabIndex = 27;
            // 
            // cmbIrigasi
            // 
            this.cmbIrigasi.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwMonitoringKualitasAirBindingSource, "nama_irigasi", true));
            this.cmbIrigasi.FormattingEnabled = true;
            this.cmbIrigasi.Location = new System.Drawing.Point(140, 95);
            this.cmbIrigasi.Name = "cmbIrigasi";
            this.cmbIrigasi.Size = new System.Drawing.Size(121, 24);
            this.cmbIrigasi.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(432, 263);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 35);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 296);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Cari Data";
            // 
            // btnResetData
            // 
            this.btnResetData.Location = new System.Drawing.Point(589, 212);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(140, 35);
            this.btnResetData.TabIndex = 32;
            this.btnResetData.Text = "Reset";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // btnInjectionMonitoring
            // 
            this.btnInjectionMonitoring.Location = new System.Drawing.Point(589, 171);
            this.btnInjectionMonitoring.Name = "btnInjectionMonitoring";
            this.btnInjectionMonitoring.Size = new System.Drawing.Size(140, 35);
            this.btnInjectionMonitoring.TabIndex = 33;
            this.btnInjectionMonitoring.Text = "Test";
            this.btnInjectionMonitoring.UseVisualStyleBackColor = true;
            this.btnInjectionMonitoring.Click += new System.EventHandler(this.btnInjectionMonitoring_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(634, 106);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(135, 16);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total Data Monitoring";
            // 
            // vw_MonitoringKualitasAirTableAdapter
            // 
            this.vw_MonitoringKualitasAirTableAdapter.ClearBeforeFill = true;
            // 
            // MonitoringKualitasAir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 520);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnInjectionMonitoring);
            this.Controls.Add(this.btnResetData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbIrigasi);
            this.Controls.Add(this.cmbPetugas);
            this.Controls.Add(this.cmbLahan);
            this.Controls.Add(this.bindingNavigator1);
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
            ((System.ComponentModel.ISupportInitialize)(this.monitoringKualitasAirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMonitoringKualitasAirDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMonitoringKualitasAirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMonitoringKualitasAirDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
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
        private DBMonitoringKualitasAirDataSet3 dBMonitoringKualitasAirDataSet3;
        private System.Windows.Forms.BindingSource monitoringKualitasAirBindingSource;
        private DBMonitoringKualitasAirDataSet3TableAdapters.MonitoringKualitasAirTableAdapter monitoringKualitasAirTableAdapter;
        private System.Windows.Forms.ComboBox cmbLahan;
        private System.Windows.Forms.ComboBox cmbPetugas;
        private System.Windows.Forms.ComboBox cmbIrigasi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.Button btnInjectionMonitoring;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmonitoringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idirigasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpetugasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalmonitoringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phairDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kondisiairDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTotal;
        private DBMonitoringKualitasAirDataSet4 dBMonitoringKualitasAirDataSet4;
        private System.Windows.Forms.BindingSource vwMonitoringKualitasAirBindingSource;
        private DBMonitoringKualitasAirDataSet4TableAdapters.vw_MonitoringKualitasAirTableAdapter vw_MonitoringKualitasAirTableAdapter;
    }
}