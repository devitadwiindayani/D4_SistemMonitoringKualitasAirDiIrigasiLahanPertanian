using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MonitoringKualitasAir
{
    public partial class Lahan : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
        "Data Source=LAPTOP-GO2648H1\\DEVITADWI; Initial Catalog=DBMonitoringKualitasAir; Integrated Security=True";

        private string role;

        // ====================================================
        // MODUL STORED PROCEDURE
        // ====================================================
        private BindingSource bindingSource = new BindingSource();
        private DataTable dtLahan = new DataTable();

        public Lahan()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        public Lahan(string roleUser)
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            role = roleUser;
        }

        private void ConnectDatabase()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
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

        private void Lahan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBMonitoringKualitasAirDataSet1.Lahan' table. You can move, or remove it, as needed.
            this.lahanTableAdapter.Fill(this.dBMonitoringKualitasAirDataSet1.Lahan);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.CellClick += dataGridView1_CellClick;

            // TAMBAHAN PENTING
            bindingNavigator1.BindingSource = bindingSource;

            ApplyRole();

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetLahan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            dtLahan = new DataTable();

                            da.Fill(dtLahan);

                            bindingSource.DataSource = dtLahan;
                            dataGridView1.DataSource = bindingSource;

                            BindControls();
                        }
                    }
                }

                HitungTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

        private void BindControls()
        {
            txtIDLahan.DataBindings.Clear();
            txtNamaLahan.DataBindings.Clear();
            txtLokasi.DataBindings.Clear();
            txtLuasLahan.DataBindings.Clear();

            txtIDLahan.DataBindings.Add("Text", bindingSource, "ID_Lahan");
            txtNamaLahan.DataBindings.Add("Text", bindingSource, "Nama_Lahan");
            txtLokasi.DataBindings.Add("Text", bindingSource, "Lokasi");
            txtLuasLahan.DataBindings.Add("Text", bindingSource, "Luas_Lahan");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 1. Validasi Input Kosong
            if (string.IsNullOrWhiteSpace(txtNamaLahan.Text) ||
                string.IsNullOrWhiteSpace(txtLokasi.Text) ||
                string.IsNullOrWhiteSpace(txtLuasLahan.Text))
            {
                MessageBox.Show("Semua kolom (Nama Lahan, Lokasi, Luas Lahan) wajib diisi!",
                                "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validasi Nama Lahan (Hanya Huruf, Angka, dan Spasi)
            // Sesuai dengan revisi constraint CK_NamaLahan: NOT LIKE '%[^A-Za-z0-9 ]%'
            if (!Regex.IsMatch(txtNamaLahan.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Gagal menyimpan! Nama lahan hanya boleh berisi huruf, angka, dan spasi.",
                                "Format Nama Lahan Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaLahan.Focus();
                return;
            }

            // 3. Validasi Lokasi Lahan (Hanya Huruf dan Spasi)
            // Sesuai dengan constraint bawaan: NOT LIKE '%[^A-Za-z ]%'
            if (!Regex.IsMatch(txtLokasi.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Gagal menyimpan! Lokasi hanya boleh berisi huruf dan spasi (tidak boleh ada angka/simbol).",
                                "Format Lokasi Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLokasi.Focus();
                return;
            }

            // 4. Validasi Luas Lahan (Harus Angka dan Harus > 0)
            // Sesuai dengan constraint: CHECK (luas_lahan > 0)
            int luasLahan;
            bool isAngka = int.TryParse(txtLuasLahan.Text, out luasLahan);

            if (!isAngka)
            {
                MessageBox.Show("Gagal menyimpan! Luas lahan harus berupa angka bulat utuh.",
                                "Format Luas Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuasLahan.Focus();
                return;
            }

            if (luasLahan <= 0)
            {
                MessageBox.Show("Gagal menyimpan! Luas lahan harus lebih besar dari 0.",
                                "Nilai Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuasLahan.Focus();
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertLahan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nama_Lahan", txtNamaLahan.Text);
                        cmd.Parameters.AddWithValue("@Lokasi", txtLokasi.Text);
                        cmd.Parameters.AddWithValue("@Luas_Lahan", txtLuasLahan.Text);

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

                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
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
            // 1. Validasi Input Kosong
            if (string.IsNullOrWhiteSpace(txtNamaLahan.Text) ||
                string.IsNullOrWhiteSpace(txtLokasi.Text) ||
                string.IsNullOrWhiteSpace(txtLuasLahan.Text))
            {
                MessageBox.Show("Semua kolom (Nama Lahan, Lokasi, Luas Lahan) wajib diisi!",
                                "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validasi Nama Lahan (Hanya Huruf, Angka, dan Spasi)
            // Sesuai dengan revisi constraint CK_NamaLahan: NOT LIKE '%[^A-Za-z0-9 ]%'
            if (!Regex.IsMatch(txtNamaLahan.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Gagal menyimpan! Nama lahan hanya boleh berisi huruf, angka, dan spasi.",
                                "Format Nama Lahan Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaLahan.Focus();
                return;
            }

            // 3. Validasi Lokasi Lahan (Hanya Huruf dan Spasi)
            // Sesuai dengan constraint bawaan: NOT LIKE '%[^A-Za-z ]%'
            if (!Regex.IsMatch(txtLokasi.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Gagal menyimpan! Lokasi hanya boleh berisi huruf dan spasi (tidak boleh ada angka/simbol).",
                                "Format Lokasi Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLokasi.Focus();
                return;
            }

            // 4. Validasi Luas Lahan (Harus Angka dan Harus > 0)
            // Sesuai dengan constraint: CHECK (luas_lahan > 0)
            int luasLahan;
            bool isAngka = int.TryParse(txtLuasLahan.Text, out luasLahan);

            if (!isAngka)
            {
                MessageBox.Show("Gagal menyimpan! Luas lahan harus berupa angka bulat utuh.",
                                "Format Luas Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuasLahan.Focus();
                return;
            }

            if (luasLahan <= 0)
            {
                MessageBox.Show("Gagal menyimpan! Luas lahan harus lebih besar dari 0.",
                                "Nilai Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuasLahan.Focus();
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_UpdateLahan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_Lahan", txtIDLahan.Text);
                        cmd.Parameters.AddWithValue("@Nama_Lahan", txtNamaLahan.Text);
                        cmd.Parameters.AddWithValue("@Lokasi", txtLokasi.Text);
                        cmd.Parameters.AddWithValue("@Luas_Lahan", txtLuasLahan.Text);

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

                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
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
                        using (SqlCommand cmd = new SqlCommand("sp_DeleteLahan", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@ID_Lahan", txtIDLahan.Text);

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

                            if (conn.State == ConnectionState.Open)
                            {
                                conn.Close();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtIDLahan.Text = row.Cells[0].Value.ToString();
                txtNamaLahan.Text = row.Cells[1].Value.ToString();
                txtLokasi.Text = row.Cells[2].Value.ToString();
                txtLuasLahan.Text = row.Cells[3].Value.ToString();
            }

        }

        private void ClearForm()
        {
            txtIDLahan.Clear();
            txtNamaLahan.Clear();
            txtLokasi.Clear();
            txtLuasLahan.Clear();

            txtIDLahan.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kirim balik variabel role saat kembali ke Dashboard agar menu di dashboard tidak error
            Dashboard f = new Dashboard(role);
            f.Show();
            this.Close();
        }

        // referensi gpt
        private void ApplyRole()
        {
            // Pastikan pengecekan tidak sensitif huruf besar/kecil (petugas / Petugas)
            if (role != null && role.Equals("petugas", StringComparison.OrdinalIgnoreCase))
            {
                // Nonaktifkan tombol CRUD untuk Petugas (Hanya bisa baca data)
                btnInsert.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                // Jika di Form ini ada tombol "Import Excel", nonaktifkan juga di sini:
                // btnImportExcel.Enabled = false;

                // Beri tahu pengguna via title form (opsional agar user tau rolenya)
                this.Text = "Monitoring Kualitas Air - Lahan (Mode View/Petugas)";
            }
            else
            {
                // Admin bisa melakukan semua hal
                btnInsert.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                this.Text = "Monitoring Kualitas Air - Lahan (Mode CRUD/Admin)";
            }
        }

        private void HitungTotal()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CountLahan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputParam =
                            new SqlParameter("@Total", SqlDbType.Int);

                        outputParam.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(outputParam);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        lblTotal.Text =
                            "Total Lahan : " + outputParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghitung total: " + ex.Message);
            }
        }
    }
}