using System;
class Program
{
    static void Main(string[] args)
    {
        int capacityOfPool = int.Parse(Console.ReadLine());
        int firstPipe = int.Parse(Console.ReadLine());
        int secondPipe = int.Parse(Console.ReadLine());
        double hoursMissing = double.Parse(Console.ReadLine());

        double firstPipeV = hoursMissing * firstPipe;
        double secondPipeV = hoursMissing * secondPipe;
        double totalV = firstPipeV + secondPipeV;

        if (totalV <= capacityOfPool)
        {
            double waterPercent = totalV / capacityOfPool * 100;
            double pipe1Percent = firstPipe * hoursMissing / totalV * 100;
            double pipe2Percent = secondPipe * hoursMissing / totalV * 100;
            Console.WriteLine($"The pool is {waterPercent:f2}% full. Pipe 1: {pipe1Percent:f2}%. Pipe 2: {pipe2Percent:f2}%.");
        }

        else
        {
            double waterMissing = totalV - capacityOfPool;
            Console.WriteLine($"For {hoursMissing:f2} hours the pool overflows with {waterMissing:f2} liters");
        }
    }
}
