/*
Write a program that reads the nth number of integers submitted by the user 
and checks that the sum of the numbers of even positions is equal to the sum of the numbers of odd positions.
In case of equality, print two lines: "Yes" and on a new line "Sum =" + the amount; 
otherwise print "No" and on a new line "Diff =" + the difference. The difference is calculated in absolute value.
*/

using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int even = 0;
            int odd = 0;

            for (int i = 0; i < numbers; i++)
            {
                int curent = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += curent;
                }
                else
                {
                    odd += curent;
                }
            }

            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(even - odd)}");
            }
        }
    }
}
