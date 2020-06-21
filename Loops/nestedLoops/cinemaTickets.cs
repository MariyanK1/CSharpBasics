/*
Your task is to write a program that calculates the percentage of tickets for each type of ticket sold:
student (student), standard (standard) and child (kid), for all screenings.

You also need to calculate what percentage of the hall is filled for each screening.

The input is a series of integers and text:
⦁ On the first line until you receive the command "Finish" - movie name - text
⦁ In the second row - the free seats in the hall for each screening - an integer [1… 100]
⦁ For each film, read one line until the free seats in the hall are exhausted or until the command "End" is received:
⦁ Type of purchased ticket - text ("student", "standard", "kid")

Output:

The following lines must be printed on the console:
⦁ After each film, print what percentage of the cinema is full
"{movie name} - {room occupancy rate}% full."
⦁ When receiving the "Finish" command, print four lines:
⦁ "Total tickets: {total number of tickets purchased for all movies}"
} "{Percentage of student tickets}% student tickets."
⦁ "{percentage of standard tickets}% standard tickets."
} "{Percentage of children's tickets}% kids tickets."

Sample case:

In:
Taxi
10
standard
kid
student
student
standard
standard
End
Scary Movie
6
student
student
student
student
student
student
Finish

Out:
Taxi - 60.00% full.
Scary Movie - 100.00% full.
Total tickets: 12
66.67% student tickets.
25.00% standard tickets.
8.33% kids tickets.
*/


using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            int totalStudent = 0;
            int totalStandard = 0;
            int totalKid = 0;
            int totalTiket = 0;
            while (command != "Finish")
            {
                command = Console.ReadLine();
                int student = 0;
                int standard = 0;
                int kid = 0;
                if (command == "Finish")
                {
                    break;
                }
                int freePosition = int.Parse(Console.ReadLine());
                for (int i = 0; i < freePosition; i++)
                {
                    string curentPosition = Console.ReadLine();
                    if (curentPosition == "student")
                    {
                        student++;
                    }
                    else if (curentPosition == "standard")
                    {
                        standard++;
                    }
                    else if (curentPosition == "kid")
                    {
                        kid++;
                    }
                    else if (curentPosition == "End")
                    {
                        break;
                    }
                }
                totalStudent += student;
                totalStandard += standard;
                totalKid += kid;
                Console.WriteLine($"{command} - {((student + standard + kid) / (double)freePosition) * 100:f2}% full.");
            }
            totalTiket = totalStudent + totalStandard + totalKid;
            Console.WriteLine($"Total tickets: {totalTiket}");
            Console.WriteLine($"{(totalStudent / (double)totalTiket) * 100:f2}% student tickets.");
            Console.WriteLine($"{(totalStandard / (double)totalTiket) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(totalKid / (double)totalTiket) * 100:f2}% kids tickets.");
        }
    }
}
