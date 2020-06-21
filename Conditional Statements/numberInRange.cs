/*Write a program that checks if the number entered by the user is in the range [-100, 100] 
and is different from 0 and displays "Yes" if it meets the conditions, or "No" if it is outside them.*/

using System;
					
public class Program
{
	public static void Main()
	{
      int num = int.Parse(Console.ReadLine());
		
		  if (num <= 100 && num != 0) {
			Console.WriteLine("Yes");
		  } else {
			Console.WriteLine("No");
		
		}
	}
}
