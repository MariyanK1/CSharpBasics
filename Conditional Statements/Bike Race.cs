using System;
class Program
{
    static void Main(string[] args)
    {
        int junior = int.Parse(Console.ReadLine());
        int senior = int.Parse(Console.ReadLine());
        string track = Console.ReadLine();

        double tax = 0.0;
        double tax2 = 0.0;
        
        switch (track)
        {
            case "trail":
                tax = junior * 5.50;
                tax2 = senior * 7;
                break;

            case "cross-country":
                tax = junior * 8;
                tax2 = senior * 9.50;
                if (junior + senior >= 50)
                {
                    tax *= 0.75;
                    tax2 *= 0.75;
                }
                break;

            case "downhill":
                tax = junior * 12.25;
                tax2 = senior * 13.75;
                break;

            case "road":
                tax = junior * 20;
                tax2 = senior * 21.50;
                break;
        }


        double totalSum = tax + tax2;
        double finalSum = totalSum * 0.95;


        Console.WriteLine($"{finalSum:f2}");
    }
}
