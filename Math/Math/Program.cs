using System;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Returns Max
            Console.WriteLine("Total 1 : " + Math.Max(1, 2));
            //Returns Minimum
            Console.WriteLine("Total 2 : " + Math.Min(1, 2));
            //Returns Square Root of Parameter
            Console.WriteLine("Total 3 : " + Math.Sqrt(100));
            //Returns Absolute Positive Value of Parameter
            Console.WriteLine("Total 4 : " + Math.Abs(-5.5));
            //Rounds Value to nearest whole number of Parameter
            Console.WriteLine("Total 5 : " + Math.Round(5.6));
        }
    }
}
