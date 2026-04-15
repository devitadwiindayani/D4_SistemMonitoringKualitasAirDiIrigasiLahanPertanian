using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MonitoringKualitasAir
{
    public partial class Irigasi : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
        "Data Source=LAPTOP-GO2648H1\\DEVITADWI; Initial Catalog=DBMonitoringKualitasAir; Integrated Security=True";

        public Irigasi()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = @"INSERT INTO Irigasi
                (Nama_Irigasi, Jenis_Irigasi, Lokasi)
                VALUES
                (@Nama, @Jenis, @Lokasi)";

                SqlCommand cmd = new SqlCommand(query, conn);

                //cmd.Parameters.AddWithValue("@ID", txtIDIrigasi.Text);
                cmd.Parameters.AddWithValue("@Nama", txtNamaIrigasi.Text);
                cmd.Parameters.AddWithValue("@Jenis", txtJenisIrigasi.Text);
                cmd.Parameters.AddWithValue("@Lokasi", txtLokasi.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan");
                    ClearForm();
                    btnLoad.PerformClick();
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                DialogResult resultConfirm = MessageBox.Show(
                    "Yakin ingin menghapus data?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultConfirm == DialogResult.Yes)
                {
                    string query = "DELETE FROM Irigasi WHERE ID_Irigasi = @ID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", txtIDIrigasi.Text);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus");
                        ClearForm();
                        btnLoad.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void Irigasi_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("ID_Irigasi", "ID Irigasi");
                dataGridView1.Columns.Add("Nama_Irigasi", "Nama Irigasi");
                dataGridView1.Columns.Add("Jenis_Irigasi", "Jenis Irigasi");
                dataGridView1.Columns.Add("Lokasi", "Lokasi");

                string query = "SELECT * FROM Irigasi";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["ID_Irigasi"].ToString(),
                        reader["Nama_Irigasi"].ToString(),
                        reader["Jenis_Irigasi"].ToString(),
                        reader["Lokasi"].ToString()
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = @"UPDATE Irigasi
                SET Nama_Irigasi = @Nama,
                    Jenis_Irigasi = @Jenis,
                    Lokasi = @Lokasi
                WHERE ID_Irigasi = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", txtIDIrigasi.Text);
                cmd.Parameters.AddWithValue("@Nama", txtNamaIrigasi.Text);
                cmd.Parameters.AddWithValue("@Jenis", txtJenisIrigasi.Text);
                cmd.Parameters.AddWithValue("@Lokasi", txtLokasi.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil diupdate");
                    ClearForm();
                    btnLoad.PerformClick();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
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

                txtIDIrigasi.Text = row.Cells["ID_Irigasi"].Value.ToString();
                txtNamaIrigasi.Text = row.Cells["Nama_Irigasi"].Value.ToString();
                txtJenisIrigasi.Text = row.Cells["Jenis_Irigasi"].Value.ToString();
                txtLokasi.Text = row.Cells["Lokasi"].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtIDIrigasi.Clear();
            txtNamaIrigasi.Clear();
            txtJenisIrigasi.Clear();
            txtLokasi.Clear();

            txtIDIrigasi.Focus();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Dashboard f = new Dashboard();
            f.Show();
            this.Hide();
        }
    }
}

