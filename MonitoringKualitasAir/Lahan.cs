using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            Dashboard f = new Dashboard();
            f.Show();
            this.Hide();
        }

        // referensi gpt
        private void ApplyRole()
        {

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