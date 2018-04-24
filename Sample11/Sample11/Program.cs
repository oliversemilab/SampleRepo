using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writes hello world message to the console
            System.Console.WriteLine("Hello World");
            System.Console.ReadKey();
        }
    }

    class CoCalc
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
