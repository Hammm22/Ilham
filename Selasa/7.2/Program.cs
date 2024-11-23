using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    class Siswa
    {
        public string nim;
        public string nama;
        public int n_UTS;
        public double IPK;

        public void cetak(String NamaSiswa)
        {
            this.nama = NamaSiswa;
            Console.WriteLine("\n namanya adalah {0} ", this.nama);
        }

        public void cetak(int nilai_uts)
        {
            this.n_UTS = nilai_uts;
            Console.WriteLine(" Nilai UTS {0} adalah {1} ", this.nama, this.n_UTS);
        }
        public void cetak(double IPK)
        {
            this.IPK = IPK;
            Console.WriteLine(" IPK {0} adalah {1} ", this.nama, this.IPK);
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Siswa siswa1 = new Siswa();

            siswa1.cetak("Hano Harafani");
            siswa1.cetak(70);
            siswa1.cetak(3.33);
            Console.Read();
        }
    }
}
