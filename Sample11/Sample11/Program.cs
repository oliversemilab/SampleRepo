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
        public static float Add(float a, float b)
        {
            return a + b;
        }
        public static float Div(float a, float b)
        {
            float result = 0;
            try
            {
                result = a / b;
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("Attempted division by 0 failed. Result set to 0");
            }
            return result;
        }
    }
}
