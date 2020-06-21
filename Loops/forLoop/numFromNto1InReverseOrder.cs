/*Write a program that reads a positive integer n entered by the user
and prints the numbers from n to 1 in reverse order (from largest to smallest).*/

using System;
					
public class Program
{
	public static void Main()
	{
		int num = int.Parse(Console.ReadLine());
        for (int i = num; i >= 1; i--) {
			Console.WriteLine(i);
		}
	}
}
