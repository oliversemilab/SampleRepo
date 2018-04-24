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

            float a = 5.6F;
            float b = 0;
            float c = 11.2F;
            Calc calc = new Calc();

            System.Console.WriteLine(a + " / " + b + " = " + "{0}", calc.Div(a, b));
            System.Console.WriteLine(a + " / " + c + " = " + "{0}", calc.Div(a, c));
            System.Console.WriteLine(b + " / " + a + " = " + "{0}", calc.Div(b, a));
            System.Console.WriteLine(b + " / " + c + " = " + "{0}", calc.Div(b, c));
            System.Console.WriteLine(c + " / " + a + " = " + "{0}", calc.Div(c, a));
            System.Console.WriteLine(c + " / " + b + " = " + "{0}", calc.Div(c, b));

            System.Console.ReadKey();
        }
    }
    interface ICalc
    {
        float Add(float a, float b);
        float Div(float a, float b);
        float DivB(float a, float b);
        float DivD(float a, float b);
        float Mult(float a, float b);
    }

    class Calc : ICalc
    {
        public float Add(float a, float b)
        {
            System.Console.WriteLine("add again");
            return a + b;
        }
        public float Div(float a, float b)
        {
            float result = 0;
            try
            {
                result = a / b;
                if (b == 0) { System.Console.WriteLine("OOPS: Division by 0 is allowed by " + a.GetType() + " Type variables"); }
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("Attempted division by 0 failed. Result set to 0");
            }
            return result;
        }
        public float DivB(float a, float b)
        {
            return a / b;
        }
        public float DivD(float a, float b)
        {
            return a / b + 1;
        }
        public float Mult(float a, float b)
        {
            return a * b;
        }
        public void DivByZero()
        {
            int a = 5;
            int b = 0;
            a/=b;
        }
    }

    class Book
    {
        float Length;
        float height;
    }
}