using System;
using System.Collections.Generic;

namespace laundry
{
    class Program 
    {
        static void Main(string[] args)
        {
            int exit = 0;
            var nama = new List<string>();
            var totalkendaraan = new List<double>();
            var totalharga = new List<double>();
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
                            daftar(nama, totalkendaraan, totalharga);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            tampil(nama, totalkendaraan, totalharga);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 3:
                            Console.Clear();
                            hapus(nama, totalkendaraan, totalharga);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Pilih Ulang");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.WriteLine("Inputan Salah!!!!, ULANGI-->Tekan ENTER");
                    Console.ReadLine();
                    Console.Clear();
                } 
               
            }
            while (exit != 3);
        }
        static void daftar(List<string>nama, List<double> totalkendaraan, List<double> totalharga)
        {
            double M, K, b, T;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|        Menu Daftar Pelanggan       |");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Input Nama : ");
            nama.Add(Console.ReadLine());

            Console.WriteLine("Input Total Kendaraan Mobil : ");
            M = double.Parse(Console.ReadLine());

            Console.WriteLine("Input Total Kendaraan Motor : ");
            K = double.Parse(Console.ReadLine());
            b = K + M;
            totalkendaraan.Add(b);

            T = (M * 50000) + (K * 20000);
            Console.WriteLine("Total Harga : " + T.ToString());
            totalharga.Add(T);

            Console.WriteLine();
            Console.WriteLine("Tekan ENTER untuk kembali ke Menu");
        }
        static void tampil(List<string>nama, List<double> totalkendaraan,  List<double> totalharga)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("|       Menu Tampilan Pelanggan      |");
            Console.WriteLine("======================================");

            for (int i = 0; i < nama.Count; i++)
            {
                Console.WriteLine("Nama Pelanggan : "+nama[i]);
                Console.WriteLine("Total Total Kendaraan : " + totalkendaraan[i]);
                Console.WriteLine("Total Harga STEAM :" + totalharga[i]);
                Console.WriteLine("\n");
            }
            Console.WriteLine();
            Console.WriteLine("Tekan ENTER untuk kembali ke Menu");
          /*  Console.ReadLine();*/
        }
        static void hapus(List<string> nama,  List<double> totalkendaraan, List<double> totalharga)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("|      Menu Hapus Pelanggan           |");
            Console.WriteLine("=======================================");

            Console.WriteLine("input nama : ");
            string a = Console.ReadLine();

            for (int i = 0; i < nama.Count; i++)
            {
                if(a == nama[i])
                {
                    nama.RemoveAt(i);
                    totalkendaraan.RemoveAt(i);
                    totalharga.RemoveAt(i);
                    Console.WriteLine();
                    Console.WriteLine("Data pelanggan sudah dihapus");
                    Console.WriteLine();
                    break;
                }
                else if (a != nama[i])
                {
                    Console.WriteLine("ID karyawan Tidak Ditemukan");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tekan ENTER untuk kembali ke Menu");
            /*Console.ReadLine();*/
        }
    }
}