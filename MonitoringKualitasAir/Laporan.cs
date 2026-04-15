using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringKualitasAir
{
    public partial class Laporan : Form
    {
        // Koneksi ke database
        private readonly SqlConnection conn;
        private readonly string connectionString =
                "Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True";
        public Laporan()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("tanggal", "Tanggal");
                dataGridView1.Columns.Add("ph", "pH");
                dataGridView1.Columns.Add("kondisi", "Kondisi");

                string query = "SELECT tanggal_monitoring, ph_air, kondisi_air FROM MonitoringKualitasAir";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        Convert.ToDateTime(reader["tanggal_monitoring"]).ToShortDateString(),
                        reader["ph_air"].ToString(),
                        reader["kondisi_air"].ToString()
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tampil data: " + ex.Message);
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                chart1.Series.Clear();

                var s = chart1.Series.Add("pH Air");
                s.ChartType = SeriesChartType.Column; // biar gampang dibaca

                string query = "SELECT ph_air FROM MonitoringKualitasAir";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                int i = 1;

                while (reader.Read())
                {
                    if (reader["ph_air"] != DBNull.Value)
                    {
                        s.Points.AddXY("Data " + i, Convert.ToDouble(reader["ph_air"]));
                        i++;
                    }
                }

                reader.Close();

                chart1.Titles.Clear();
                chart1.Titles.Add("Grafik pH Air");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tampil chart: " + ex.Message);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
