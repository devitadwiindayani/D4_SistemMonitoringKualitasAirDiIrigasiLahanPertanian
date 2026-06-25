using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MonitoringKualitasAir
{
    public partial class Irigasi : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
        "Data Source=LAPTOP-GO2648H1\\DEVITADWI; Initial Catalog=DBMonitoringKualitasAir; Integrated Security=True";

        private string role;

        // ====================================================
        // MODUL STORED PROCEDURE
        // ====================================================
        private BindingSource bindingSource = new BindingSource();
        private DataTable dtIrigasi = new DataTable();

        public Irigasi()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        public Irigasi(string roleUser)
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

        // TOMBOL INSERT / SIMPAN
        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Validasi Input Kosong untuk Kolom Utama (Nama Irigasi)
            if (string.IsNullOrWhiteSpace(txtNamaIrigasi.Text))
            {
                MessageBox.Show("Nama Irigasi wajib diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaIrigasi.Focus();
                return;
            }

            // 2. Validasi Nama Irigasi (Hanya Huruf dan Spasi)
            if (!Regex.IsMatch(txtNamaIrigasi.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Gagal menyimpan! Nama irigasi hanya boleh berisi huruf dan spasi.",
                                "Format Nama Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaIrigasi.Focus();
                return;
            }

            // 3. Validasi Jenis Irigasi (Hanya Huruf dan Spasi jika diisi)
            if (!string.IsNullOrWhiteSpace(txtJenisIrigasi.Text))
            {
                if (!Regex.IsMatch(txtJenisIrigasi.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Gagal menyimpan! Jenis irigasi hanya boleh berisi huruf dan spasi.",
                                    "Format Jenis Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtJenisIrigasi.Focus();
                    return;
                }
            }

            // 4. Validasi Lokasi Irigasi (Hanya Huruf dan Spasi jika diisi)
            if (!string.IsNullOrWhiteSpace(txtLokasi.Text))
            {
                if (!Regex.IsMatch(txtLokasi.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Gagal menyimpan! Lokasi irigasi hanya boleh berisi huruf dan spasi.",
                                    "Format Lokasi Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLokasi.Focus();
                    return;
                }
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertIrigasi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nama_Irigasi", txtNamaIrigasi.Text);
                        cmd.Parameters.AddWithValue("@Jenis_Irigasi", txtJenisIrigasi.Text);
                        cmd.Parameters.AddWithValue("@Lokasi", txtLokasi.Text);

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

        // TOMBOL DELETE / HAPUS
        private void button5_Click(object sender, EventArgs e)
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
                        using (SqlCommand cmd = new SqlCommand("sp_DeleteIrigasi", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@ID_Irigasi", txtIDIrigasi.Text);

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

        // FORM LOAD
        private void Irigasi_Load(object sender, EventArgs e)
        {
            this.irigasiTableAdapter.Fill(this.dBMonitoringKualitasAirDataSet2.Irigasi);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.CellClick += dataGridView1_CellClick;

            // PENTING: Menghubungkan bindingNavigator dengan data dari Stored Procedure jika ada
            if (bindingNavigator1 != null) { bindingNavigator1.BindingSource = bindingSource; }

            // Jalankan validasi role sebelum mengambil data
            ApplyRole();

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetIrigasi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            dtIrigasi = new DataTable();

                            da.Fill(dtIrigasi);

                            bindingSource.DataSource = dtIrigasi;
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

        private void BindControls()
        {
            txtIDIrigasi.DataBindings.Clear();
            txtNamaIrigasi.DataBindings.Clear();
            txtJenisIrigasi.DataBindings.Clear();
            txtLokasi.DataBindings.Clear();

            txtIDIrigasi.DataBindings.Add("Text", bindingSource, "ID_Irigasi");
            txtNamaIrigasi.DataBindings.Add("Text", bindingSource, "Nama_Irigasi");
            txtJenisIrigasi.DataBindings.Add("Text", bindingSource, "Jenis_Irigasi");
            txtLokasi.DataBindings.Add("Text", bindingSource, "Lokasi");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // TOMBOL UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 1. Validasi Input Kosong untuk Kolom Utama (Nama Irigasi)
            if (string.IsNullOrWhiteSpace(txtNamaIrigasi.Text))
            {
                MessageBox.Show("Nama Irigasi wajib diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaIrigasi.Focus();
                return;
            }

            // 2. Validasi Nama Irigasi (Hanya Huruf dan Spasi)
            if (!Regex.IsMatch(txtNamaIrigasi.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Gagal menyimpan! Nama irigasi hanya boleh berisi huruf dan spasi.",
                                "Format Nama Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaIrigasi.Focus();
                return;
            }

            // 3. Validasi Jenis Irigasi (Hanya Huruf dan Spasi jika diisi)
            if (!string.IsNullOrWhiteSpace(txtJenisIrigasi.Text))
            {
                if (!Regex.IsMatch(txtJenisIrigasi.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Gagal menyimpan! Jenis irigasi hanya boleh berisi huruf dan spasi.",
                                    "Format Jenis Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtJenisIrigasi.Focus();
                    return;
                }
            }

            // 4. Validasi Lokasi Irigasi (Hanya Huruf dan Spasi jika diisi)
            if (!string.IsNullOrWhiteSpace(txtLokasi.Text))
            {
                if (!Regex.IsMatch(txtLokasi.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Gagal menyimpan! Lokasi irigasi hanya boleh berisi huruf dan spasi.",
                                    "Format Lokasi Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLokasi.Focus();
                    return;
                }
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_UpdateIrigasi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_Irigasi", txtIDIrigasi.Text);
                        cmd.Parameters.AddWithValue("@Nama_Irigasi", txtNamaIrigasi.Text);
                        cmd.Parameters.AddWithValue("@Jenis_Irigasi", txtJenisIrigasi.Text);
                        cmd.Parameters.AddWithValue("@Lokasi", txtLokasi.Text);

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtIDIrigasi.Text = row.Cells[0].Value.ToString();
                txtNamaIrigasi.Text = row.Cells[1].Value.ToString();
                txtJenisIrigasi.Text = row.Cells[2].Value.ToString();
                txtLokasi.Text = row.Cells[3].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtIDIrigasi.Clear();
            txtNamaIrigasi.Clear();
            txtJenisIrigasi.Clear();
            txtLokasi.Clear();

            txtIDIrigasi.Focus();
        }

        // TOMBOL KEMBALI
        private void btnKembali_Click(object sender, EventArgs e)
        {
            Dashboard f = new Dashboard(role);
            f.Show();
            this.Close();
        }

        // ====================================================
        // MANAJEMEN HAK AKSES ROLE USER
        // ====================================================
        private void ApplyRole()
        {
            // Menggunakan StringComparison agar pengecekan huruf "Petugas" aman dari typo kapital
            if (role != null && role.Equals("petugas", StringComparison.OrdinalIgnoreCase))
            {
                // MENONAKTIFKAN TOMBOL CRUD (button3=Insert, btnUpdate=Update, button5=Delete)
                btnInsert.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                // Menonaktifkan inputan field data agar petugas tidak bisa memodifikasi teks
                txtNamaIrigasi.Enabled = false;
                txtJenisIrigasi.Enabled = false;
                txtLokasi.Enabled = false;

                this.Text = "Monitoring Kualitas Air - Data Irigasi (Mode View / Petugas)";
            }
            else
            {
                // Jika Admin, berikan akses penuh untuk mengelola data irigasi
                btnInsert.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                txtNamaIrigasi.Enabled = true;
                txtJenisIrigasi.Enabled = true;
                txtLokasi.Enabled = true;

                this.Text = "Monitoring Kualitas Air - Data Irigasi (Mode CRUD / Admin)";
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Menghitung total data menggunakan SP Output Parameter
        private void HitungTotal()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CountIrigasi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputParam = new SqlParameter("@Total", SqlDbType.Int);
                        outputParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputParam);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        lblTotal.Text = "Total Irigasi : " + outputParam.Value.ToString();
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