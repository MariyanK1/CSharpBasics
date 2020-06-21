/*
A computer game store hires you to make statistics on the percentage of games sold in the last month, 
by calculating what percentage of total sales are for any of the games.
T
he percentages should be divided into four parts, three game titles and everything else:
Hearthstone
Fornite
Overwatch
Others


Input
From the console read:
Number of games sold - n - positive integer in the range [1… 100]
For the next n lines, read one line at a time:
Game name - text

Output
Write four lines on the console:
"Hearthstone - {percentage of Hearthstone sales}%"
"Fornite - {percentage of Fornite sales}%"
"Overwatch - {percentage of Overwatch sales}%"
"Others - {percentage of sales of all other games}%"
The result should be rounded to the second digit after the decimal point.

Sample case:

In:
4
Hearthstone
Fornite
Overwatch
Counter-Strike

Out:

Hearthstone - 25.00%
Fornite - 25.00%
Overwatch - 25.00%
Others - 25.00%
*/


using System;
class Program 
{
    static void Main()
    {
        double gamesSold = double.Parse(Console.ReadLine());
        double hearthStone = 0;
        double fortnite = 0;
        double overwatch = 0;
        double others = 0;

        for (int i = 1; i <= gamesSold; i++)
        {
            string gameName = Console.ReadLine();

            if (gameName == "Hearthstone")
            {
                hearthStone++;
            }

            else if (gameName == "Fornite")
            {
                fortnite++;
            }

            else if (gameName == "Overwatch")
            {
                overwatch++;
            }

            else
            {
                others++;
            }
        }

        Console.WriteLine($"Hearthstone - {hearthStone *  1.0 * 100 / gamesSold:f2}%");
        Console.WriteLine($"Fornite - {fortnite * 1.0 * 100 / gamesSold:f2}%");
        Console.WriteLine($"Overwatch - {overwatch * 1.0 * 100 / gamesSold:f2}%");
        Console.WriteLine($"Others - {others * 1.0 * 100 / gamesSold:f2}%");
    }
}
