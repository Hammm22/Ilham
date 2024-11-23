using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komisi_tukar_uang
{
    class aplikasi
    {
        static void Main(string[] args)
        {
            int tukar1, tukar2, komisi, jumlah, lembar, sisa;
            Console.WriteLine("Program Tukar uang");
            Console.Write("Masukkan Tukar pertama: ");
            tukar1 = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Tukar Kedua: ");
            tukar2 = int.Parse(Console.ReadLine());

            komisi = (tukar1 * 10) / 100;
            jumlah = tukar1 - komisi;

            lembar = jumlah / tukar2;
            sisa = jumlah - (lembar * tukar2);
            Console.WriteLine("komisi {0} dan Lembar {1} sisa= {2}", komisi, lembar, sisa);
        }
    }31
}