using System;
class Program
{
    static void Main(string[] args)
    {
        double inherentMoney = double.Parse(Console.ReadLine());
        int ageToLive = int.Parse(Console.ReadLine());

        int ageCounter = 17;

        for (int i = 1800; i <= ageToLive; i++)
        {

            if (i % 2 == 0)
            {
                inherentMoney -= 12000;
            }

            else if (i % 2 != 0)
            {
                ageCounter += 2;

                inherentMoney -= 12000 + ageCounter * 50;
            }
        }

        if (inherentMoney >= 0)
        {
            Console.WriteLine($"Yes! He will live a carefree life and will have {inherentMoney:f2} dollars left.");

        }

        else
        {
            Console.WriteLine($"He will need {Math.Abs(inherentMoney):f2} dollars to survive.");

        }
    }   
    
}                     
