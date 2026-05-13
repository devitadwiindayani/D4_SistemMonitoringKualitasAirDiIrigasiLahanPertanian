using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MonitoringKualitasAir
{
    public partial class Petugas : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
        "Data Source=LAPTOP-GO2648H1\\DEVITADWI; Initial Catalog=DBMonitoringKualitasAir; Integrated Security=True";

        private string role;

        // Storage Procedu
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
            // TODO: This line of code loads data into the 'dBMonitoringKualitasAirDataSet.Petugas' table. You can move, or remove it, as needed.
            this.petugasTableAdapter.Fill(this.dBMonitoringKualitasAirDataSet.Petugas);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dataGridView1.CellClick += dataGridView1_CellClick;

            ApplyRole();

        }
        //dataGridView1.CellClick += dataGridView1_CellClick;
        //ApplyRole();
        //tambahan yg bawah ini
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


        private void ClearForm()
        {
            txtIDPetugas.Clear();
            txtNamaPetugas.Clear();
            txtNoHP.Clear();

            txtIDPetugas.Focus();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Dashboard f = new Dashboard();
            f.Show();
            this.Hide();
        }

        // Referensi gpt
        private void ApplyRole()
        {
            if (role == "Petugas")
            {
                // MATIKAN CRUD
                btnInsert.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                // OPTIONAL: kalau ada textbox input
                txtNamaPetugas.Enabled = false;
                txtNoHP.Enabled = false;
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

        //hitung tottal
        private void HitungTotal()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CountPetugas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputParam =
                            new SqlParameter("@Total", SqlDbType.Int);

                        outputParam.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(outputParam);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        lblTotal.Text =
                            "Total Petugas : " + outputParam.Value.ToString();
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