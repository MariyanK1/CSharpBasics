using System;
class Program
{
    static void Main(string[] args)
    {
        int km = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();
        double price = 0;

        if (km < 20 && timeOfDay == "day")
        {
            price = 0.70 + 0.79 * km;
        }

        else if (km < 20 && timeOfDay == "night")
        {
            price = 0.70 + 0.90 * km;
        }

        if (km >= 20)
        {
            price = km * 0.09;

            if (km >= 100)
            {
                price = km * 0.06;

            }
        }

        Console.WriteLine($"{price:f2}");
    }
}
