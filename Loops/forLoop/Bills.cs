using System;
class Program
{
    static void Main(string[] args)
    {
        double months = double.Parse(Console.ReadLine());
        double waterBill = 20;
        double internetBill = 15;
        double otherBill = 0;
        double sumEl = 0;

        for (int i = 1; i <= months; i++)
        {
            double electricity = double.Parse(Console.ReadLine());
            sumEl += electricity;

            otherBill += (electricity + waterBill + internetBill) * 1.20;
        }

        double sumWater = months * waterBill;
        double sumInternet = months * internetBill;
        double sumAverage = (otherBill + sumInternet + sumEl + sumWater) / months;

        Console.WriteLine($"Electricity: {sumEl:f2} lv");
        Console.WriteLine($"Water: {sumWater:f2} lv");
        Console.WriteLine($"Internet: {sumInternet:f2} lv");
        Console.WriteLine($"Other: {otherBill:f2} lv");
        Console.WriteLine($"Average: {sumAverage:f2} lv");
    }

}
