/*
Write a program that calculates the average grade of a student from his entire education.
On the first line you will receive the name of the student, and on each subsequent line his annual grades.
The student moves on to the next grade if his / her annual grade is greater than or equal to 4.00.

If the student is torn more than once, he is expelled and the program ends by printing
the student's name and in which class he is expelled.

Upon successful completion of 12th grade to print:
"{student name} graduated. Average grade: {grade point average}"
In case the student is expelled from school, print:
"{student's name} has been excluded at {grade in which he was excluded} grade"
The value must be formatted to the second decimal place.
*/

using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string peopleName = Console.ReadLine();
            int counter = 0;
            int counterEvalution = 0;
            double evaluation = 0.0;
            bool stop = true;

            while (counter < 12)
            {
                double inputEvaluation = double.Parse(Console.ReadLine());
                
                if (inputEvaluation < 4.00)
                {
                    counterEvalution++;
                }
                else if (inputEvaluation >= 4.00)
                {
                    evaluation += inputEvaluation;
                    counter++;
                }
                if (counterEvalution == 2)
                {
                    counter++;
                    stop = false;
                    break;
                }
            }
            evaluation /= counter;
            if (!stop)
            {
                Console.WriteLine($"{peopleName} has been excluded at {counter} grade");
            }
            else

            {
                Console.WriteLine($"{peopleName} graduated. Average grade: {evaluation:f2}");
            }
        }
    }
}
