using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiktortgenNesneOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(13, 40);
            Console.WriteLine("Diktörtgeenin Alanı = " + dikdortgen.AlanHesapla());
            Console.WriteLine("Diktörtgeenin Çevresi = " + dikdortgen.CevreHesapla());

        }
    }
    class Dikdortgen
    {
        private uint kisaKenar,uzunKenar;
        public Dikdortgen(uint kisaKenar, uint uzunKenar)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }
        public uint AlanHesapla()
        {
            return kisaKenar * uzunKenar;
        }
        public uint CevreHesapla()
        {
            return 2 * (kisaKenar + uzunKenar);
        }
    }

}
