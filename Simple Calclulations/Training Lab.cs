using System;
					
public class Program
{
	public static void Main()
	{
		double width = double.Parse(Console.ReadLine());
		double heigth = double.Parse(Console.ReadLine());
		
		double resultHeigth = Math.Floor(((heigth * 100) - 100) / 70);
		double resultWidth = Math.Floor((width * 100) / 120);
		double numberOfSeats = (resultHeigth * resultWidth) - 3;
		Console.WriteLine(numberOfSeats);
	}
}
