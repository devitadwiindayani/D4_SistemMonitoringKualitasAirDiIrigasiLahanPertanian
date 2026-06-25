using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Web.Security;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MonitoringKualitasAir
{
    public partial class Laporan : Form
    {
        DALMonitoring dbLogic = new DALMonitoring();

        bool isInitializing = true;

        DataTable dt;

        int button = 0;

        private string role;

        // Ubah constructor utamanya agar menerima parameter string roleUser
        public Laporan(string roleUser)
        {
            InitializeComponent();
            role = roleUser;
        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            dtpTahun.Format = DateTimePickerFormat.Custom;
            dtpTahun.CustomFormat = "yyyy";
            dtpTahun.ShowUpDown = true;
            dtpTahun.MaxDate = DateTime.Now;

            cmbTipe.DropDownStyle = ComboBoxStyle.DropDownList;

            var items = new List<KeyValuePair<string, SeriesChartType>>
            {
                new KeyValuePair<string, SeriesChartType>("Kolom", SeriesChartType.Column),
                new KeyValuePair<string, SeriesChartType>("Pie", SeriesChartType.Pie)
            };


            isInitializing = true;

            cmbTipe.DataSource = items;
            cmbTipe.DisplayMember = "Key";
            cmbTipe.ValueMember = "Value";
            cmbTipe.SelectedIndex = 0;

            isInitializing = false;

            LoadDataChart();
        }

        public void LoadDataChart()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();
            chart1.ChartAreas.Clear();

            ChartArea ca = new ChartArea("MainArea");

            ca.AxisX.Title = "Kondisi Air";
            ca.AxisY.Title = "Jumlah Monitoring";
            ca.AxisX.LabelStyle.Angle = -45;

            chart1.ChartAreas.Add(ca);

            try
            {
                if (button == 1)
                {
                    dt = dbLogic.GetDataChartByTahun(
                        dtpTahun.Value);
                }
                else
                {
                    dt = dbLogic.GetAllDataChart();
                }

                SeriesChartType tipe =
                    (SeriesChartType)cmbTipe.SelectedValue;

                if (tipe == SeriesChartType.Column)
                {
                    Series s = new Series("Jumlah Monitoring");

                    s.ChartType = SeriesChartType.Column;

                    foreach (DataRow row in dt.Rows)
                    {
                        string kondisi =
                            row["KondisiAir"].ToString();

                        int jumlah =
                            Convert.ToInt32(
                                row["JumlahMonitoring"]);

                        s.Points.AddXY(
                            kondisi,
                            jumlah);
                    }

                    chart1.Series.Add(s);
                }
                else
                {
                    Series s =
                        new Series("Jumlah Monitoring");

                    s.ChartType = tipe;

                    s.IsValueShownAsLabel = true;
                    s.Label = "#VALX";
                    s.LegendText = "#VALX";

                    foreach (DataRow row in dt.Rows)
                    {
                        string kondisi =
                            row["KondisiAir"].ToString();

                        int jumlah =
                            Convert.ToInt32(
                                row["JumlahMonitoring"]);

                        s.Points.AddXY(
                            kondisi,
                            jumlah);
                    }

                    chart1.Series.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal load data : " +
                    ex.Message);
            }

            Title title =
                new Title(
                    "Jumlah Monitoring Berdasarkan Kondisi Air",
                    Docking.Top,
                    new Font("Arial", 12, FontStyle.Bold),
                    Color.Black);

            chart1.Titles.Add(title);

            Legend legend =
                new Legend("MainLegend");

            legend.Docking = Docking.Right;

            chart1.Legends.Add(legend);
        }

        private void cmbTipe_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (isInitializing)
                return;

            LoadDataChart();
        }

        private void btnLoad_Click(
            object sender,
            EventArgs e)
        {
            button = 1;
            LoadDataChart();
        }

        private void btnReset_Click(
            object sender,
            EventArgs e)
        {
            button = 0;
            LoadDataChart();
        }

        private void btnCetak_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Fitur cetak laporan belum dibuat.");
        }

        private void button1_Click(
            object sender,
            EventArgs e)
        {
            Dashboard f = new Dashboard(role); // Ganti sesuai nama form menu utama Anda
            f.Show();
            this.Close();
        }

        private void chart1_Click(
            object sender,
            EventArgs e)
        {

        }
    }
}