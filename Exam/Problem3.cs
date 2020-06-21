/*
Write software to calculate the bill of a customer who bought a certain number of drinks from a coffee machine.

                Sugar free     Normal           Extra sugar
Espresso        BGN 0.90 / pc. |BGN 1 / pc.     | BGN 1.20 / pc.
Cappuccino      BGN 1.00 / pc. |BGN 1.20 / pc.  | BGN 1.60 / pc.
Tea             BGN 0.50 / pc. |BGN 0.60 / pc.  | BGN 0.70 / pc.

You should keep in mind the following discounts:
There is a 35% discount for a sugar-free drink.
For selected drink "Espresso" and purchased at least 5 pieces, there is a 25% discount.
If the amount exceeds BGN 15, 20% discount from the final price,
Discounts are applied in the order of their description.

Input
The input is read from the console and consists of three lines:
First line - drink - text with options "Espresso", "Cappuccino" or "Tea"
Second line - sugar - text with "Without", "Normal" or "Extra" options
Third row - number of drinks - integer in the interval [1… 50]

Output
One line should be printed on the console:
"You bought {number of drinks} cups of {drink} for {final price} lv."
The price should be formatted to the second digit after the decimal point.

Sample case:

In:

Espresso
Without
10

Out:
You bought 10 cups of Espresso for 4.39 lv.
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        string drinkName = Console.ReadLine();
        string sugar = Console.ReadLine();
        int drinkNum = int.Parse(Console.ReadLine());
        double price = 0;
        switch (drinkName)
        {
            case "Espresso":
                switch (sugar)
                {
                    case "Without":
                        price += 0.90 * 0.65 * drinkNum;
                        break;
                    case "Normal":
                        price += 1 * drinkNum;
                        break;
                    case "Extra":
                        price += 1.20 * drinkNum;
                        break;
                }
                if (drinkNum > 5)
                {
                    price *= 0.75;
                }
                break;

            case "Cappuccino":
                switch (sugar)
                {
                    case "Without":
                        price += 1 * 0.65 * drinkNum;
                        break;
                    case "Normal":
                        price += 1.20 * drinkNum;
                        break;
                    case "Extra":
                        price += 1.60 * drinkNum;
                        break;
                }
                break;

            case "Tea":
                switch (sugar)
                {
                    case "Without":
                        price += 0.50 * 0.65 * drinkNum;
                        break;
                    case "Normal":
                        price += 0.60 * drinkNum;
                        break;
                    case "Extra":
                        price += 0.70 * drinkNum;
                        break;
                }
                break;
        }

        if (price > 15)
        {
            price *= 0.80;
        }

        Console.WriteLine($"You bought {drinkNum} cups of {drinkName} for {price:f2} lv.");
    }

}
