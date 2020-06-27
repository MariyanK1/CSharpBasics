using System;
class Program
{
    static void Main(string[] args)
    {
        int numTons = int.Parse(Console.ReadLine());
        double sum = 0;
        double microB = 0;
        double truck = 0;
        double train = 0;


        for (int i = 1; i <= numTons; i++)
        {
            double tons = double.Parse(Console.ReadLine());

            if (tons <= 3)
            {
                microB += tons;
            }

            else if (tons >= 4 && tons <= 11)
            {
                truck += tons;
            }

            else
            {
                train += tons;
            }

            sum += tons;

        }

        double loads = microB + truck + train;

        double average = (microB * 200 + truck * 175 + train * 120) / loads;

        Console.WriteLine($"{average:f2}");
        Console.WriteLine($"{microB / loads * 100:f2}%");
        Console.WriteLine($"{truck / loads * 100:f2}%");
        Console.WriteLine($"{train / loads * 100:f2}%");
    }                       
}                     
