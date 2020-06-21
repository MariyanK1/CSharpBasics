/*
Lily is already N years old. She receives a gift for each of her birthdays. For odd birthdays (1, 3, 5 ... n) he receives toys, and for each even (2, 4, 6 ... n) he receives money. For the second birthday he receives BGN 10.00, the amount being increased by BGN 10.00, for each subsequent even birthday (2 -> 10, 4 -> 20, 6 -> 30 ... etc.). Over the years, Lily has secretly saved money. Lily's brother, in the years she received money, took BGN 1.00 from them. 

Lily sold the toys received over the years, each for P BGN and added the amount to the money saved. With the money she wanted to buy a washing machine for X leva. Write a program to calculate how much money she has raised and whether she has enough to buy a washing machine.

*/

using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toysPrice = int.Parse(Console.ReadLine());

            int money = 0;
            int brotherMoney = 0;
            int toys = 0;
            double resultMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10;
                    resultMoney += money;
                    brotherMoney++;
                }
                else
                {
                    toys++;
                }
            }

            resultMoney += (toysPrice * toys) - brotherMoney;

            if (resultMoney >= washingMachinePrice)
            {
                resultMoney = Math.Abs(resultMoney - washingMachinePrice);
                Console.WriteLine($"Yes! {resultMoney:f2}");
            }
            else
            {
                resultMoney = Math.Abs(washingMachinePrice - resultMoney);
                Console.WriteLine($"No! {resultMoney:f2}");
            }
        }
    }
}
