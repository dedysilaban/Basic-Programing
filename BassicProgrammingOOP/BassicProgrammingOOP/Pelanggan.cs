using System;
using System.Collections.Generic;
using System.Text;

namespace BassicProgrammingOOP
{
    class Pelanggan
    {
        public string IdPelanggan { get; set; }
        public string Nama { get; set; }
        public int NoTelephone { get; set; }
        public string Alamat { get; set; }
        public int Mobil { get; set; }
        public int Motor { get; set; }
        public double TotalHarga { get; set; }
        public double TotalKendaraan { get; set; }

   /*     public int T = 50000  ;
        public int M = 20000  ;
*/
        public double total;
        public Pelanggan()
        {

        }

        public Pelanggan(string idPel, string namaPel, int noTel, string alamatPel, int mbl, int mtr )
        {
            this.IdPelanggan = idPel;
            this.Nama = namaPel;
            this.NoTelephone = noTel;
            this.Alamat = alamatPel;
            this.Mobil = mbl;
            this.Motor = mtr;
            this.TotalHarga = HitungHarga(mbl,mtr);
            this.TotalKendaraan = HitungKdr(mbl, mtr);

        }
        public double HitungHarga(int mbl, int mtr)
        {
            total = (this.Mobil * 50000)+(this.Motor * 20000);
            return total;
        }
        public double HitungKdr(int mbl, int mtr)
        {
            total = this.Mobil + this.Motor;
            return total;
        }
    }
}