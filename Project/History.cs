using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class History
    {
        public int no_makanan { get; set; }
        public int user_id { get; set; }
        public string nama_makanan { get; set; }
        public int jumlah { get; set; }
        public int harga { get; set; }
        public int total { get; set; }
        public DateTimeOffset waktu { get; set; }

        public History(int no_makanan, int user_id, string nama_makanan, int jumlah, int harga, int total, DateTimeOffset waktu)
        {
            this.no_makanan = no_makanan;
            this.user_id = user_id;
            this.nama_makanan = nama_makanan;
            this.jumlah = jumlah;
            this.harga = harga;
            this.total = total;
            this.waktu = waktu;
        }
    }
}
