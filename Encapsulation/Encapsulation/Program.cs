using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Emlak menzil = new Emlak();
            menzil.UNVANI = "BIne qesebesi, Xeqani kucesi ,Donge 1 , Ev 16";
            menzil.SAHESI = 166.8;
            menzil.RENGI = "Ag";
            menzil.MERTEBESI = 2;
            menzil.OTAQSAYI = 6;

            Console.WriteLine("Unvani "+menzil.UNVANI);
            Console.WriteLine("Sahesi "+menzil.SAHESI);
            Console.WriteLine("Rengi "+menzil.RENGI);
            Console.WriteLine("Mertebesi "+menzil.MERTEBESI);
            Console.WriteLine("Otaqsayi "+menzil.OTAQSAYI);
        }
    }
}
