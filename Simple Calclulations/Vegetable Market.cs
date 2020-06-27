using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerKgVeggies = double.Parse(Console.ReadLine());
            double PricePerKgFruits = double.Parse(Console.ReadLine());
            int totalKgVeggies = int.Parse(Console.ReadLine());
            int totalKgFruits = int.Parse(Console.ReadLine());
            double total = 0;
            total = (pricePerKgVeggies * totalKgVeggies + PricePerKgFruits * totalKgFruits) / 1.94;

            
            Console.WriteLine($"{total:f2}");
        }
    }
}
