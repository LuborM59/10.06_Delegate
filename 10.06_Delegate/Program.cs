using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Delegate
{
    delegate int MyDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(10, 20));

            MyDelegate d = new MyDelegate(Sum);
            Console.WriteLine(d(30, 40));
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
