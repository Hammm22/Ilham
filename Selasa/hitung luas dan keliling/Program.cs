using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luas_Keliling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_________________");
            Console.WriteLine("Program untuk Menghitung: ");
            Console.WriteLine("1.Bujur Sangkar");
            Console.WriteLine("2.Persegi Panjang");
            Console.WriteLine("3.Lingkaran");
            Console.WriteLine("_________________");
            Console.Write("\n");
            String c;
            double r, L, K, p, l, s;
            Console.Write("Pilihan anda: ");
            c = Console.ReadLine();
            if (c == "1")
            {
                Console.WriteLine("Anda memilih Bujur Sangkar");
                Console.WriteLine("Pilih Mau Menghitung Luas atau Keliling??");
                Console.WriteLine("A.Luas");
                Console.WriteLine("B.Keliling");
                Console.Write("Saya Memilih: ");
                c = Console.ReadLine();
                if (c == "A")
                {
                    Console.WriteLine("Anda Memilih Luas Bujur Sangkar");
                    Console.WriteLine("Masukkan Sisi nya");
                    s = double.Parse(Console.ReadLine());
                    L = s * s;
                    Console.WriteLine("Luas Bujur Sangkar: " + L.ToString());
                }
                else if (c == "B")
                {
                    Console.WriteLine("Anda Memilih Keliling Bujur Sangkar");
                    Console.WriteLine("Masukkan Sisi nya");
                    s = double.Parse(Console.ReadLine());
                    K = 4 * s;
                    Console.WriteLine("Keliling Bujur sangkar: " + K.ToString());
                }
                else
                {
                    Console.WriteLine("Silahkan pilih yang benar!!!");
                }

            }
            else if (c == "2")
            {
                Console.WriteLine("Anda Memilih Persegi Panjang");
                Console.WriteLine("Mau Hitung Luas Atau Keliling?");
                Console.WriteLine("A.Luas");
                Console.WriteLine("B.Keliling");
                Console.Write("Saya Memilih: ");
                c = Console.ReadLine();
                if (c == "A")
                {
                    Console.WriteLine("Anda Memilih Luas Persegi Panjang");
                    Console.WriteLine("Masukkan Panjangnya");
                    p = double.Parse(Console.ReadLine());
                    Console.WriteLine("Masukkan Lebarnya");
                    l = double.Parse(Console.ReadLine());

                    L = p * l;
                    Console.WriteLine("Luas Persegi Panjangnya yaitu: " + L.ToString());
                }
                else if (c == "B")
                {
                    Console.WriteLine("Anda Memilih Keliling Persegi Panjang");
                    Console.WriteLine("Masukan Panjangnya");
                    p = double.Parse(Console.ReadLine());
                    Console.WriteLine("Masukkan Lebarnya");
                    l = double.Parse(Console.ReadLine());
                    K = 2 * (p + l);
                    Console.WriteLine("Keliling Persegi Panjangnya adalah: " + K.ToString());
                }

            }
            else if (c == "3")
            {
                Console.WriteLine("Anda Memilih Lingkaran");
                Console.WriteLine("Pilih Mau Hitung Luas atau Keliling?");
                Console.WriteLine("A.Luas");
                Console.WriteLine("B.Keliling");
                Console.Write("Saya Memilih: ");
                c = Console.ReadLine();

                if (c == "A")
                {
                    Console.WriteLine("Anda Memilih Luas Lingkaran");
                    Console.WriteLine("Masukkan Jari2 nya");
                    r = double.Parse(Console.ReadLine());
                    L = 22 * r * r / 7;
                    Console.WriteLine("Luas lingkaran dengan nilai Phi 22/7: " + L.ToString());
                    Console.WriteLine("Atau");
                    L = 3.14 * r * r;
                    Console.WriteLine("Luas lingkaran dengan nilai Phi 3.14: " + L.ToString());
                }
                else if (c == "B")
                {
                    Console.WriteLine("Anda Memilih Keliling Lingkaran");
                    Console.Write("Masukkan Jari2 nya");
                    r = double.Parse(Console.ReadLine());
                    K = 22 * 2 * r / 7;
                    Console.WriteLine("Keliling lingkaran dengan nilai Phi 22/7: " + K.ToString());
                    Console.WriteLine("Atau");
                    K = 3.14 * 2 * r;
                    Console.WriteLine("Keliling lingkaran dengan nilai Phi 3.14: " + K.ToString());
                }
            }
            else
            {
                Console.WriteLine("Pilih yang bener!!");
            }
            Console.Write("\n");
            Console.WriteLine("Terima Kasih");
            Console.ReadKey();
        }
    }
}
