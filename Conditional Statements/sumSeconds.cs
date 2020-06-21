using System;
 
class Program
{
    static void Main()
    {
    /*Three athletes finish in a matter of seconds (between 1 and 50). To write a program
which reads the times of the competitors in seconds entered by the user and calculates their total time
in minutes format: seconds Display the seconds with a leading zero.*/

        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
 
        int secondsSum = first + second + third;
        double minutes = secondsSum / 60;
        double seconds = secondsSum % 60;
 
        if (seconds < 10) {
        Console.WriteLine($"{minutes}:0{seconds}")
        } else {
        Console.WriteLine($"{minutes}:{seconds}")
        }
    }
}
