using System;

namespace Tuan3
{
    class Program
    {
        public static int dequy(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * dequy(n - 1);
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("De quy: ");
            System.Console.WriteLine(dequy(4));
           
        }
    }
}
