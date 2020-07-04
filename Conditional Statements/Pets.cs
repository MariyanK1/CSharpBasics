using System;
class Program
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        int leftFood = int.Parse(Console.ReadLine());
        double foodForDog = double.Parse(Console.ReadLine());
        double foodForCat = double.Parse(Console.ReadLine());
        double foorForTortoise = double.Parse(Console.ReadLine());

        double totalFood = foodForCat * days + foodForDog * days + (foorForTortoise * days / 1000);

        if (leftFood >= totalFood)
        {
            Console.WriteLine($"{Math.Floor(leftFood - totalFood)} kilos of food left.");
        }

        else
        {
            Console.WriteLine($"{Math.Ceiling(totalFood - leftFood)} more kilos of food are needed.");
        }
    }
}
