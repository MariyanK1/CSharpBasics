using System;
class Program
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        double treatedPatients = 0;
        double unTreatedPatients = 0;
        int doctors = 7;

        for (int i = 1; i <= days; i++)
        {
            int patients = int.Parse(Console.ReadLine());

            if (i % 3 == 0 && unTreatedPatients > treatedPatients)
            {
                doctors += 1;
            }

            if (patients < doctors)
            {
                treatedPatients += patients;
            }

            else
            {
                treatedPatients += doctors;
                unTreatedPatients += patients - doctors;
            }
        }

        Console.WriteLine($"Treated patients: {treatedPatients}.");
        Console.WriteLine($"Untreated patients: {unTreatedPatients}.");


    }
}                     
