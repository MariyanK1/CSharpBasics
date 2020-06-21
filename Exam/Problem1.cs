/*
The teaching team of SoftUni organizes a working day at the pool on the occasion of summer. 
Your task is to write a program that calculates how much should be paid. 

An entrance fee must be paid for each member of the team. You have to keep in mind that one umbrella is enough for two people. 
It is known that only 75% of the team want sunbeds. When calculating the number of umbrellas and sunbeds, 
their number should be rounded up to the larger integer.

Input
4 numbers are read from the console:
First row - number of people. Integer in the interval [1… 100]
Second row - entrance fee. Real number in the interval [0.00… 50.00]
Third row - price one for a deck chair. Real number in the interval [0.00… 50.00]
Fourth row - price for one umbrella. Real number in the interval [0.00 ... 50.00]

Output
"{cost amount} lv."
Format the result to the second digit after the decimal point.

Sample case:

In:
50
6
8
4

Out:
704.00 lv.
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int numOfPeople = int.Parse(Console.ReadLine());
        double entranceTax = double.Parse(Console.ReadLine());
        double pricePerDeckchair = double.Parse(Console.ReadLine());
        double priceForUmbrella = double.Parse(Console.ReadLine());

        double sumFromTax = numOfPeople * entranceTax;
        
        double deckchairsNeeded = Math.Ceiling(numOfPeople * 0.75);
        double sumOfDeckchairs = deckchairsNeeded * pricePerDeckchair;

        double umbrellasNeeded = Math.Ceiling(numOfPeople * 0.5);
        double sumOfUmbrellas = umbrellasNeeded * priceForUmbrella;

        double totalSum = sumFromTax + sumOfDeckchairs + sumOfUmbrellas;

        Console.WriteLine($"{totalSum:f2} lv.");

    }
}
