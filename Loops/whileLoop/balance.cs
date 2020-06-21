/*
Write a program that calculates how much money is in the account after you make a certain number of installments.
In the first row you will get how many installments need to be made. 

On each subsequent line you will receive the amount you need to deposit in 
the account until the number of installments is reached. For each amount received, the console must display 
"Increase:" + the amount and add it to the account. If you get a number less than 0, "Invalid operation!" 

Must be displayed on the console. and the program ends. 
When the program ends, "Total:" must be printed + the total amount in the account rounded to the second decimal place.
*/

using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDeposit = int.Parse(Console.ReadLine());
            double deposit = 0.0;
            int counter = 0;
            double acountBalance = 0.0;

            while (counter < numberOfDeposit)
            {
                deposit = double.Parse(Console.ReadLine());
                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                acountBalance += deposit;
                Console.WriteLine($"Increase: {deposit:f2}");
                counter++;
            }
            Console.WriteLine($"Total: {acountBalance:f2}");
        }
    }
}
