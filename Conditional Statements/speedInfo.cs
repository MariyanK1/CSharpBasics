using System;

namespace _12._Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Write a program that reads the speed (real number) entered by the user and prints
speed information. At speeds up to 10 (inclusive), print “slow”. At speeds above 10 and up to 50
print “average”. At speeds above 50 and up to 150, print “fast”. At speeds above 150 and up to 1000
print “ultra fast”. At higher speeds, print “extremely fast”./*

            double speed = double.Parse(Console.ReadLine());

            if (speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
            else if (speed > 150)
            {
                Console.WriteLine("ultra fast");
            }
            else if (speed > 50)
            {
                Console.WriteLine("fast");
            }
            else if (speed > 10)
            {
                Console.WriteLine("average");
            }
            else
            {
                Console.WriteLine("slow");
            }
        }
    }
}
