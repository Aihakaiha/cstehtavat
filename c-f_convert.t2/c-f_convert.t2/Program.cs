using System;

namespace c_f_convert.t2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(convert(10));
        }

        private static double convert(double c)
        {
            return c * 1.8 + 32;
        }
    }
}
