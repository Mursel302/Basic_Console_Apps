using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate void MyDelegate(int d);
     
        
        static void Main(string[] args)
        {
           // MyDelegate delegate1 = new MyDelegate(test1);
            MyDelegate delegate1 = new MyDelegate(test2);
            delegate1 += test3;

            delegate1.Invoke(333);
           
        }
          static void test1(int a)
        {
            Console.WriteLine("1-ci "+a);
        }
        static void test2(int b)
        {
            Console.WriteLine("2-ci "+b);
        }
        static void test3(int c)
        {
            Console.WriteLine("3-cu "+c);
        }
    }
}
