using System;
class Program
{
    static void Main(string[] args)
    {
        string fuel = Console.ReadLine();
        int liters = int.Parse(Console.ReadLine());
        
        if (fuel == "Diesel")
        {
             if (liters < 25)
            {
                Console.WriteLine("Fill your tank with diesel!");
            }

            else
            {
                Console.WriteLine("You have enough diesel.");
            }
        }

        if (fuel == "Gasoline")
        {
            if (liters < 25)
            {
                Console.WriteLine("Fill your tank with gasoline!");
            }

            else
            {
                Console.WriteLine("You have enough gasoline.");
            }
        }

        if (fuel == "Gas")
        {
            if (liters < 25)
            {
                Console.WriteLine("Fill your tank with gas!");
            }

            else
            {
                Console.WriteLine("You have enough gas.");
            }
        }

        if (fuel == "Kerosene")
        {
            Console.WriteLine("Invalid fuel!");
        }

       
    }
}
