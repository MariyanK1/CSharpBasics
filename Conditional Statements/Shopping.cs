using System;
class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int numOfGPU = int.Parse(Console.ReadLine());
        int numOfCPU = int.Parse(Console.ReadLine());
        int numOfRAM = int.Parse(Console.ReadLine());

        double priceOfGPU = numOfGPU * 250;
        double priceOfCPU = priceOfGPU * 0.35;
        double cpuPrice = priceOfCPU * numOfCPU;
        double priceOfRam = priceOfGPU * 0.10;
        double ramPrice = numOfRAM * priceOfRam;
        double totalPrice = priceOfGPU + cpuPrice + ramPrice;

        double discount = 0;

        if (numOfGPU > numOfCPU)
        {
            discount = totalPrice * 0.15;
            totalPrice -= discount;
        }

        if (budget >= totalPrice)
        {
            Console.WriteLine($"You have {budget - totalPrice:F2} leva left!");
        }

        else
        {
            Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva more!");
        }
    }  
}
 
