using System;
class Program
{
    static void Main(string[] args)
    {
        int numOfMoves = int.Parse(Console.ReadLine());
        double points = 0;
        double zeroToNine = 0;
        double tenToNineteen = 0;
        double twentyToTwentyNine = 0;
        double thirtyToThirtyNine = 0;
        double fortyToFifty = 0;
        double invalidNumber = 0;



        for (int i = 1; i <= numOfMoves; i++)
        {
            double interval = double.Parse(Console.ReadLine());


            if (interval > 50 || interval < 0)
            {
                points /= 2;
                invalidNumber++;
            }

            else if (interval >= 0 && interval <= 9)
            {
                points = points + interval * 0.20;
                zeroToNine++;
            }

            else if (interval >= 10 && interval <= 19)
            {
                points = points + interval * 0.30;
                tenToNineteen++;
            }

            else if (interval >= 20 && interval <= 29)
            {
                points = points + interval * 0.40;
                twentyToTwentyNine++;
            }

            else if (interval >= 30 && interval <= 39)
            {
                points = points + 50;
                thirtyToThirtyNine++;
            }
            else if (interval >= 40 && interval <= 50)
            {
                points = points + 100;
                fortyToFifty++;
            }

        }

        double percentZero = (zeroToNine * 1.0) / numOfMoves * 100;
        double percentTen = (tenToNineteen * 1.0) / numOfMoves * 100;
        double percentTwenty = (twentyToTwentyNine * 1.0) / numOfMoves * 100;
        double percentThirty = (thirtyToThirtyNine * 1.0) / numOfMoves * 100;
        double percentForty = (fortyToFifty * 1.0) / numOfMoves * 100;
        double percentInvalid = (invalidNumber * 1.0) / numOfMoves * 100;

        Console.WriteLine($"{points:f2}");
        Console.WriteLine($"From 0 to 9: {percentZero:f2}%");
        Console.WriteLine($"From 10 to 19: {percentTen:f2}%");
        Console.WriteLine($"From 20 to 29: {percentTwenty:f2}%");
        Console.WriteLine($"From 30 to 39: {percentThirty:f2}%");
        Console.WriteLine($"From 40 to 50: {percentForty:f2}%");
        Console.WriteLine($"Invalid numbers: {percentInvalid:f2}%");
    }

}
