using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MonitoringKualitasAir
{
    public partial class MonitoringKualitasAir : Form
    {
        SqlConnection conn;

        public MonitoringKualitasAir()
        {
            InitializeComponent();
            conn = new SqlConnection(
                "Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True");
        }

        private string role;
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
            this.vw_MonitoringKualitasAirTableAdapter.Fill(this.dBMonitoringKualitasAirDataSet4.vw_MonitoringKualitasAir);
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

            LoadData();
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

            txtIDMonitoring.DataBindings.Add(
                "Text", bindingSource, "id_monitoring");

            txtPH.DataBindings.Add(
                "Text", bindingSource, "ph_air");

            txtKeterangan.DataBindings.Add(
                "Text", bindingSource, "keterangan");

            // INI YANG MENAMPILKAN NAMA
            cmbLahan.DataBindings.Add(
                "Text", bindingSource, "nama_lahan");

            cmbIrigasi.DataBindings.Add(
                "Text", bindingSource, "nama_irigasi");

            cmbPetugas.DataBindings.Add(
                "Text", bindingSource, "nama_petugas");

            cmbKondisi.DataBindings.Add(
                "Text", bindingSource, "kondisi_air");

            dptTanggal.DataBindings.Add(
                "Value", bindingSource, "tanggal_monitoring");
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
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_InsertMonitoring", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Lahan", cmbLahan.SelectedValue);
                cmd.Parameters.AddWithValue("@ID_Irigasi", cmbIrigasi.SelectedValue);
                cmd.Parameters.AddWithValue("@ID_Petugas", cmbPetugas.SelectedValue);
                cmd.Parameters.AddWithValue("@Tanggal_Monitoring", dptTanggal.Value);
                cmd.Parameters.AddWithValue("@PH_Air", txtPH.Text);
                cmd.Parameters.AddWithValue("@Kondisi_Air", cmbKondisi.Text);
                cmd.Parameters.AddWithValue("@Keterangan", txtKeterangan.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil disimpan");
                btnLoad.PerformClick();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Insert error: " + ex.Message);
            }
        }

        // ================= LOAD DATA =================
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        // ================= UPDATE (FIX TYPE) =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_UpdateMonitoring", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Monitoring", txtIDMonitoring.Text);
                cmd.Parameters.AddWithValue("@ID_Lahan", cmbLahan.SelectedValue);
                cmd.Parameters.AddWithValue("@ID_Irigasi", cmbIrigasi.SelectedValue);
                cmd.Parameters.AddWithValue("@ID_Petugas", cmbPetugas.SelectedValue);
                cmd.Parameters.AddWithValue("@Tanggal_Monitoring", dptTanggal.Value);
                cmd.Parameters.AddWithValue("@PH_Air", txtPH.Text);
                cmd.Parameters.AddWithValue("@Kondisi_Air", cmbKondisi.Text);
                cmd.Parameters.AddWithValue("@Keterangan", txtKeterangan.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Data berhasil diupdate");
                btnLoad.PerformClick();
            }
            catch (Exception ex)
            {
                conn.Close();

                MessageBox.Show("Update error: " + ex.Message);
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
        }

        // ================= CLICK GRID (AUTO FILL) =================
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            bindingSource.Position = e.RowIndex;
        }

        // ================= EMPTY EVENTS =================
        private void txtIDMonitoring_TextChanged(object sender, EventArgs e) { }
        private void dptTanggal_ValueChanged(object sender, EventArgs e) { }
        private void txtPH_TextChanged(object sender, EventArgs e) { }
        private void cmbKondisi_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtKeterangan_TextChanged(object sender, EventArgs e) { }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Dashboard f = new Dashboard(); //
            f.Show();
            this.Hide();
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
                using (SqlConnection conn = new SqlConnection(
                    "Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "sp_SearchMonitoring", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue(
                            "@Keyword", txtSearch.Text.Trim());

                        using (SqlDataAdapter da =
                            new SqlDataAdapter(cmd))
                        {
                            DataTable dtSearch = new DataTable();

                            da.Fill(dtSearch);

                            bindingSource.DataSource = dtSearch;

                            dataGridView1.DataSource = bindingSource;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search error: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInjectionMonitoring_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(
                    "Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True"))
                {
                    conn.Open();

                    // QUERY INI AKAN UPDATE SEMUA BARIS (tanpa WHERE)
                    string query = "UPDATE Petugas SET nama_petugas ='HACKED'";

                    // ATAU jika ingin seperti screenshot (UPDATE berdasarkan kondisi yang selalu true)
                    // string query = "UPDATE MonitoringKualitasAir SET keterangan='HACKED' WHERE 1=1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show(result + " baris terupdate");
                    }
                }

                btnLoad.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(
                    "Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True"))
                {
                    conn.Open();

                    string query = @"

            -- RESET DATA PETUGAS OTOMATIS
            UPDATE Petugas
            SET nama_petugas = nama_asli;

            -- RESET DATA MONITORING
            UPDATE MonitoringKualitasAir
            SET 
                keterangan =
                CASE
                    WHEN id_monitoring = 1 THEN 'Air jernih'
                    WHEN id_monitoring = 2 THEN 'Sedikit keruh'
                    ELSE '-'
                END,

                ph_air =
                CASE
                    WHEN id_monitoring = 1 THEN 7.20
                    WHEN id_monitoring = 2 THEN 6.80
                    ELSE 7.0
                END

            ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data berhasil direset");

                LoadPetugas();
                btnLoad.PerformClick();
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
    }
}