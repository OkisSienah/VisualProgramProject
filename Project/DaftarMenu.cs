using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class DaftarMenu
    {
        public int no_makanan { get; set; }
        public string nama_makanan { get; set; }
        public int harga { get; set; }

        public DaftarMenu(int no_makanan, string nama_makanan, int harga)
        {
            this.no_makanan = no_makanan;
            this.nama_makanan = nama_makanan;
            this.harga = harga;
        }
    }
}
