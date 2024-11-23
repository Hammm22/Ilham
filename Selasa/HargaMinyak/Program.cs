using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HargaMinyak
{
    class Program
    {
        static void Main(string[] args)
        {
            float satuan, harga, bayar;
            Console.WriteLine("Program Perhitungan harga minyak");
            Console.Write("Masukkan harga Takaran minyak per liter: ");
            satuan = float.Parse(Console.ReadLine());

            harga = (100000 / 20);
            bayar = harga * satuan;
            Console.WriteLine("Harga minyak per liter: {0} dan bayar: {1}", harga, bayar);
            Console.ReadKey();
        }
    }
}
