using System;
					
public class Program
{
	public static void Main()
	{
		//Write a program that reads an integer in the range [1… 9] entered by the user and writes it with words in English. If the number is out of range, it says "number too big"
		
		int num = int.Parse(Console.ReadLine());
		
		if (num == 1) {
			Console.WriteLine("one");
		} else if (num == 2) {
			Console.WriteLine("two");
		}else if (num == 3) {
			Console.WriteLine("three");
		}else if (num == 4) {
			Console.WriteLine("four");
		}else if (num == 5) {
			Console.WriteLine("five");
		}else if (num == 6) {
			Console.WriteLine("six");
		}else if (num == 7) {
			Console.WriteLine("seven");
		}else if (num == 8) {
			Console.WriteLine("eigth");
		}else if (num == 9) {
			Console.WriteLine("nine");
		} else {
			Console.WriteLine("Out of range");
		}
	}
}
