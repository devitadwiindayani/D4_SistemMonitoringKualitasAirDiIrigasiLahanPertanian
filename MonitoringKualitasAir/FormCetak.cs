using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace MonitoringKualitasAir
{
    public partial class FormCetak : Form
    {
        // 1. Definisikan variabel yang dibutuhkan
        private string _lahan;
        private DateTime _tahun;
        string connString = @"Data Source=LAPTOP-GO2648H1\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True";
        private string role;

        // Konstruktor
        public FormCetak(string lahan, DateTime tahun, string role)
        {
            InitializeComponent();
            _lahan = lahan;
            _tahun = tahun;
            this.role = role;
        }

        private void FormCetak_Load(object sender, EventArgs e)
        {
            try
            {
                // 2. Membuat koneksi baru di dalam using agar aman
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_ReportMonitoring", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // 3. Gunakan _lahan (dari parameter konstruktor)
                    cmd.Parameters.Add("@ID_Lahan", SqlDbType.Int).Value = int.Parse(_lahan);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 4. Set ke Report jika data ditemukan
                    if (dt.Rows.Count > 0)
                    {
                        CrystalReportMonitoring rpt = new CrystalReportMonitoring();

                        // Menyetel paksa koneksi Crystal Report agar sinkron dengan SQL Server Anda
                        TableLogOnInfo logOnInfo = new TableLogOnInfo();
                        logOnInfo.ConnectionInfo.ServerName = @"LAPTOP-GO2648H1\DEVITADWI";
                        logOnInfo.ConnectionInfo.DatabaseName = "DBMonitoringKualitasAir";
                        logOnInfo.ConnectionInfo.IntegratedSecurity = true;

                        foreach (Table table in rpt.Database.Tables)
                        {
                            table.ApplyLogOnInfo(logOnInfo);
                        }

                        // Kirim datatable baru ke dalam report
                        rpt.SetDataSource(dt);

                        crystalReportViewer1.ReportSource = rpt;
                        crystalReportViewer1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Data rekap tidak ditemukan di database untuk lahan ini.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error saat memuat laporan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            // Tempatkan event load tambahan jika diperlukan
        }
    }
}