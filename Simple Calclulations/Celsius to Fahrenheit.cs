using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double total = (a * 9 / 5) + 32;
            Console.WriteLine($"{total:f2}");
        }
    }
}
