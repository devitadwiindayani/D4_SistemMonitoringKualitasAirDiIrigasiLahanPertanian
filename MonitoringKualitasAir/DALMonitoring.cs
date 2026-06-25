using System;
using System.Data;
using System.Data.SqlClient;

namespace MonitoringKualitasAir
{
    class DALMonitoring
    {
        private readonly string connectionString =
            "Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog=DBMonitoringKualitasAir;Integrated Security=True";

        // =====================================
        // LOAD COMBOBOX LAHAN
        // =====================================
        public DataTable GetLahan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_lahan, nama_lahan FROM Lahan",
                    conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        // =====================================
        // LOAD COMBOBOX IRIGASI
        // =====================================
        public DataTable GetIrigasi()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_irigasi, nama_irigasi FROM Irigasi",
                    conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        // =====================================
        // LOAD COMBOBOX PETUGAS
        // =====================================
        public DataTable GetPetugas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_petugas, nama_petugas FROM Petugas",
                    conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        // =====================================
        // LOAD DATA MONITORING
        // =====================================
        public DataTable GetMonitoring()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM vw_MonitoringKualitasAir",
                    conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        // =====================================
        // INSERT
        // =====================================
        public void InsertMonitoring(
            int idLahan,
            int idIrigasi,
            int idPetugas,
            DateTime tanggalMonitoring,
            decimal phAir,
            string kondisiAir,
            string keterangan,
            byte[] foto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd =
                    new SqlCommand("sp_InsertMonitoring", conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Lahan", idLahan);
                cmd.Parameters.AddWithValue("@ID_Irigasi", idIrigasi);
                cmd.Parameters.AddWithValue("@ID_Petugas", idPetugas);
                cmd.Parameters.AddWithValue("@Tanggal_Monitoring", tanggalMonitoring);
                cmd.Parameters.AddWithValue("@PH_Air", phAir);
                cmd.Parameters.AddWithValue("@Kondisi_Air", kondisiAir);
                cmd.Parameters.AddWithValue("@Keterangan", keterangan);

                if (foto != null)
                    cmd.Parameters.Add("@pFoto", SqlDbType.VarBinary).Value = foto;
                else
                    cmd.Parameters.Add("@pFoto", SqlDbType.VarBinary).Value = DBNull.Value;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // =====================================
        // UPDATE
        // =====================================
        public void UpdateMonitoring(
            int idMonitoring,
            int idLahan,
            int idIrigasi,
            int idPetugas,
            DateTime tanggalMonitoring,
            decimal phAir,
            string kondisiAir,
            string keterangan,
            byte[] foto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd =
                    new SqlCommand("sp_UpdateMonitoring", conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Monitoring", idMonitoring);
                cmd.Parameters.AddWithValue("@ID_Lahan", idLahan);
                cmd.Parameters.AddWithValue("@ID_Irigasi", idIrigasi);
                cmd.Parameters.AddWithValue("@ID_Petugas", idPetugas);
                cmd.Parameters.AddWithValue("@Tanggal_Monitoring", tanggalMonitoring);
                cmd.Parameters.AddWithValue("@PH_Air", phAir);
                cmd.Parameters.AddWithValue("@Kondisi_Air", kondisiAir);
                cmd.Parameters.AddWithValue("@Keterangan", keterangan);

                if (foto != null)
                    cmd.Parameters.Add("@pFoto", SqlDbType.VarBinary).Value = foto;
                else
                    cmd.Parameters.Add("@pFoto", SqlDbType.VarBinary).Value = DBNull.Value;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // =====================================
        // DELETE
        // =====================================
        public void DeleteMonitoring(int idMonitoring)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd =
                    new SqlCommand("sp_DeleteMonitoring", conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@ID_Monitoring",
                    idMonitoring);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // =====================================
        // SEARCH (SENGAJA RENTAN SQL INJECTION)
        // =====================================
        public DataTable SearchMonitoring(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query =
                    "SELECT * FROM vw_MonitoringKualitasAir WHERE keterangan LIKE '%"
                    + keyword + "%'";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        // =====================================
        // HITUNG TOTAL
        // =====================================
        public int CountMonitoring()
        {
            using (SqlConnection conn =
                new SqlConnection(connectionString))
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "sp_CountMonitoring",
                        conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                SqlParameter outputParam =
                    new SqlParameter(
                        "@Total",
                        SqlDbType.Int);

                outputParam.Direction =
                    ParameterDirection.Output;

                cmd.Parameters.Add(outputParam);

                conn.Open();

                cmd.ExecuteNonQuery();

                return Convert.ToInt32(
                    outputParam.Value);
            }
        }

        // =====================================
        // SQL INJECTION DEMO
        // =====================================
        public int TestInjection()
        {
            using (SqlConnection conn =
                new SqlConnection(connectionString))
            {
                string query =
                    "UPDATE Petugas SET nama_petugas = 'HACKED'";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                conn.Open();

                return cmd.ExecuteNonQuery();
            }
        }

        // =====================================
        // RESET DATA
        // =====================================
        public void ResetData()
        {
            using (SqlConnection conn =
                new SqlConnection(connectionString))
            {
                string query = @"
UPDATE Petugas
SET nama_petugas = nama_asli
WHERE nama_asli IS NOT NULL;

UPDATE MonitoringKualitasAir
SET keterangan =
CASE
    WHEN id_monitoring = 1 THEN 'Air jernih'
    WHEN id_monitoring = 2 THEN 'Sedikit keruh'
    ELSE '-'
END,
ph_air =
CASE
    WHEN id_monitoring = 1 THEN 7.20
    WHEN id_monitoring = 2 THEN 6.80
    ELSE 7.00
END";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        // =====================================
        // CHART SEMUA DATA
        // =====================================
        public DataTable GetAllDataChart()
        {
            using (SqlConnection conn =
                new SqlConnection(connectionString))
            {
                string query = @"
        SELECT
            kondisi_air AS KondisiAir,
            COUNT(*) AS JumlahMonitoring
        FROM MonitoringKualitasAir
        GROUP BY kondisi_air";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, conn);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        // =====================================
        // CHART BERDASARKAN TAHUN
        // =====================================
        public DataTable GetDataChartByTahun(DateTime tanggal)
        {
            using (SqlConnection conn =
                new SqlConnection(connectionString))
            {
                string query = @"
        SELECT
            kondisi_air AS KondisiAir,
            COUNT(*) AS JumlahMonitoring
        FROM MonitoringKualitasAir
        WHERE YEAR(tanggal_monitoring)=@tahun
        GROUP BY kondisi_air";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@tahun",
                    tanggal.Year);

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}