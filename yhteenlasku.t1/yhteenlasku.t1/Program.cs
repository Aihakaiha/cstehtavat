using System;
using System.Security.Cryptography.X509Certificates;

namespace yhteenlasku.t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(yhteenlasku(1,2));
        }
        static private int yhteenlasku(int x, int y)
        {
            return x + y;
        }
    }
}
