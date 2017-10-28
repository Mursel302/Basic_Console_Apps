using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Overload_Struct_Constructor_etc_
{
    class Masin
    {
       public Masin()
       {
            
       }
        public Masin(string Marka,string model)
        {
        Console.WriteLine(string.Format("{0} markasinda ve {1} modelinde yeni avtomobil yaratdiniz",Marka,model));
        }
        public void MuherrikiIseSal()
        {
           Console.WriteLine( "Muherrik ise Salindi");
        } 
         public void BenzinAl()
         {
           Console.WriteLine("Benzin baki tam dolduruldu...");
         }
         public void BenzinAl(byte litr)
         {
           Console.WriteLine(string.Format("Avtomobilinize {0} litr benzin elave etdiniz...",litr));
         }
     }
}
