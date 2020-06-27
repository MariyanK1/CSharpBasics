using System;
class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string destination = Console.ReadLine();
        string season = Console.ReadLine();
        int numDays = int.Parse(Console.ReadLine());

        double price = 0.0;

        switch (destination)
        {
            case "Dubai":
                switch (season)
                {
                    case "Winter":
                        price = numDays * 45000 * 0.70;
                        break;
                    case "Summer":
                        price = numDays * 40000 * 0.70;
                        break;
                    default:
                        break;
                }
                break;

            case "Sofia":
                
                switch (season)
                {
                    case "Winter":
                        price = numDays * 17000 * 1.25;
                                 break;
            
                        case "Summer":
                
                        price = numDays * 12500 * 1.25;
                
                        break;
                }

                break;

            case "London":
                switch (season)
                {
                    case "Winter":
                        price = numDays * 24000;
                        break;
                    case "Summer":
                        price = numDays * 20250;
                        break;
                    default:
                        break;
                }
                break;
        }


        if (budget >= price)
        {
            Console.WriteLine($"The budget for the movie is enough! We have {budget - price:f2} leva left!");
        }

        else
        {
            Console.WriteLine($"The director needs {price - budget:f2} leva more!");
        }



    }
}
