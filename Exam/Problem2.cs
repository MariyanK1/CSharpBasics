/*
The Ivanovi family is planning their family vacation. Your task is to write a program that calculates whether 
their budget will be enough, knowing how many nights they have planned, what is the price per night and what 
percentage of the budget they have planned for additional costs. 

It should be borne in mind that if the number of 
nights is greater than 7, the price per night is reduced by 5%.


Input

4 lines are read from the console:
The budget they have - a real number in the range [1.00… 10000.00]
Number of nights - an integer in the interval [0… 1000]
Price per night - real number in the interval [1.00 [500.00]
Percentage for additional costs - integer in the range [0… 100]

Output

Printing the console depends on the result:
If the amount is sufficient:
"Ivanovi will be left with {leva money after the break} leva after vacation."
If the amount is NOT reached:
"{money needed to reach the goal} leva needed."
An amount must be formatted to the second digit after the decimal point.

Sample case:

In:
800.50
8
100
2

Out:
Ivanovi will be left with 24.49 leva after vacation.
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int nights = int.Parse(Console.ReadLine());
        double pricePerNight = double.Parse(Console.ReadLine());
        int percentExpenses = int.Parse(Console.ReadLine());

        if (nights > 7)
        {
            pricePerNight = pricePerNight * 0.95;
        }

        double totalPriceForNights = pricePerNight * nights;

        double additionalCosts = budget * (percentExpenses / 100.0);

        double totalPrice = totalPriceForNights + additionalCosts;

        if (totalPrice <= budget)
        {
            double moneyRest = budget - totalPrice;
            Console.WriteLine($"Ivanovi will be left with {moneyRest:f2} leva after vacation.");
        }

        else
        {
            double moneyNeed = totalPrice - budget;
            Console.WriteLine($"{moneyNeed:f2} leva needed.");
        }
    }
}
 
