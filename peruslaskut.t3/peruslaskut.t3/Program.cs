using System;
using System.Numerics;

namespace peruslaskut.t3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(peruslaskut(8, 5));
        }
        private static string  peruslaskut(double x, double y)
        {
            return String.Format("{0}\n{1}\n{2}\n{3}", (x + y), (x - y), (x * y), (x / y));
        }
    }
}
