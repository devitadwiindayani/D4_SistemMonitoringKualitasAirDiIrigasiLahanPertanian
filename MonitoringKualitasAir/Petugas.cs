using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MonitoringKualitasAir
{
    public partial class Petugas : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
        "Data Source=LAPTOP-GO2648H1\\DEVITADWI; Initial Catalog=DBMonitoringKualitasAir; Integrated Security=True";

        public Petugas()
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

        private void Petugas_Load(object sender, EventArgs e)
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

                dataGridView1.Columns.Add("ID_Petugas", "ID Petugas");
                dataGridView1.Columns.Add("Nama_Petugas", "Nama Petugas");
                dataGridView1.Columns.Add("No_HP", "No HP");

                string query = "SELECT * FROM Petugas";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["ID_Petugas"].ToString(),
                        reader["Nama_Petugas"].ToString(),
                        reader["No_HP"].ToString()
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

                string query = @"INSERT INTO Petugas
                (Nama_Petugas, No_HP)
                VALUES
                (@Nama, @HP)";

                SqlCommand cmd = new SqlCommand(query, conn);

                //cmd.Parameters.AddWithValue("@ID", txtIDPetugas.Text);
                cmd.Parameters.AddWithValue("@Nama", txtNamaPetugas.Text);
                cmd.Parameters.AddWithValue("@HP", txtNoHP.Text);

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

                string query = @"UPDATE Petugas
                SET Nama_Petugas = @Nama,
                    No_HP = @HP
                WHERE ID_Petugas = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", txtIDPetugas.Text);
                cmd.Parameters.AddWithValue("@Nama", txtNamaPetugas.Text);
                cmd.Parameters.AddWithValue("@HP", txtNoHP.Text);

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
                    string query = "DELETE FROM Petugas WHERE ID_Petugas = @ID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", txtIDPetugas.Text);

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

                txtIDPetugas.Text = row.Cells["ID_Petugas"].Value.ToString();
                txtNamaPetugas.Text = row.Cells["Nama_Petugas"].Value.ToString();
                txtNoHP.Text = row.Cells["No_HP"].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtIDPetugas.Clear();
            txtNamaPetugas.Clear();
            txtNoHP.Clear();

            txtIDPetugas.Focus();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Dashboard f = new Dashboard();
            f.Show();
            this.Hide();
        }
    }
}