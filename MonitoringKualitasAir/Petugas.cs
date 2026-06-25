using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MonitoringKualitasAir
{
    public partial class Petugas : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
        "Data Source=LAPTOP-GO2648H1\\DEVITADWI; Initial Catalog=DBMonitoringKualitasAir; Integrated Security=True";

        private string role;

        // Storage Procedure Components
        private BindingSource bindingSource = new BindingSource();
        private DataTable dtPetugas = new DataTable();

        public Petugas()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        public Petugas(string roleUser)
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            role = roleUser;
        }

        private void ConnectDatabase()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                MessageBox.Show("Koneksi berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectDatabase();
        }

        //FORM LOAD
        private void Petugas_Load(object sender, EventArgs e)
        {
            // Menampilkan data awal melalui dataset bawaan
            this.petugasTableAdapter.Fill(this.dBMonitoringKualitasAirDataSet.Petugas);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // PENTING: Menghubungkan bindingNavigator dengan data dari Stored Procedure
            bindingNavigator1.BindingSource = bindingSource;

            // Jalankan pembatasan hak akses terlebih dahulu sebelum memuat data SP
            ApplyRole();

            // Memuat data menggunakan Stored Procedure
            LoadData();
        }

        // ====================================================
        // LOAD DATA (SP SELECT)
        // ====================================================
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetPetugas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            dtPetugas = new DataTable();
                            da.Fill(dtPetugas);

                            bindingSource.DataSource = dtPetugas;
                            dataGridView1.DataSource = bindingSource;

                            BindControls();
                        }
                    }
                }

                // COUNT OUTPUT
                HitungTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

        // ====================================================
        // BIND CONTROLS
        // ====================================================
        private void BindControls()
        {
            txtIDPetugas.DataBindings.Clear();
            txtNamaPetugas.DataBindings.Clear();
            txtNoHP.DataBindings.Clear();

            txtIDPetugas.DataBindings.Add("Text", bindingSource, "ID_Petugas");
            txtNamaPetugas.DataBindings.Add("Text", bindingSource, "Nama_Petugas");
            txtNoHP.DataBindings.Add("Text", bindingSource, "No_HP");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 1. Validasi Input Kosong
            if (string.IsNullOrWhiteSpace(txtNamaPetugas.Text) || string.IsNullOrWhiteSpace(txtNoHP.Text))
            {
                MessageBox.Show("Nama Petugas dan Nomor HP tidak boleh kosong!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validasi Hanya Huruf dan Spasi untuk Nama Petugas
            if (!Regex.IsMatch(txtNamaPetugas.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Gagal menyimpan! Nama petugas hanya boleh berisi huruf dan spasi (tidak boleh mengandung angka atau simbol).",
                                "Format Nama Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaPetugas.Focus();
                return;
            }

            // 3. Validasi Hanya Angka dan Panjang Karakter untuk No HP
            if (!Regex.IsMatch(txtNoHP.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Gagal menyimpan! Nomor HP hanya boleh berisi angka.",
                                "Format No HP Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoHP.Focus();
                return;
            }

            if (txtNoHP.Text.Length < 10 || txtNoHP.Text.Length > 15)
            {
                MessageBox.Show("Gagal menyimpan! Panjang Nomor HP harus di antara 10 sampai 15 digit.",
                                "Format No HP Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoHP.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertPetugas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nama_Petugas", txtNamaPetugas.Text);
                        cmd.Parameters.AddWithValue("@No_HP", txtNoHP.Text);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data berhasil ditambahkan");
                            ClearForm();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Data gagal ditambahkan");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 1. Validasi pastikan ID Petugas dan data lainnya tidak kosong
            if (string.IsNullOrWhiteSpace(txtIDPetugas.Text))
            {
                MessageBox.Show("Silakan pilih atau tentukan ID Petugas yang akan diubah terlebih dahulu!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNamaPetugas.Text) || string.IsNullOrWhiteSpace(txtNoHP.Text))
            {
                MessageBox.Show("Nama Petugas dan Nomor HP tidak boleh dikosongkan!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validasi format Nama Petugas (Hanya Huruf dan Spasi)
            if (!Regex.IsMatch(txtNamaPetugas.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Gagal memperbarui data! Nama petugas hanya boleh berisi huruf dan spasi (tidak boleh ada angka atau simbol).",
                                "Format Nama Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaPetugas.Focus();
                return;
            }

            // 3. Validasi format Nomor HP (Hanya Angka dan Panjang 10-15 digit)
            if (!Regex.IsMatch(txtNoHP.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Gagal memperbarui data! Nomor HP hanya boleh berisi angka.",
                                "Format No HP Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoHP.Focus();
                return;
            }

            if (txtNoHP.Text.Length < 10 || txtNoHP.Text.Length > 15)
            {
                MessageBox.Show("Gagal memperbarui data! Panjang Nomor HP harus di antara 10 sampai 15 digit.",
                                "Format No HP Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoHP.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_UpdatePetugas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_Petugas", txtIDPetugas.Text);
                        cmd.Parameters.AddWithValue("@Nama_Petugas", txtNamaPetugas.Text);
                        cmd.Parameters.AddWithValue("@No_HP", txtNoHP.Text);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data berhasil diupdate");
                            ClearForm();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultConfirm = MessageBox.Show(
                    "Yakin ingin menghapus data?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultConfirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_DeletePetugas", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID_Petugas", txtIDPetugas.Text);

                            conn.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Data berhasil dihapus");
                                ClearForm();
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Data tidak ditemukan");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtIDPetugas.Clear();
            txtNamaPetugas.Clear();
            txtNoHP.Clear();

            txtIDPetugas.Focus();
        }

        // ====================================================
        // TOMBOL KEMBALI KE DASHBOARD
        // ====================================================
        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Melempar kembali data role ke Dashboard agar hak akses menu tetap terjaga
            Dashboard f = new Dashboard(role);
            f.Show();
            this.Close(); // Menggunakan Close() agar memori form ini langsung dibersihkan
        }

        // ====================================================
        // MANAJEMEN HAK AKSES ROLE USER
        // ====================================================
        private void ApplyRole()
        {
            // Menggunakan StringComparison agar pengecekan huruf kapital "petugas" / "Petugas" aman
            if (role != null && role.Equals("petugas", StringComparison.OrdinalIgnoreCase))
            {
                // Matikan Tombol CRUD untuk Petugas (Hanya Admin yang bisa kelola data Petugas)
                btnInsert.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                // Mematikan inputan textbox agar petugas tidak bisa iseng mengetik data
                txtNamaPetugas.Enabled = false;
                txtNoHP.Enabled = false;

                this.Text = "Monitoring Kualitas Air - Data Petugas (Mode View / Petugas)";
            }
            else
            {
                // Jika login sebagai Admin, aktifkan semua fitur penuh
                btnInsert.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                txtNamaPetugas.Enabled = true;
                txtNoHP.Enabled = true;

                this.Text = "Monitoring Kualitas Air - Data Petugas (Mode CRUD / Admin)";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtIDPetugas.Text = row.Cells[0].Value.ToString();
                txtNamaPetugas.Text = row.Cells[1].Value.ToString();
                txtNoHP.Text = row.Cells[2].Value.ToString();
            }
        }

        // Menghitung total data menggunakan SP Output Parameter
        private void HitungTotal()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CountPetugas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputParam = new SqlParameter("@Total", SqlDbType.Int);
                        outputParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputParam);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        lblTotal.Text = "Total Petugas : " + outputParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghitung total: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
        }
    }
}