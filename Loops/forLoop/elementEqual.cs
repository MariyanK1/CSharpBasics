/*
Write a program that reads the nth number of integers entered by the user and checks if there is a 
number among them that is equal to the sum of all the others. 

If there is such an element, print "Yes", "Sum =" + its value; 
otherwise it prints "No", "Diff =" + the difference between the largest
element and the sum of the others (in absolute value).
*/

using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }
            int sumMinNumbrers = sum - max;
            
            if (max == sumMinNumbrers)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                int diff = Math.Abs(max - sumMinNumbrers);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
