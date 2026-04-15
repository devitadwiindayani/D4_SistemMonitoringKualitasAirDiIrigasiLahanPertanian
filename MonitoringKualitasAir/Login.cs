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
            // Validasi input kosong
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username dan Password harus diisi!");
                return;
            }

            try
            {
                conn.Open();

                // Query cek login
                SqlCommand cmd = new SqlCommand(
                    "SELECT role FROM Users WHERE username=@user AND password=@pass", conn);

                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("Login berhasil sebagai " + result.ToString());

                    Dashboard f = new Dashboard();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Show();
            this.Hide();
        }
    }
}