/*
Write a program that displays the room numbers in a building (in descending order) on the console,
provided the following conditions are met:
⦁ There are only offices on each even floor
⦁ There are only apartments on each odd floor
⦁ Each apartment is marked as follows: A {floor number} {apartment number}, apartment numbers start from 0.
⦁ Each office is denoted as follows: О {floor number} {office number}, office numbers also start from 0.
⦁ There are always apartments on the top floor and they are bigger than the others, so in front of their number 
it says 'L' instead of 'A'. If there is only one floor, then there are only large apartments!

Two integers are read from the console - the number of floors and the number of rooms per floor.

Sample case:

In:
6
4

Out:
L60 L61 L62 L63
A50 A51 A52 A53
O40 O41 O42 O43
A30 A31 A32 A33
O20 O21 O22 O23
A10 A11 A12 A13
*/

using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floor; i > 0; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    if (i == floor)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
