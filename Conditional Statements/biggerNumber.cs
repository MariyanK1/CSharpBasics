using System;
					
public class Program
{
	public static void Main()
	{
		//Write a program that reads two integers entered by the user and prints the larger of both.
		
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		
		if (num1 > num2) {
			Console.WriteLine(num1);
		} else {
			Console.WriteLine(num2);
		}
	}
}
