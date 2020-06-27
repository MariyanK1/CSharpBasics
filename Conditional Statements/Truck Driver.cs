using System;
class Program
{
    static void Main(string[] args)
    {
        string season = Console.ReadLine();
        double kmMonth = double.Parse(Console.ReadLine());
        double price = 0.0;

        if (kmMonth <= 5000)
        {
            switch (season)
            {
                case "Spring":
                case "Autumn":
                    price = kmMonth * 0.75 * 4 * 0.90;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "Summer":
                    price = kmMonth * 0.90 * 4 * 0.90;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "Winter":
                    price = kmMonth * 1.05 * 4 * 0.90;
                    Console.WriteLine($"{price:f2}");
                    break;

                default:
                    break;
            }
        }

        else if (kmMonth > 5000 && kmMonth <= 10000)
        {
            switch (season)
            {
                case "Spring":
                case "Autumn":
                    price = kmMonth * 0.95 * 4 * 0.90;
                    Console.WriteLine($"{price:f2}");
                    break;

                case "Summer":
                    price = kmMonth * 1.10 * 4 * 0.90;
                    Console.WriteLine($"{price:f2}");
                    break;

                case "Winter":
                    price = kmMonth * 1.25 * 4 * 0.90;
                    Console.WriteLine($"{price:f2}");
                    break;

                default:
                    break;
            }
        }

        else if (kmMonth > 10000 && kmMonth <= 20000)
        {
            switch (season)
            {
                case "Spring":
                case "Autumn":
                case "Summer":
                case "Winter":
                    price = kmMonth * 1.45 * 4 * 0.90;
                    Console.WriteLine($"{price:f2}");
                    break;
                default:
                    break;
            }
        }
    }
}
