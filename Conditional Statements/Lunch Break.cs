using System;
class Program
{
    static void Main(string[] args)
    {
        string showName = Console.ReadLine();
        int episodeDuration = int.Parse(Console.ReadLine());
        int breakDuration = int.Parse(Console.ReadLine());

        double lunchTime = breakDuration / 8.0;
        double restTime = breakDuration / 4.0;
        double timeLeft = breakDuration - (lunchTime + restTime);

        if (timeLeft >= episodeDuration)
        {
            Console.WriteLine($"You have enough time to watch {showName} and left with {Math.Ceiling(timeLeft - episodeDuration)} minutes free time.");
        }

        else
        {
            Console.WriteLine($"You don't have enough time to watch {showName}, you need {Math.Ceiling(episodeDuration - timeLeft)} more minutes.");
        }
    }
}
