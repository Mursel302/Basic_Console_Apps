using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Telebe telebe01 = new Telebe();
            Console.WriteLine("Adi Daxil Edin");
            telebe01.ADI = Console.ReadLine();
            Console.WriteLine("Soyadi Daxil Edin");
            telebe01.SOYADI = Console.ReadLine();
            Console.WriteLine("Ixtisasi Daxil Edin");
            telebe01.IXTISASI = Console.ReadLine();
            Console.WriteLine("Yasi Daxil Edin");
            telebe01.YASI = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Telebenin adi "+telebe01.ADI);
            Console.WriteLine("Telebenin soyadi "+telebe01.SOYADI);
            Console.WriteLine("Telebenin ixtisasi "+telebe01.IXTISASI);
            Console.WriteLine("Telebenin yasi "+telebe01.YASI);
        }
    }
}
