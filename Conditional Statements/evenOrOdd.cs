using System;
					
public class Program
{
	public static void Main()
	{
		//Write a program that reads an integer entered by the user and prints to the console if it is even or odd.
		
		int num1 = int.Parse(Console.ReadLine());
		
		if (num1 % 2 == 0) {
			Console.WriteLine("even");
		} else {
			Console.WriteLine("odd");
		}
	}
}
