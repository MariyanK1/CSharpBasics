using System;
class Program
{
    static void Main(string[] args)
    {
        int time = int.Parse(Console.ReadLine());
        int numTakes = int.Parse(Console.ReadLine());
        int durTakes = int.Parse(Console.ReadLine());

        double preparation = time * 0.15;
        double takesDur = numTakes * durTakes;
        double needTime = takesDur + preparation;

        if (time <= needTime)
        {
            Console.WriteLine($"Time is up! To complete the movie you need {Math.Ceiling(needTime - time)} minutes.");
        }

        else
        {
            Console.WriteLine($"You managed to finish the movie on time! You have {Math.Ceiling(time - needTime)} minutes left!");
        }

    }
}
