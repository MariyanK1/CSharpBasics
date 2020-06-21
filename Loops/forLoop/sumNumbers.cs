/*
Write a program that reads the nth number of integers entered by the user and sums them.
⦁ From the first line of the input, enter the number of numbers n.
⦁ Enter an integer from the next n lines.
The program must read the numbers, sum them and print their sum.
*/

using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < number; i++)
            {
                result += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(result);
        }
    }
}
