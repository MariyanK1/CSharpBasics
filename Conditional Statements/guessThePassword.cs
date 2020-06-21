using System;
					
public class Program
{
	public static void Main()
	{

//Write a program that reads a password (one line of random text) entered by the user and checks if the entry matches the phrase "s3cr3t!P@ssw0rd"
//In case of coincidence, display "Welcome". In case of discrepancy, display "Wrong password!"
		
		string input = Console.ReadLine();
		
		if (input == "s3cr3t!P@ssw0rd") {
		Console.WriteLine("Welcome");
		} else {
		Console.WriteLine("Wrong password!")
		}
	}
}
