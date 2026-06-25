using System;

namespace MonitoringKualitasAir // Pastikan namespace SAMA dengan FormRekap
{
    public class DataReport
    {
        public int IDMonitoring { get; set; }
        public string NamaLahan { get; set; }
        public string NamaIrigasi { get; set; }
        public string NamaPetugas { get; set; }
        public DateTime TanggalMonitoring { get; set; }
        public decimal PHAir { get; set; }
        public string KondisiAir { get; set; }
        public string Keterangan { get; set; }
     
    }
}