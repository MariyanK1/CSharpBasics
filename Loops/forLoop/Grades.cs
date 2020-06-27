using System;
class Program
{
    static void Main(string[] args)
    {
        int numStudents = int.Parse(Console.ReadLine());
        double average = 0;
        double good = 0;
        double excellent = 0;
        double fail = 0;
        double sum = 0;

        for (int i = 1; i <= numStudents; i++)
        {
            double grades = double.Parse(Console.ReadLine());

            if (grades < 3.00)
            {
                fail++;
            }

            else if (grades >= 3.00 && grades <= 3.99)
            {
                average++;
            }

            else if (grades >= 4.00 && grades <= 4.99)
            {
                good++;
            }

            else if (grades >= 5.00)
            {
                excellent++;
            }

            sum += grades;
        }

        double averageGrades = sum / numStudents;

        double percentFail = (fail * 1.0) / numStudents * 100;
        double percentAverage = (average * 1.0) / numStudents * 100;
        double percentGood = (good * 1.0) / numStudents * 100;
        double percentExc = (excellent * 1.0) / numStudents * 100;
        
        Console.WriteLine($"Top students: {percentExc:f2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {percentGood:f2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {percentAverage:f2}%");
        Console.WriteLine($"Fail: {percentFail:f2}%");
        Console.WriteLine($"Average: {averageGrades:f2}");

    }

}
