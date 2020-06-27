using System;
class Program
{
    static void Main(string[] args)
    {
        int hoursNeeded = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double totalHours = Math.Floor(days * 0.9 * 8 + workers * (2 * days));

        if (totalHours >= hoursNeeded)
        {
            Console.WriteLine($"Yes!{totalHours - hoursNeeded} hours left.");
        }

        else
        {
            Console.WriteLine($"Not enough time!{hoursNeeded - totalHours} hours needed.");

        }
    }
}
