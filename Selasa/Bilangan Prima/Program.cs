using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilangan_Prima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka;
            int i, x;
            Console.WriteLine("Program sederhana Bilangan Prima");
            Console.Write("Masukkan Angka: ");
            angka = int.Parse(Console.ReadLine());
            if (angka == 1)
            {
                Console.WriteLine("Bukan bilangan Prima");
            }
            else if (angka == 2)
            {
                Console.WriteLine("Bilangan Prima");
            }
            else
            {
                for (i = 2; i < angka; i++)
                {
                    x = angka % i;

                    if (x == 0)
                    {
                        Console.WriteLine("Bukan Bilangan Prima");
                        Console.Read();
                    }
                }
                Console.WriteLine("Bilangan Prima");
            }
            Console.ReadKey();
        }
    }
}
