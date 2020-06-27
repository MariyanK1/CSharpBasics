using System;
class Program
{
    static void Main(string[] args)
    {
        double capacity = double.Parse(Console.ReadLine());
        double fansNum = double.Parse(Console.ReadLine());
        double counterA = 0;
        double counterB = 0;
        double counterV = 0;
        double counterG = 0;

        for (int i = 1; i <= fansNum; i++)
        {
            string sector = Console.ReadLine();

            if (sector == "A")
            {
                counterA++;
            }

            else if (sector == "V")
            {
                counterV++;
            }

            else if (sector == "B")
            {
                counterB++;
            }

            else if (sector == "G")
            {
                counterG++;
            }
        }

        double sectorAPercent = (counterA / fansNum) * 100;
        double sectorBPercent = (counterB / fansNum) * 100;
        double sectorVPercent = (counterV / fansNum) * 100;
        double sectorGPercent = (counterG / fansNum) * 100;
        double percentFans = (fansNum / capacity) * 100;

        Console.WriteLine($"{sectorAPercent:f2}%");
        Console.WriteLine($"{sectorBPercent:f2}%");
        Console.WriteLine($"{sectorVPercent:f2}%");
        Console.WriteLine($"{sectorGPercent:f2}%");
        Console.WriteLine($"{percentFans:f2}%");

    }

}
