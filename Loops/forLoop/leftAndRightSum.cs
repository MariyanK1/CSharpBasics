/*
Write a program that reads a 2 * n number of integers submitted by the user and checks 
if the sum of the first n numbers (left sum) is equal to the sum of the second n numbers (right sum).

In case of equality, print "Yes, sum =" + the amount;
otherwise print "No, diff =" + the difference. The difference is calculated as a positive number (in absolute value).
*/

using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int sumL = 0;
            int sumR = 0;

            for (int i = 0; i < numbers; i++)
            {
                sumL += int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers; i++)
            {
                sumR += int.Parse(Console.ReadLine());
            }
            if (sumL == sumR)
            {
                Console.WriteLine($"Yes, sum = {sumL}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumL - sumR)}");
            }
        }
    }
}
