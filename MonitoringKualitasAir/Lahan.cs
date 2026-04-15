using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MonitoringKualitasAir
{
    public partial class Lahan : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
        "Data Source=LAPTOP-GO2648H1\\DEVITADWI; Initial Catalog=DBMonitoringKualitasAir; Integrated Security=True";

        public Lahan()
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

        private void Lahan_Load(object sender, EventArgs e)
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

                dataGridView1.Columns.Add("ID_Lahan", "ID Lahan");
                dataGridView1.Columns.Add("Nama_Lahan", "Nama Lahan");
                dataGridView1.Columns.Add("Lokasi", "Lokasi");
                dataGridView1.Columns.Add("Luas_Lahan", "Luas Lahan");

                string query = "SELECT * FROM Lahan";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["ID_Lahan"].ToString(),
                        reader["Nama_Lahan"].ToString(),
                        reader["Lokasi"].ToString(),
                        reader["Luas_Lahan"].ToString()
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = @"INSERT INTO Lahan
                (Nama_Lahan, Lokasi, Luas_Lahan)
                VALUES
                (@Nama, @Lokasi, @Luas)";

                SqlCommand cmd = new SqlCommand(query, conn);

                //cmd.Parameters.AddWithValue("@ID", txtIDLahan.Text);
                cmd.Parameters.AddWithValue("@Nama", txtNamaLahan.Text);
                cmd.Parameters.AddWithValue("@Lokasi", txtLokasi.Text);
                cmd.Parameters.AddWithValue("@Luas", txtLuasLahan.Text);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = @"UPDATE Lahan
                SET Nama_Lahan = @Nama,
                    Lokasi = @Lokasi,
                    Luas_Lahan = @Luas
                WHERE ID_Lahan = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", txtIDLahan.Text);
                cmd.Parameters.AddWithValue("@Nama", txtNamaLahan.Text);
                cmd.Parameters.AddWithValue("@Lokasi", txtLokasi.Text);
                cmd.Parameters.AddWithValue("@Luas", txtLuasLahan.Text);

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

        private void btnDelete_Click(object sender, EventArgs e)
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
                    string query = "DELETE FROM Lahan WHERE ID_Lahan = @ID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", txtIDLahan.Text);

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtIDLahan.Text = row.Cells["ID_Lahan"].Value.ToString();
                txtNamaLahan.Text = row.Cells["Nama_Lahan"].Value.ToString();
                txtLokasi.Text = row.Cells["Lokasi"].Value.ToString();
                txtLuasLahan.Text = row.Cells["Luas_Lahan"].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtIDLahan.Clear();
            txtNamaLahan.Clear();
            txtLokasi.Clear();
            txtLuasLahan.Clear();

            txtIDLahan.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard f = new Dashboard();
            f.Show();
            this.Hide();
        }
    }
}