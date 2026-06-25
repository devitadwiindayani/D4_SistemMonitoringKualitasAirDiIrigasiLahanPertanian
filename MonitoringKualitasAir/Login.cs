using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MonitoringKualitasAir
{
    public partial class Login : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
        "Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Validasi input jika username atau password kosong
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                // 2. Query untuk mencocokkan username, password, dan mengambil nilai role user
                SqlCommand cmd = new SqlCommand("SELECT role FROM Users WHERE username=@user AND password=@pass", conn);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                object result = cmd.ExecuteScalar();

                // 3. Jika data user ditemukan di database (Login Sukses)
                if (result != null)
                {
                    string role = result.ToString();

                    // Simpan ke class UserSession (jika Anda menggunakan class session global)
                    // UserSession.Username = txtUsername.Text;
                    // UserSession.Role = role;

                    MessageBox.Show("Login berhasil sebagai " + role, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Buka Form Dashboard sambil melempar parameter data 'role' agar sinkron dengan form lain
                    Dashboard f = new Dashboard(role);
                    f.Show();

                    // Sembunyikan form login ini
                    this.Hide();
                }
                else
                {
                    // Jika data user tidak ditemukan
                    MessageBox.Show("Username atau Password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 5. Pastikan koneksi database selalu ditutup kembali
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Jika tombol kembali ditekan, biasanya menutup aplikasi atau kembali ke halaman awal (jika ada)
            Application.Exit();
        }
    }
}