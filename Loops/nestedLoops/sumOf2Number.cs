/*
Write a program that checks all possible combinations of a pair of numbers in the interval of two given numbers. 
The output is printed, which is the combination whose sum of numbers is equal to a given magic number. 
If there is no combination matching the condition, a message is printed that it was not found.

Input
The input is read from the console and consists of three lines:
⦁ First line - beginning of the interval - integer in the interval [1 ... 999]
⦁ Second line - end of the interval - integer in the interval [greater than the first number ... 1000]
⦁ Third row - the magic number - an integer in the interval [1 ... 10000]

Output
One line should be printed on the console, according to the result:
⦁ If a combination is found whose sum of numbers is equal to the magic number
⦁ "Combination N: {sequence number} ({first number} + {second number} = {magic number})"
⦁ If no matching condition is found
} "{Number of all combinations} combinations - neither equals {magic number}"

Sample case:

In:
1
10
5

Out:
Combination N:4 (1 + 4 = 5)
*/

using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startRnge = int.Parse(Console.ReadLine());
            int endRnge = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int ferstNum = 0;
            int secondNum = 0;
            int counter = 0;

            for (int i = startRnge; i <= endRnge; i++)
            {
                for (int j = startRnge; j <= endRnge; j++)
                {
                    ferstNum = i;
                    secondNum = j;
                    counter++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({ferstNum} + {secondNum} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
