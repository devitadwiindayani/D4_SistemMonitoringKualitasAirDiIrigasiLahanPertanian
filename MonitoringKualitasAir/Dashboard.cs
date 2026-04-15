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

        public Dashboard()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private string role;

        public Dashboard(string roleUser)
        {
            InitializeComponent();
            role = roleUser;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            Petugas f = new Petugas(role);
            f.Show();
            this.Hide();
        }

        private void btnLahan_Click(object sender, EventArgs e)
        {
            Lahan f = new Lahan();
            f.Show();
            this.Hide();
        }

        private void btnIrigasi_Click(object sender, EventArgs e)
        {
            Irigasi f = new Irigasi(role);
            f.Show();
            this.Hide();
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            MonitoringKualitasAir f = new MonitoringKualitasAir();
            f.Show();
            this.Hide();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Laporan f = new Laporan();
            f.Show();
            this.Hide();
        }
    }
}
