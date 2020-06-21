/*
The weather is warming up and the clubs are releasing promising promotions. 
Write a program that calculates the income of a club for the evening and whether 
the desired profit has been reached, knowing the following conditions: 
the price of a cocktail is the length of its name. If the price of an order is an odd number, 
there is a 25% discount on the price of the order.

Input
From the console read:
On the first line - the desired profit of the club - a real number in the interval [1.00 ... 15000.00]
A series of two lines to receive the command "Party!" or until the desired profit is reached:
Name of the cocktail - text
Number of cocktails for the order - integer in the interval [1… 50]

Output
First print a line on the console:
When the "Party!" Command is received:
 "We need {missing amount} leva more."

Upon reaching the desired profit:
"Target acquired."
Then print:
"Club income - {club income} leva."
The money should be formatted to the second digit after the decimal point.


Sample case:

In:

500
Bellini
6
Bamboo
7
Party!

Out:

We need 416.00 leva more.
Club income - 84.00 leva.
*/

using System;
class Program 
{
    static void Main()
    {
        double targetIncome = double.Parse(Console.ReadLine());
        string nameOfCoctail = Console.ReadLine();

        double coctailPrice = 0;
        double sum = 0;

        while (nameOfCoctail != "Party!")
        {
            int numOfCoctails = int.Parse(Console.ReadLine());
            int price = numOfCoctails * nameOfCoctail.Length;
            double finalPrice = price;

            if (price % 2 != 0)
            {
                finalPrice *= 0.75;//25
            }

            sum += finalPrice;
            targetIncome -= finalPrice;

            if (targetIncome <= 0)
            {
                break;
            }

            nameOfCoctail = Console.ReadLine();
        }

        if (nameOfCoctail == "Party!")
        {
            Console.WriteLine($"We need {targetIncome:f2} leva more.");
            Console.WriteLine($"Club income - {sum:f2} leva.");
        }

        else
        {
            Console.WriteLine("Target acquired.");
            Console.WriteLine($"Club income - {sum:f2} leva.");
        }
    }
}
