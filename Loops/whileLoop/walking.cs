using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string incomingString = Console.ReadLine();

            int steps = 0;
            int stepsEveryDay = 10000;

            while (true)
            {
                if (incomingString == "Going home")
                {
                    incomingString = Console.ReadLine();
                    steps += int.Parse(incomingString);
                    break;
                }
                else
                {
                    steps += int.Parse(incomingString);
                    if (steps >= stepsEveryDay)
                    {
                        break;
                    }
                }
                incomingString = Console.ReadLine(); 
            }
            
            if (steps >= stepsEveryDay)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                int diff = stepsEveryDay - steps;
                Console.WriteLine($"{diff} more steps to reach goal.");
            }
        }
    }
}
