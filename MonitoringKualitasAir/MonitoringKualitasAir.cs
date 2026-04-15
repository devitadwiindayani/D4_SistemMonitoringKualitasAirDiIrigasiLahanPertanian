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

        // ================= LOAD =================
        private void MonitoringKualitasAir_Load(object sender, EventArgs e)
        {
            cmbKondisi.Items.Add("Baik");
            cmbKondisi.Items.Add("Cukup");
            cmbKondisi.Items.Add("Kurang");

            txtIDMonitoring.ReadOnly = true;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.CellClick += dataGridView1_CellContentClick;
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

        // ================= SIMPAN (FIX FK & TYPE) =================
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = @"INSERT INTO MonitoringKualitasAir
                (id_lahan, id_irigasi, id_petugas, tanggal_monitoring, ph_air, kondisi_air, keterangan)
                VALUES (@l,@i,@p,@t,@ph,@k,@ket)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@l", Convert.ToInt32(txtIDLahan.Text));
                cmd.Parameters.AddWithValue("@i", Convert.ToInt32(txtIDIrigasi.Text));
                cmd.Parameters.AddWithValue("@p", Convert.ToInt32(txtIDPetugas.Text));
                cmd.Parameters.AddWithValue("@t", dptTanggal.Value);
                cmd.Parameters.AddWithValue("@ph", Convert.ToDecimal(txtPH.Text));
                cmd.Parameters.AddWithValue("@k", cmbKondisi.Text);
                cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil disimpan");
                btnLoad.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert error: " + ex.Message);
            }
        }

        // ================= LOAD DATA =================
        private void btnLoad_Click(object sender, EventArgs e)
        {
            conn.Open();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("lahan", "Lahan");
            dataGridView1.Columns.Add("irigasi", "Irigasi");
            dataGridView1.Columns.Add("petugas", "Petugas");
            dataGridView1.Columns.Add("tanggal", "Tanggal");
            dataGridView1.Columns.Add("ph", "pH");
            dataGridView1.Columns.Add("kondisi", "Kondisi");
            dataGridView1.Columns.Add("ket", "Keterangan");

            SqlCommand cmd = new SqlCommand("SELECT * FROM MonitoringKualitasAir", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(
                    dr["id_monitoring"],
                    dr["id_lahan"],
                    dr["id_irigasi"],
                    dr["id_petugas"],
                    dr["tanggal_monitoring"],
                    dr["ph_air"],
                    dr["kondisi_air"],
                    dr["keterangan"]
                );
            }

            conn.Close();
        }

        // ================= UPDATE (FIX TYPE) =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = @"UPDATE MonitoringKualitasAir
                SET id_lahan=@l,
                    id_irigasi=@i,
                    id_petugas=@p,
                    tanggal_monitoring=@t,
                    ph_air=@ph,
                    kondisi_air=@k,
                    keterangan=@ket
                WHERE id_monitoring=@id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtIDMonitoring.Text));
                cmd.Parameters.AddWithValue("@l", Convert.ToInt32(txtIDLahan.Text));
                cmd.Parameters.AddWithValue("@i", Convert.ToInt32(txtIDIrigasi.Text));
                cmd.Parameters.AddWithValue("@p", Convert.ToInt32(txtIDPetugas.Text));
                cmd.Parameters.AddWithValue("@t", dptTanggal.Value);
                cmd.Parameters.AddWithValue("@ph", Convert.ToDecimal(txtPH.Text));
                cmd.Parameters.AddWithValue("@k", cmbKondisi.Text);
                cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil diupdate");
                btnLoad.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = "DELETE FROM MonitoringKualitasAir WHERE id_monitoring=@id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtIDMonitoring.Text));

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil dihapus");
                btnLoad.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message);
            }
        }

        // ================= CLICK GRID (AUTO FILL) =================
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtIDMonitoring.Text = row.Cells[0].Value.ToString();
                txtIDLahan.Text = row.Cells[1].Value.ToString();
                txtIDIrigasi.Text = row.Cells[2].Value.ToString();
                txtIDPetugas.Text = row.Cells[3].Value.ToString();
                dptTanggal.Value = Convert.ToDateTime(row.Cells[4].Value);
                txtPH.Text = row.Cells[5].Value.ToString();
                cmbKondisi.Text = row.Cells[6].Value.ToString();
                txtKeterangan.Text = row.Cells[7].Value.ToString();
            }
        }

        // ================= EMPTY EVENTS =================
        private void txtIDMonitoring_TextChanged(object sender, EventArgs e) { }
        private void txtIDLahan_TextChanged(object sender, EventArgs e) { }
        private void txtIDIrigasi_TextChanged(object sender, EventArgs e) { }
        private void txtIDPetugas_TextChanged(object sender, EventArgs e) { }
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
    }
}