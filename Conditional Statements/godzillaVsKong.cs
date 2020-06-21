/*Filming for the long-awaited film "Godzilla vs. Kong" begins. Screenwriter Adam Wingard asks you to
write a program to calculate whether the funds provided are sufficient for the shooting of the film.
The photos will require a certain number of extras, clothing for each extra and decor.
It is known that:
> The set for the film is worth 10% of the budget.
> For more than 150 extras, there is a 10% discount on clothing.
Input:
3 lines are read from the console:
Row 1. Budget for the film - a real number in the interval [1.00… 1000000.00]
Row 2. Number of extras - integer in the interval [1… 500]
Row 3. Price for clothing of one extra - real number in the interval [1.00… 1000.00]

Output:
Two lines should be printed on the console:
>>> If the money for decor and clothes is more than the budget:
"Not enough money!"
"Wingard needs {money not enough for the movie} leva more"
>>> If the money for decor and clothes is less than or equal to the budget:
"Action!"
"Wingard starts filming with {remaining money} left left."
The result must be formatted to the second decimal place.

Sample case:

In:
9587.88
222
55.68

Out:
Not enough money!
Wingard needs 2495.77 leva
more.*/


using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int mutesNumber = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            double decorPrice = 0.10 * movieBudget;
            double totalClothingPrice = clothingPrice * mutesNumber;

            if (mutesNumber > 150)
            {
                totalClothingPrice = totalClothingPrice - (0.10 * totalClothingPrice);
            }

            double totalMoney = totalClothingPrice + decorPrice;
            double moneyLeft = movieBudget - totalMoney;

            if (totalMoney > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(moneyLeft):f2} leva more.");
            }
            else if (totalMoney <= movieBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }

        }
    }
}
