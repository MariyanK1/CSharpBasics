using System;
class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int people = int.Parse(Console.ReadLine());
        double transport = 0.0;
        double priceAllTicket = 0.0;
        double priceVIP = 499.99;
        double priceNormal = 249.99;

        if (people >= 1 && people <= 4)
        {
            transport = 0.75;
        }

        else if (people >= 5 && people <= 9)
        {
            transport = 0.60;
        }

        else if (people >= 10 && people <= 24)
        {
            transport = 0.50;
        }

        else if (people >= 25 && people <= 49)
        {
            transport = 0.40;
        }

        else if (people >= 50)
        {
            transport = 0.25;
        }

        budget = budget - (budget * transport);

        if (category == "Normal")
        {
            priceAllTicket = priceNormal * people;
        }

        else if (category == "VIP")
        {
            priceAllTicket = priceVIP * people;
        }

        if (budget >= priceAllTicket)
        {
            Console.WriteLine($"Yes! You have {(budget - priceAllTicket):F2} leva left.");
        }

        else
        {
            Console.WriteLine($"Not enough money! You need {(priceAllTicket - budget):F2} leva.");
        }
    }
}
