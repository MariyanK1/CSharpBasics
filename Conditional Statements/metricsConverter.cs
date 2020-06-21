using System;
					
public class Program
{
	public static void Main()
	{
  /*
Write a program that converts the distance between the following 3 units: mm, cm, m.
Use the correspondences in the table below:

input unit  output unit
1 meter (m) 1000 millimeters (mm)
1 meter (m) 100 centimeters (cm)


The input data consists of three lines entered by the user:
> First line: conversion number - real number
> Second line: input unit of measure - text
> Third line: output unit (for the result) - text

Print the result of the unit conversion formatted to the third character on the console
after the decimal point.

Sample case:
Input:
12
Output:
0.012
*/


            double number = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            double mm = 0;

            if (inputMetric == "m")
            {
                mm = number * 1000;
            }
            else if (inputMetric == "cm")
            {
                mm = number * 10;
            }
            else if (inputMetric == "mm")
            {
                mm = number;
            }
            if (outputMetric == "m")
            {
                number = mm / 1000;
            }
            else if (outputMetric == "cm")
            {
                number = mm / 10;
            }
            else if (outputMetric == "mm")
            {
                number = mm;
            }

            Console.WriteLine($"{number:F3}");
	}
}
