using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringKualitasAir
{
    public partial class Dashboard : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
        "Data Source=LAPTOP-GO2648H1\\DEVITADWI; Initial Catalog=DBMonitoringKualitasAir; Integrated Security=True";

        private string role;

        // Constructor utama yang dipanggil dari form Login (membawa data role)
        public Dashboard(string roleUser)
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            role = roleUser; // Menyimpan role dari login (misal: "admin" atau "petugas")
        }

        // Jalankan pembatasan menu saat Dashboard pertama kali dimuat
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Contoh pembatasan menu di tingkat Dashboard:
            // Jika login sebagai petugas, mereka tidak boleh mengelola data Master Petugas
            if (role != null && role.Equals("petugas", StringComparison.OrdinalIgnoreCase))
            {
                btnPetugas.Enabled = false; // Tombol menu Petugas dimatikan untuk role petugas
                // btnPetugas.Visible = false; // Atau bisa disembunyikan jika mau
            }
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            Petugas f = new Petugas(role); // Melempar role ke form Petugas
            f.Show();
            this.Hide();
        }

        private void btnLahan_Click(object sender, EventArgs e)
        {
            Lahan f = new Lahan(role); // Melempar role ke form Lahan
            f.Show();
            this.Hide();
        }

        private void btnIrigasi_Click(object sender, EventArgs e)
        {
            Irigasi f = new Irigasi(role); // Melempar role ke form Irigasi
            f.Show();
            this.Hide();
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            // PERBAIKAN: Langsung panggil nama Form-nya saja (tidak perlu dobel nama folder/namespace)
            MonitoringKualitasAir f = new MonitoringKualitasAir(role);
            f.Show();
            this.Hide();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            // PERBAIKAN: Kirim parameter 'role' ke dalam form Laporan sesuai constructor baru kita tadi
            Laporan f = new Laporan(role);
            f.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Close(); // Menggunakan Close() agar memori form dashboard sebelumnya dibersihkan
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}