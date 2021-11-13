using System;
using System.Collections.Generic;


namespace BassicProgrammingOOP
{
    class Program : Pelanggan
    {
        static void Main(string[] args)
        {
            int exit = 0;
            List<Pelanggan> Pel = new List<Pelanggan>();

            do
            {

                Console.WriteLine("************************************");
                Console.WriteLine("|    Program Sederhana STEAM       |");
                Console.WriteLine("*************************************");
                Console.WriteLine("|         STEAM CHUAKKS            |");
                Console.WriteLine("*************************************");
                Console.WriteLine("1. Daftar Pelanggan ");
                Console.WriteLine("2. Menampilkan Data Pelanggan ");
                Console.WriteLine("3. Hapus Data Pelanggan ");
                Console.WriteLine("4. Update");
                Console.WriteLine("5. Exit ");
                Console.WriteLine("*************************************");
                Console.WriteLine("\n");
                int c;
                Console.WriteLine("Pilihan anda");
                try
                {
                    c = int.Parse(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            Console.Clear();
                            DaftarPelanggan(Pel);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("————————————————————————————————————————");
                            Console.WriteLine("Anda memilih Tampilan Pelanggan Berdasarkan id");
                            Console.WriteLine("————————————————————————————————————————");
                            Console.Write("Input Id = ");
                            string id = Console.ReadLine();
                            TampilPelanggan(Pel,id);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 3:
                            Console.Clear();
                            HapusPelanggan(Pel);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 4:
                            Console.Clear();
                            UpdatePelanggan(Pel);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 5:
                            exit = 5;
                           /* Console.ReadLine();
                           *//* Console.Clear();*/
                            break;
                        default:
                            Console.WriteLine("Pilih Ulang");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Inputan Salah!!!!, ULANGI-->Tekan ENTER");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
            while (exit != 4);
        }


        public static void DaftarPelanggan(List<Pelanggan> Pel)
        {
            Console.Write("input id = ");
            string id = (Console.ReadLine());

            Console.Write(" input nama = ");
            string nama = (Console.ReadLine());

            Console.Write("Input Nomor Telephone : ");
            int nmr = int.Parse(Console.ReadLine());

            Console.Write("Input Alamat = ");
            string almt = (Console.ReadLine());

            Console.Write("Input jumlah  Mobil = ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Input jumlah  Motor = ");
            int k = int.Parse(Console.ReadLine());

            Pel.Add(new Pelanggan(id, nama, nmr, almt, m, k));
            Console.WriteLine();
        }
        public static void TampilPelanggan(List<Pelanggan> Pel, string id)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("|       Menu Tampilan Pelanggan      |");
            Console.WriteLine("======================================");

            foreach (var p in Pel)
            {
                if (id == p.IdPelanggan)
                {

                    Console.WriteLine($"Id Pelanggan : {p.IdPelanggan}");
                    Console.WriteLine($"Nama Pelanggan : {p.Nama}");
                    Console.WriteLine($"Nomor Telepon : {p.NoTelephone}");
                    Console.WriteLine($"Alamat Pelanggan : {p.Alamat}");
                    Console.WriteLine($"Mobil Pelanggan : {p.Mobil}");
                    Console.WriteLine($"Motor Pelanggan : {p.Motor}");
                    Console.WriteLine($"Total Kendaraan :  {p.TotalKendaraan}");
                    Console.WriteLine($"Total Harga Steam :  {p.TotalHarga}");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        public static void HapusPelanggan(List<Pelanggan> Pel)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("|      Menu Hapus Pelanggan           |");
            Console.WriteLine("=======================================");

            Console.Write("Input id : ");
            string a = Console.ReadLine();
            Console.WriteLine();

            foreach (var p in Pel)
            {
                if (a == p.IdPelanggan)
                {
                    Pel.Remove(p);
                    Console.WriteLine("Data pelanggan sudah dihapus");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public static void UpdatePelanggan(List<Pelanggan> Pel)
        {
            Console.WriteLine("————————————————————————————————————————");
            Console.WriteLine("Menu Update Pelanggan");
            Console.WriteLine("————————————————————————————————————————");

            Console.Write("Input id : ");
            string a = Console.ReadLine();

            foreach (var p in Pel)
            {
                if (a == p.IdPelanggan)
                {
                    Console.WriteLine($"Id Pelanggan : {p.IdPelanggan}");
                    Console.WriteLine($"Nama Pelanggan : {p.Nama}");
                    Console.WriteLine($"Nomor Telepon : {p.NoTelephone}");
                    Console.WriteLine($"Alamat Pelanggan : {p.Alamat}");
                    Console.WriteLine($"Jumlah Mobil  : {p.Mobil}");
                    Console.WriteLine($"Jumlah Motor : {p.Motor}");
                    Console.WriteLine($"Total Kendaraan :  {p.TotalKendaraan}");
                    Console.WriteLine($"Total Harga :  {p.TotalHarga}");
                    Console.WriteLine("\n");

                    Console.Write("Input Nomor Telepon = ");
                    p.NoTelephone = int.Parse(Console.ReadLine());

                    Console.Write("Input alamat = ");
                    p.Alamat = (Console.ReadLine());

                    Console.Write("Input tambah Mobil = ");
                    double tambahMobil = double.Parse(Console.ReadLine());

                    Console.Write("Input tambah Motor = ");
                    double tambahMotor = double.Parse(Console.ReadLine());

                    double z = (tambahMobil * 50000) + (tambahMotor * 20000);
                    Console.WriteLine($"z = {z}");
                    Console.WriteLine();

                    p.TotalKendaraan = p.TotalKendaraan + (tambahMobil + tambahMotor);
                    Console.WriteLine($"Total Kendaraan = {p.TotalKendaraan}");
                    Console.WriteLine();

                    p.TotalHarga = z + p.TotalHarga;
                    Console.WriteLine($"Total Harga = {p.TotalHarga}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

    }
}

 

       

