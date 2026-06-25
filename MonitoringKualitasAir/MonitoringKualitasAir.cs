using System;

using System.Data;

using System.Data.SqlClient;

using System.Drawing;

using System.Text.RegularExpressions;

using System.Windows.Forms;

using ExcelDataReader;

using System.IO;

using System.Data;





namespace MonitoringKualitasAir

{

    public partial class MonitoringKualitasAir : Form

    {

        SqlConnection conn;

        byte[] imageBytes = null; // <-- Tambahkan variabel global ini



        private string role;



        // Ubah constructor utamanya agar menerima parameter string roleUser

        public MonitoringKualitasAir(string roleUser)

        {

            InitializeComponent();

            role = roleUser;

            conn = new SqlConnection(

            "Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True");

        }



        private BindingSource bindingSource = new BindingSource();

        private DataTable dtMonitoring = new DataTable();



        // LOAD COMBOBOX LAHAN

        private void LoadLahan()

        {

            SqlDataAdapter da = new SqlDataAdapter(

              "SELECT id_lahan, nama_lahan FROM Lahan", conn);



            DataTable dt = new DataTable();

            da.Fill(dt);



            cmbLahan.DataSource = dt;

            cmbLahan.DisplayMember = "nama_lahan";

            cmbLahan.ValueMember = "id_lahan";



            cmbLahan.SelectedIndex = -1;

        }





        // LOAD COMBOBOX IRIGASI

        private void LoadIrigasi()

        {

            SqlDataAdapter da = new SqlDataAdapter(

              "SELECT id_irigasi, nama_irigasi FROM Irigasi", conn);



            DataTable dt = new DataTable();

            da.Fill(dt);



            cmbIrigasi.DataSource = dt;

            cmbIrigasi.DisplayMember = "nama_irigasi";

            cmbIrigasi.ValueMember = "id_irigasi";



            cmbIrigasi.SelectedIndex = -1;

        }



        // LOAD COMBOBOX PETUGAS

        private void LoadPetugas()

        {

            SqlDataAdapter da = new SqlDataAdapter(

              "SELECT id_petugas, nama_petugas FROM Petugas", conn);



            DataTable dt = new DataTable();

            da.Fill(dt);



            cmbPetugas.DataSource = dt;

            cmbPetugas.DisplayMember = "nama_petugas";

            cmbPetugas.ValueMember = "id_petugas";



            cmbPetugas.SelectedIndex = -1;

        }



        // ================= LOAD =================

        private void MonitoringKualitasAir_Load(object sender, EventArgs e)

        {

            // TODO: This line of code loads data into the 'dBMonitoringKualitasAirDataSet4.vw_MonitoringKualitasAir' table. You can move, or remove it, as needed.

            //this.vw_MonitoringKualitasAirTableAdapter.Fill(this.dBMonitoringKualitasAirDataSet4.vw_MonitoringKualitasAir);

            dptTanggal.MaxDate = DateTime.Today;



            cmbKondisi.Items.Add("Asam");

            cmbKondisi.Items.Add("Netral");

            cmbKondisi.Items.Add("Basa");



            txtIDMonitoring.ReadOnly = true;



            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;



            dataGridView1.CellClick += dataGridView1_CellContentClick;



            // TAMBAHAN

            bindingNavigator1.BindingSource = bindingSource;



            LoadLahan();

            LoadIrigasi();

            LoadPetugas();



            btnImportDatabase.Enabled = false;



            LoadData();

            // Tambahkan baris ini di dalam fungsi Load biar semua foto otomatis pas di kotak

            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;

            // Paksa semua gambar di kolom "foto" DataGridView agar otomatis mengecil pas dengan ukuran sel

            ((DataGridViewImageColumn)dataGridView1.Columns["foto"]).ImageLayout = DataGridViewImageCellLayout.Zoom;



            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;

        }



        // ================= FIX FOTO DI GRID BIAR GAK ZOOM =================

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)

        {

            // Cek apakah kolom bernama "foto" ada di dalam DataGridView

            if (dataGridView1.Columns.Contains("foto"))

            {

                // Paksa kolom foto menggunakan mode Zoom secara permanen

                ((DataGridViewImageColumn)dataGridView1.Columns["foto"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            }

        }



        private void LoadData()

        {

            try

            {

                using (SqlConnection conn = new SqlConnection(

                  "Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True"))

                {

                    conn.Open();



                    SqlDataAdapter da = new SqlDataAdapter(

                      "SELECT * FROM vw_MonitoringKualitasAir",

                      conn);



                    dtMonitoring = new DataTable();



                    da.Fill(dtMonitoring);



                    bindingSource.DataSource = dtMonitoring;



                    // RESET GRID

                    dataGridView1.DataSource = null;

                    dataGridView1.Columns.Clear();



                    dataGridView1.AutoGenerateColumns = true;



                    dataGridView1.DataSource = bindingSource;



                    BindControls();

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Load error: " + ex.Message);

            }



            HitungTotal();

        }



        private void BindControls()

        {

            txtIDMonitoring.DataBindings.Clear();

            txtPH.DataBindings.Clear();

            txtKeterangan.DataBindings.Clear();



            cmbLahan.DataBindings.Clear();

            cmbIrigasi.DataBindings.Clear();

            cmbPetugas.DataBindings.Clear();

            cmbKondisi.DataBindings.Clear();



            dptTanggal.DataBindings.Clear();



            // PERBAIKAN: Tambahkan parameter "true, DataSourceUpdateMode.Never"

            // Ini mencegah form me-reset nilai yang salah menjadi nilai awal secara otomatis

            txtIDMonitoring.DataBindings.Add("Text", bindingSource, "id_monitoring", true, DataSourceUpdateMode.Never);

            txtPH.DataBindings.Add("Text", bindingSource, "ph_air", true, DataSourceUpdateMode.Never);

            txtKeterangan.DataBindings.Add("Text", bindingSource, "keterangan", true, DataSourceUpdateMode.Never);



            cmbLahan.DataBindings.Add("Text", bindingSource, "nama_lahan", true, DataSourceUpdateMode.Never);

            cmbIrigasi.DataBindings.Add("Text", bindingSource, "nama_irigasi", true, DataSourceUpdateMode.Never);

            cmbPetugas.DataBindings.Add("Text", bindingSource, "nama_petugas", true, DataSourceUpdateMode.Never);

            cmbKondisi.DataBindings.Add("Text", bindingSource, "kondisi_air", true, DataSourceUpdateMode.Never);



            dptTanggal.DataBindings.Add("Value", bindingSource, "tanggal_monitoring", true, DataSourceUpdateMode.Never);

        }





        // ================= KONEKSI =================

        private void btnKoneksi_Click(object sender, EventArgs e)

        {

            try

            {

                conn.Open();

                MessageBox.Show("Koneksi berhasil");

                conn.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show("Koneksi gagal: " + ex.Message);

            }

        }



        // ================= SIMPAN  =================

        // ================= SIMPAN  =================

        // ================= SIMPAN  =================

        private void btnSimpan_Click(object sender, EventArgs e)

        {

            // 1. Validasi ComboBox (Pastikan user sudah memilih data)

            if (cmbLahan.SelectedIndex == -1 || cmbIrigasi.SelectedIndex == -1 || cmbPetugas.SelectedIndex == -1)

            {

                MessageBox.Show("Gagal menyimpan! Silakan pilih Lahan, Irigasi, dan Petugas terlebih dahulu dari pilihan yang tersedia.",

                                "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            // 2. Validasi Input Kosong untuk Teks Box Utama

            if (string.IsNullOrWhiteSpace(txtPH.Text) || cmbKondisi.SelectedIndex == -1)

            {

                MessageBox.Show("Kolom pH Air dan Kondisi Air wajib diisi/dipilih!",

                                "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            // 3. Validasi Nilai desimal pH Air

            decimal phAir;

            string phInput = txtPH.Text.Replace('.', ',');

            bool isDecimal = decimal.TryParse(phInput, out phAir);



            if (!isDecimal)

            {

                MessageBox.Show("Gagal menyimpan! Format pH Air harus berupa angka desimal (contoh: 7,20).",

                                "Format pH Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtPH.Focus();

                return;

            }



            if (phAir < 0 || phAir > 14)

            {

                MessageBox.Show("Gagal menyimpan! Nilai pH air harus berada di rentang angka 0 sampai 14.",

                                "Nilai pH Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtPH.Focus();

                return;

            }



            // 4. Validasi Pilihan Kondisi Air

            string kondisiTerpilih = cmbKondisi.SelectedItem.ToString();

            if (kondisiTerpilih != "Asam" && kondisiTerpilih != "Netral" && kondisiTerpilih != "Basa")

            {

                MessageBox.Show("Gagal menyimpan! Pilihan Kondisi Air hanya boleh 'Asam', 'Netral', atau 'Basa'.",

                                "Pilihan Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            // 5. Validasi Panjang Teks Keterangan

            if (txtKeterangan.Text.Length > 100)

            {

                MessageBox.Show("Gagal menyimpan! Isi keterangan terlalu panjang (Maksimal 100 karakter).",

                                "Teks Terlalu Panjang", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtKeterangan.Focus();

                return;

            }



            // ================= PROSES SIMPAN DATA =================

            try

            {

                conn.Open();



                SqlCommand cmd = new SqlCommand("sp_InsertMonitoring", conn);

                cmd.CommandType = CommandType.StoredProcedure;



                cmd.Parameters.AddWithValue("@ID_Lahan", cmbLahan.SelectedValue);

                cmd.Parameters.AddWithValue("@ID_Irigasi", cmbIrigasi.SelectedValue);

                cmd.Parameters.AddWithValue("@ID_Petugas", cmbPetugas.SelectedValue);

                cmd.Parameters.AddWithValue("@Tanggal_Monitoring", dptTanggal.Value);

                cmd.Parameters.AddWithValue("@PH_Air", phAir);

                cmd.Parameters.AddWithValue("@Kondisi_Air", kondisiTerpilih);

                cmd.Parameters.AddWithValue("@Keterangan", txtKeterangan.Text);



                // 🔥 PERBAIKAN FORMAT PARAMETER FOTO DISINI 🔥

                if (imageBytes != null)

                {

                    cmd.Parameters.Add("@pFoto", SqlDbType.VarBinary).Value = imageBytes;

                }

                else

                {

                    cmd.Parameters.Add("@pFoto", SqlDbType.VarBinary).Value = DBNull.Value;

                }



                cmd.ExecuteNonQuery();

                conn.Close();



                MessageBox.Show("Data monitoring kualitas air berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);



                if (btnLoad != null) btnLoad.PerformClick();



                ClearForm();

            }



            catch (SqlException ex)

            {

                SimpanLog(ex.Message);



                MessageBox.Show("SQL Error : " + ex.Message);

            }

            catch (Exception ex)

            {

                SimpanLog(ex.Message);



                MessageBox.Show("General Error : " + ex.Message);

            }

        }



        // ================= LOAD DATA =================

        private void btnLoad_Click(object sender, EventArgs e)

        {

            LoadData();

        }





        // ================= UPDATE (FIX TYPE) =================

        // ================= UPDATE =================

        // ================= UPDATE =================

        // ================= UPDATE DATA FIXED =================

        // ================= UPDATE DATA FIXED =================

        // ================= UPDATE DATA FIXED TOTAL =================

        // ================= UPDATE DATA FIXED (SESUAI DATABASE) =================

        private void btnUpdate_Click(object sender, EventArgs e)

        {

            if (string.IsNullOrWhiteSpace(txtIDMonitoring.Text))

            {

                MessageBox.Show("Silakan pilih data dari tabel terlebih dahulu!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            decimal phAir;

            string phInput = txtPH.Text.Replace('.', ',');

            if (!decimal.TryParse(phInput, out phAir))

            {

                MessageBox.Show("Format pH Air harus berupa angka!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            int indexLahan = cmbLahan.FindStringExact(cmbLahan.Text);

            int indexIrigasi = cmbIrigasi.FindStringExact(cmbIrigasi.Text);

            int indexPetugas = cmbPetugas.FindStringExact(cmbPetugas.Text);



            if (indexLahan != -1) cmbLahan.SelectedIndex = indexLahan;

            if (indexIrigasi != -1) cmbIrigasi.SelectedIndex = indexIrigasi;

            if (indexPetugas != -1) cmbPetugas.SelectedIndex = indexPetugas;



            try

            {

                if (conn.State == ConnectionState.Open) conn.Close();

                conn.Open();



                SqlCommand cmd = new SqlCommand("sp_UpdateMonitoring", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();



                // Mengirim 9 parameter lengkap seirama dengan database sekarang

                cmd.Parameters.AddWithValue("@ID_Monitoring", Convert.ToInt32(txtIDMonitoring.Text));

                cmd.Parameters.AddWithValue("@ID_Lahan", cmbLahan.SelectedValue);

                cmd.Parameters.AddWithValue("@ID_Irigasi", cmbIrigasi.SelectedValue);

                cmd.Parameters.AddWithValue("@ID_Petugas", cmbPetugas.SelectedValue);

                cmd.Parameters.AddWithValue("@Tanggal_Monitoring", dptTanggal.Value);

                cmd.Parameters.AddWithValue("@PH_Air", phAir);

                cmd.Parameters.AddWithValue("@Kondisi_Air", cmbKondisi.Text);

                cmd.Parameters.AddWithValue("@Keterangan", txtKeterangan.Text);



                // Parameter ke-9: Foto aman

                if (imageBytes != null && imageBytes.Length > 0)

                {

                    cmd.Parameters.Add("@pFoto", SqlDbType.VarBinary).Value = imageBytes;

                }

                else

                {

                    cmd.Parameters.Add("@pFoto", SqlDbType.VarBinary).Value = DBNull.Value;

                }



                cmd.ExecuteNonQuery();

                conn.Close();



                MessageBox.Show("Data dan Foto berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);



                LoadData();

                ClearForm();

            }

            catch (Exception ex)

            {

                if (conn.State == ConnectionState.Open) conn.Close();

                MessageBox.Show("Update error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        // ================= DELETE =================

        private void btnDelete_Click(object sender, EventArgs e)

        {

            try

            {

                if (conn.State == ConnectionState.Open)

                    conn.Close();



                conn.Open();



                SqlCommand cmd = new SqlCommand("sp_DeleteMonitoring", conn);

                cmd.CommandType = CommandType.StoredProcedure;



                cmd.Parameters.AddWithValue("@ID_Monitoring", txtIDMonitoring.Text);



                cmd.ExecuteNonQuery();



                conn.Close();



                MessageBox.Show("Data berhasil dihapus");

                ClearForm();

                btnLoad.PerformClick();

            }

            catch (Exception ex)

            {

                conn.Close();



                MessageBox.Show("Delete error: " + ex.Message);

            }

        }



        private void ClearForm()

        {

            txtIDMonitoring.Clear();



            cmbLahan.SelectedIndex = -1;

            cmbIrigasi.SelectedIndex = -1;

            cmbPetugas.SelectedIndex = -1;



            txtPH.Clear();



            cmbKondisi.SelectedIndex = -1;



            txtKeterangan.Clear();



            dptTanggal.Value = DateTime.Today;



            txtIDMonitoring.Focus();



            // ... kode clear kamu yang lain ...

            txtKeterangan.Clear();



            // 🛠️ Reset komponen foto

            if (pbFoto.Image != null)

            {

                pbFoto.Image.Dispose();

                pbFoto.Image = null;

            }

            imageBytes = null; // Kembalikan ke null



            dptTanggal.Value = DateTime.Today;

            txtIDMonitoring.Focus();

        }



        // ================= CLICK GRID (AUTO FILL) =================

        // ================= CLICK GRID (AUTO FILL) =================

        // ================= CLICK GRID (AUTO FILL FIXED) =================

        // ================= CLICK GRID (ANTI ERROR KOLOM ID) =================

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex < 0) return;



            bindingSource.Position = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];



            // 1. Ambil data teks utama

            txtIDMonitoring.Text = row.Cells["id_monitoring"].Value.ToString();

            txtPH.Text = row.Cells["ph_air"].Value.ToString();

            txtKeterangan.Text = row.Cells["keterangan"].Value.ToString();



            // 2. Set pilihan ComboBox berdasarkan TEXT nama yang tampil di grid/view

            cmbLahan.Text = row.Cells["nama_lahan"].Value.ToString();

            cmbIrigasi.Text = row.Cells["nama_irigasi"].Value.ToString();

            cmbPetugas.Text = row.Cells["nama_petugas"].Value.ToString();

            cmbKondisi.Text = row.Cells["kondisi_air"].Value.ToString();



            if (row.Cells["tanggal_monitoring"].Value != DBNull.Value)

            {

                dptTanggal.Value = Convert.ToDateTime(row.Cells["tanggal_monitoring"].Value);

            }



            // 3. Ambil data biner foto dari tabel database

            if (row.Cells["foto"].Value != DBNull.Value && row.Cells["foto"].Value != null)

            {

                byte[] fotoBytes = (byte[])row.Cells["foto"].Value;

                imageBytes = fotoBytes; // Simpan ke variabel global



                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(fotoBytes))

                {

                    pbFoto.Image = new Bitmap(ms);

                }

            }

            else

            {

                pbFoto.Image = null;

                imageBytes = null;

            }

        }

        // ================= EMPTY EVENTS =================
        private void txtIDMonitoring_TextChanged(object sender, EventArgs e) { }
        private void dptTanggal_ValueChanged(object sender, EventArgs e) { }
        private void txtPH_TextChanged(object sender, EventArgs e) { }
        private void cmbKondisi_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtKeterangan_TextChanged(object sender, EventArgs e) { }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Dashboard f = new Dashboard(role);
            f.Show();
            this.Close();
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True"))
                {
                    conn.Open();
                    // Query dibuat rentan (menggabungkan string secara langsung) agar bisa di-inject
                    string query = "SELECT * FROM vw_MonitoringKualitasAir WHERE keterangan LIKE '%" + txtSearch.Text.Trim() + "%'";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dtSearch = new DataTable();
                    da.Fill(dtSearch);

                    bindingSource.DataSource = dtSearch;
                    dataGridView1.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInjectionMonitoring_Click(object sender, EventArgs e)
        {
            string inputCari = txtSearch.Text.Trim();

            // Deteksi apakah user memasukkan trik SQL Injection OR
            if (inputCari.ToLower().Contains("' or") || inputCari.Contains("1=1"))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True"))
                    {
                        conn.Open();

                        // MENGUBAH NAMA PETUGAS MENJADI 'HACKED'
                        string query = "UPDATE Petugas SET nama_petugas = 'HACKED'";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            int rows = cmd.ExecuteNonQuery();
                            MessageBox.Show("SQL Injection Berhasil! " + rows + " data petugas berhasil dimanipulasi.", "Hacked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    btnLoad.PerformClick(); // Refresh Grid data untuk melihat hasil relasi view-nya
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error simulasi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Simulasi Gagal. Kamu harus memasukkan query injection (misal: ' OR '1'='1) pada kotak Cari Data terlebih dahulu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True"))
                {
                    conn.Open();
                    string query = @"
                UPDATE Petugas SET nama_petugas = nama_asli WHERE nama_asli IS NOT NULL;
                
                UPDATE MonitoringKualitasAir
                SET keterangan = CASE 
                                    WHEN id_monitoring = 1 THEN 'Air jernih'
                                    WHEN id_monitoring = 2 THEN 'Sedikit keruh'
                                    ELSE '-' 
                                 END,
                    ph_air = CASE 
                                WHEN id_monitoring = 1 THEN 7.20
                                WHEN id_monitoring = 2 THEN 6.80
                                ELSE 7.0 
                             END;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data sukses direset ke kondisi semula.", "Reset Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                btnLoad.PerformClick(); // Refresh tampilan grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reset gagal: " + ex.Message);
            }
        }

        private void HitungTotal()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(
                 "Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True"))
                {
                    using (SqlCommand cmd =
                     new SqlCommand("sp_CountMonitoring", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputParam =
                         new SqlParameter("@Total", SqlDbType.Int);

                        outputParam.Direction =
                         ParameterDirection.Output;

                        cmd.Parameters.Add(outputParam);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        lblTotal.Text =
                         "Total Monitoring : " +
                         outputParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                 "Gagal menghitung total : " + ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Menyaring file agar hanya menampilkan format gambar
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png)|*.jpg; *.jpeg; *.gif; *.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // 1. Tampilkan pratinjau gambar di PictureBox (pastikan namanya pbFoto)
                    pbFoto.Image = new Bitmap(ofd.FileName);

                    // 2. Ubah file gambar fisik menjadi biner byte[] sesuai modul praktikum
                    // Ganti baris yang merah dengan kode lengkap di bawah ini:
                    imageBytes = System.IO.File.ReadAllBytes(ofd.FileName);
                }
            }
        }

        private void btnRekap_Click(object sender, EventArgs e)
        {
            // Kirim variabel role ke FormRekapMonitoring
            FormRekapMonitoring frmRekap = new FormRekapMonitoring(role);
            frmRekap.Show();
            this.Hide();
        }

        //UCP 3
        private void SimpanLog(string pesan)
        {
            using (SqlConnection conn =
              new SqlConnection(
              "Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True"))
            {
                string query = @"
        INSERT INTO LogError
        (
            waktu,
            pesan_error
        )
        VALUES
        (
            GETDATE(),
            @pesan
        )";

                using (SqlCommand cmd =
                  new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pesan", pesan);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Excel Files|*.xlsx;*.xls" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });

                            // 1. Cek apakah ada data
                            if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
                            {
                                // 2. Tampilkan ke Grid
                                dataGridView1.DataSource = result.Tables[0];

                                // 3. Aktifkan tombol import DB
                                btnImportDatabase.Enabled = true;
                                MessageBox.Show("Data berhasil dibaca! Sekarang klik tombol Import Database untuk menyimpan ke SQL.");
                            }
                            else
                            {
                                MessageBox.Show("File Excel kosong! Pastikan ada baris data di bawah header.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal membaca Excel: " + ex.Message);
                    }
                }
            }
        }
        private void btnImportDatabase_Click(object sender, EventArgs e)
        {
            // 1. Ambil data dari Grid hasil pembacaan Excel
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Tidak ada data yang bisa diimport! Silakan pilih file Excel terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = (DataTable)dataGridView1.DataSource;
            int suksesCount = 0;
            int gagalCount = 0;

            // 2. Loop setiap baris data dari Excel untuk dikirim ke SQL Server
            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True"))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("sp_InsertMonitoring", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Mengirimkan parameter ke Stored Procedure sesuai isi baris Excel
                            cmd.Parameters.AddWithValue("@ID_Lahan", Convert.ToInt32(row["id_lahan"]));
                            cmd.Parameters.AddWithValue("@ID_Irigasi", Convert.ToInt32(row["id_irigasi"]));
                            cmd.Parameters.AddWithValue("@ID_Petugas", Convert.ToInt32(row["id_petugas"]));
                            cmd.Parameters.AddWithValue("@Tanggal_Monitoring", DateTime.Parse(row["tanggal"].ToString()));
                            cmd.Parameters.AddWithValue("@PH_Air", decimal.Parse(row["ph_air"].ToString().Replace('.', ',')));
                            cmd.Parameters.AddWithValue("@Kondisi_Air", row["kondisi_air"].ToString());
                            cmd.Parameters.AddWithValue("@Keterangan", "Import Excel");

                            // FIX: Set kolom foto default kosong untuk data massal dari Excel (Menyelesaikan kode Anda yang terpotong)
                            cmd.Parameters.Add("@pFoto", SqlDbType.VarBinary).Value = DBNull.Value;

                            cmd.ExecuteNonQuery();
                            suksesCount++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    gagalCount++;
                    SimpanLog("Import Excel Error: " + ex.Message);
                }
            }

            // 3. Notifikasi hasil dan refresh grid kembali ke database asli
            MessageBox.Show($"Proses Import Selesai!\nData Berhasil Masuk: {suksesCount}\nData Gagal: {gagalCount}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnImportDatabase.Enabled = false;
            LoadData(); // Menampilkan kembali data dari SQL Server ke Grid
        }

    }
}
