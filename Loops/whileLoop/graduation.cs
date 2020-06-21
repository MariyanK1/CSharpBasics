/*Write a program that calculates the average grade of a student from his entire education.
On the first line you will receive the name of the student, and on each subsequent line his annual grades.

The student moves on to the next grade if his / her annual grade is greater than or equal to 4.00.
If his grade is below 4.00, he will repeat the class.

Upon successful completion of 12th grade to print:
"{student name} graduated. Average grade: {grade point average}"
The value must be formatted to the second decimal place.*/

using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string peopleName = Console.ReadLine();
            int counter = 0;
            double evaluation = 0.0;

            while (counter < 12)
            {
                double inputEvaluation = double.Parse(Console.ReadLine());
                if (inputEvaluation < 4.00)
                {
                    continue;
                }
                else if (inputEvaluation >= 4.00)
                {
                    evaluation += inputEvaluation;
                    counter++;
                }
            }
            evaluation /= counter;
            Console.WriteLine($"{peopleName} graduated. Average grade: {evaluation:f2}");
        }
    }
}
