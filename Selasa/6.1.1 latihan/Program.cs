using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._1
{
    class Virus
    {
        public string nama;
        public int size;
        public string kemampuan;
        public int banyak;

        public void Menyerang() {
            Console.WriteLine(" {0} menyerang dengan {1} ", this.nama, this.kemampuan);
        }

        public void MemperbanyakDiri()
        {
            Console.WriteLine(" {0} memperbanyak file hingga {1} kali", this.nama, this.banyak);
        }
    }

    class Trojan
    {
        public string nama;
        public int size;
        public string kemampuan;

        public void Menyerang()
        {
            Console.WriteLine(" {0} menyerang dengan {1}", this.nama, this.kemampuan);
        }

        public void MenyembunyikanFile()
        {
            Console.WriteLine(" {0} Menyembunyikan File", this.nama);
        }

        public void MemblokirCMD()
        {
            Console.WriteLine(" {0} Memblokir aktivitas CMD", this.nama);
        }
    }

    class Worm
    {
        public string nama;
        public int size;
        public string kemampuan;
        public void Menyerang()
        {
            Console.WriteLine(" {0} menyerang dengan {1}", this.nama, this.kemampuan);
        }

        public void MenginfeksiRegistry()
        {
            Console.WriteLine(" {0} menginfeksi registry", this.nama);
        }

        public void MenghapusNTLDR()
        {
            Console.WriteLine(" {0} mengapus NTLDR", this.nama);
        }
    
    
    }


    class Program
    {
        static void Main(string[] args)
        {
            Virus virus1 = new Virus();
            Trojan trojan1 = new Trojan();
            Worm worm1 = new Worm();

            virus1.nama = "Sality32.exe";
            virus1.size = 32;
            virus1.kemampuan = "Menghapus file penting";
            trojan1.nama = "BackdoorWin32.exe";
            trojan1.size = 14;
            trojan1.kemampuan = "Shutdown setiap 30 menit";
            worm1.nama = "Brontox.exe";
            worm1.size = 23;
            worm1.kemampuan = "Sleep setiap 15 menit";

            Console.WriteLine("\n nama virus: {0} kapasita {1} Mb", virus1.nama, virus1.size);
            Console.WriteLine(" Nama Trojan: {0} kapasitas {1} Mb", trojan1.nama, trojan1.size);
            Console.WriteLine(" Nama Worm: {0} kapasitas {1} Mb", worm1.nama, worm1.size);

            virus1.Menyerang();
            virus1.MemperbanyakDiri();
            trojan1.Menyerang();
            trojan1.MenyembunyikanFile();
            trojan1.MemblokirCMD();
            worm1.Menyerang();
            worm1.MenginfeksiRegistry();
            worm1.MenghapusNTLDR();
            Console.Read();
    
        }
    }
    
}
