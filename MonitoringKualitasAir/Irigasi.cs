using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MonitoringKualitasAir
{
    public partial class Irigasi : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
        "Data Source=LAPTOP-GO2648H1\\DEVITADWI; Initial Catalog=DBMonitoringKualitasAir; Integrated Security=True";


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

        private void button3_Click(object sender, EventArgs e)
        {
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

        private void Irigasi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBMonitoringKualitasAirDataSet1.Irigasi' table. You can move, or remove it, as needed.
            this.irigasiTableAdapter.Fill(this.dBMonitoringKualitasAirDataSet2.Irigasi);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.CellClick += dataGridView1_CellClick;

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
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

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Dashboard f = new Dashboard();
            f.Show();
            this.Hide();
        }

        private string role;

        // Referensi gpt
        private void ApplyRole()
        {
            if (role == "Petugas")
                // READ ONLY MODE
                btnInsert.Enabled = true; // INSERT
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true; // DELETE
            
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //hitung total
        private void HitungTotal()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CountIrigasi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputParam =
                            new SqlParameter("@Total", SqlDbType.Int);

                        outputParam.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(outputParam);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        lblTotal.Text =
                            "Total Irigasi : " + outputParam.Value.ToString();
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