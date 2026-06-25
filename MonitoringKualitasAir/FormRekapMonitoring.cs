using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MonitoringKualitasAir
{
    public partial class FormRekapMonitoring : Form
    {
        // 1. PERBAIKAN: Menambahkan variabel connString global agar bisa dipakai di semua fungsi
        string connString = @"Data Source=LAPTOP-GO2648H1\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True";

        // Variabel global untuk menampung role dari form sebelumnya
        private string role;

        // PERBAIKAN CONSTRUCTOR: Pastikan menerima parameter 'roleUser'
        public FormRekapMonitoring(string roleUser)
        {
            InitializeComponent();
            role = roleUser;
        }

        private void FormRekapMonitoring_Load(object sender, EventArgs e)
        {
            // Load data lahan ke ComboBox saat form dibuka
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT id_lahan, nama_lahan FROM Lahan";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbFilterLahan.DataSource = dt;
                    cmbFilterLahan.DisplayMember = "nama_lahan";
                    cmbFilterLahan.ValueMember = "id_lahan";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load daftar lahan: " + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Proses menampilkan data ke DataGridView
            if (cmbFilterLahan.SelectedValue == null) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    // Pastikan nama SP sesuai dengan yang ada di SQL Server
                    SqlCommand cmd = new SqlCommand("sp_ReportMonitoring", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Kirim parameter ID_Lahan
                    cmd.Parameters.Add("@ID_Lahan", SqlDbType.Int).Value = cmbFilterLahan.SelectedValue;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data monitoring: " + ex.Message);
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validasi pastikan ComboBox filter lahan tidak kosong
                if (cmbFilterLahan.SelectedValue == null)
                {
                    MessageBox.Show("Silakan pilih lahan terlebih dahulu sebelum mencetak!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Ambil nilai dari ComboBox Lahan dan DateTimePicker Anda
                string idLahan = cmbFilterLahan.SelectedValue.ToString();

                // CATATAN PENTING: Jika 'dtpFilterTanggal' masih merah, cek nama DateTimePicker Anda 
                // di layar Design Properties, lalu samakan namanya di bawah ini.
                DateTime tahun = dtpTahun.Value;

                // 3. Panggil FormCetak dengan mengirimkan 3 parameter sesuai kebutuhan konstruktornya
                FormCetak frmCetak = new FormCetak(idLahan, tahun, role);
                frmCetak.Show();
                this.Hide(); // Sembunyikan form rekap
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memproses cetak: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}