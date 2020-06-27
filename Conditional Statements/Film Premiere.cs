using System;
class Program
{
    static void Main(string[] args)
    {
        string movieName = Console.ReadLine();
        string snack = Console.ReadLine();
        int ticketsNum = int.Parse(Console.ReadLine());
        double price = 0.0;

        if (ticketsNum >= 4 && movieName == "Star Wars")
        {
            switch (snack)
            {
                case "Drink":
                    price = ticketsNum * 18 * 0.70;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;
                case "Popcorn":
                    price = ticketsNum * 25 * 0.70;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;
                case "Menu":
                    price = ticketsNum * 30 * 0.70;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;

                default:
                    break;
            }
        }

        else if (ticketsNum < 4 && movieName == "Star Wars")
        {
            switch (snack)
            {
                case "Drink":
                    price = ticketsNum * 18;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;
                case "Popcorn":
                    price = ticketsNum * 25;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;
                case "Menu":
                    price = ticketsNum * 30;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;

                default:
                    break;
            }
        }

        else if (ticketsNum == 2 && movieName == "Jumanji")
        {
            switch (snack)
            {
                case "Drink":
                    price = ticketsNum * 9 * 0.85;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;
                case "Popcorn":
                    price = ticketsNum * 11 * 0.85;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;
                case "Menu":
                    price = ticketsNum * 14 * 0.85;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;

                default:
                    break;
            }
        }


        else if (ticketsNum < 2 || ticketsNum > 2 && movieName == "Jumanji")
        {
            switch (snack)
            {
                case "Drink":
                    price = ticketsNum * 9 ;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;
                case "Popcorn":
                    price = ticketsNum * 11;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;
                case "Menu":
                    price = ticketsNum * 14;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;

                default:
                    break;
            }
        }
        else if (movieName == "John Wick")
        {
            switch (snack)
            {
                case "Drink":
                    price = ticketsNum * 12;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;
                case "Popcorn":
                    price = ticketsNum * 15;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;
                case "Menu":
                    price = ticketsNum * 19;
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;

                default:
                    break;
            }
        }
    }
}
