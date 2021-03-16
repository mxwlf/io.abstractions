using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            _ = args;

            Console.WriteLine("Hello World!");
        }

        internal static int Sum(int a, int b)
        {
            return a + b;
        }
    }

}