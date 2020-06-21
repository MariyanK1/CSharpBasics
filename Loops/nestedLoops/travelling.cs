/*
Annie loves to travel and wants to visit several different destinations this year. When she chooses a destination,
she will estimate how much money she will need to get there and start saving. 
When she has saved enough, she will be able to travel.
Each time the destination and the minimum budget that will be needed for the trip will be read from the console.
Then you will read a few amounts that Annie saves while working and when she manages to collect
enough for the trip, she will leave, and the console should read:
 "Going to {destination}!"
When she has visited all the destinations she wants, instead of a destination she will enter "End" and the program will end.

Sample case:

In:
Greece
1000
200
200
300
100
150
240
Spain
1200
300
500
193
423
End

Out:
Going to Greece!
Going to Spain!

*/


using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    return;
                }
                double sum = 0;
                double budget = double.Parse(Console.ReadLine());
                while (sum < budget)
                {
                    string currentS = Console.ReadLine();
                    if (currentS == "End")
                    {
                        return;
                    }
                    sum += double.Parse(currentS);

                    if (sum >= budget)
                    {
                        Console.WriteLine($"Going to {destination}!");
                    }

                }
            }
        }
    }
}
