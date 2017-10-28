using System;
namespace Class_Overload_Struct_Constructor_etc_
{
    class Program
    {
        static void Main(string[] args)
        {
            Masin masin1 = new Masin("BMW","E60");
            masin1.MuherrikiIseSal();
            masin1.BenzinAl();

            Masin masin2 = new Masin("VAZ","21 06");
            masin2.BenzinAl(16);
        }
    }
}