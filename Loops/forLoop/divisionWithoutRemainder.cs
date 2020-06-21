/*
N-number integers are given in the interval [1… 1000]. Of these, some percentage p1 is divisible by 2, 
another percentage is divided by 3, another percentage p3 is divisible by 4.
Write a program that calculates and prints the percentages p1, p2 and p3

Input
On the first line of the input is the integer n (1 ≤ n ≤ 1000) - number of numbers.
The next n lines contain an integer in the interval [1… 1000] - the numbers to be checked by how much they are divisible.

Output
Print 3 lines on the console, each containing a percentage between 0% and 100%, to two decimal places, for example 25.00%, 66.67%, 57.14%.
⦁ On the first line - the percentage of numbers that are divisible by 2
⦁ On the second line - the percentage of numbers that are divisible by 3
⦁ On the third line - the percentage of numbers that are divisible by 4

Sample case:

In:
10
680
2
600
200
800
799
199
46
128
65

Out:
70.00%
10.00%
50.00%
*/

using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            double percent = 0.0;
            double p1 = 0.0, p2 = 0.0, p3 = 0.0;

            for (int i = 1; i <= numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
            }
            percent = (p1 / numbers) * 100;
            Console.WriteLine($"{percent:f2}%");
            percent = (p2 / numbers) * 100;
            Console.WriteLine($"{percent:f2}%");
            percent = (p3 / numbers) * 100;
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
