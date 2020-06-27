using System;
class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        double price = 0.0;

        if (budget <= 1000)
        {
            switch (season)
            {
                case "Summer":
                    price = budget * 0.65;
                    Console.WriteLine($"Alaska - Camp - {price:f2}");
                    break;
                case "Winter":
                    price = budget * 0.45;
                    Console.WriteLine($"Morocco - Camp - {price:f2}");
                    break;

                default:
                    break;
            }
        }

        else if (budget > 1000 && budget <= 3000)
        {
            switch (season)
            {
                case "Summer":
                    price = budget * 0.80;
                    Console.WriteLine($"Alaska - Hut - {price:f2}");
                    break;
                case "Winter":
                    price = budget * 0.60;
                    Console.WriteLine($"Morocco - Hut - {price:f2}");
                    break;

                default:
                    break;
            }
        }

        else
        {
            switch (season)
            {
                case "Summer":
                    price = budget * 0.90;
                    Console.WriteLine($"Alaska - Hotel - {price:f2}");
                    break;

                case "Winter":
                    price = budget * 0.90;
                    Console.WriteLine($"Morocco - Hotel - {price:f2}");
                    break;

                default:
                    break;
            }
        }
    }
}
