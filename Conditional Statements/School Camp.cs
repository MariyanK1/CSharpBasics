using System;
class Program
{
    static void Main(string[] args)
    {
        string season = Console.ReadLine();
        string groupType = Console.ReadLine();
        int numberOfStudents = int.Parse(Console.ReadLine());
        int numberOfNights = int.Parse(Console.ReadLine());

        double price = 0;

        string sport = "";

        switch (season)
        {
            case "Winter":
                if (groupType == "boys")
                {
                    price = 9.60;

                    sport = "Judo";
                }
                else if (groupType == "girls")
                {
                    price = 9.60;

                    sport = "Gymnastics";
                }
                else
                {
                    price = 10.0;

                    sport = "Ski";
                }
                break;
            case "Spring":
                if (groupType == "boys")
                {
                    price = 7.20;

                    sport = "Tennis";
                }
                else if (groupType == "girls")
                {
                    price = 7.20;

                    sport = "Athletics";
                }
                else
                {
                    price = 9.50;

                    sport = "Cycling";
                }
                break;
            case "Summer":
                if (groupType == "boys")
                {
                    price = 15.0;

                    sport = "Football";
                }
                else if (groupType == "girls")
                {
                    price = 15.0;

                    sport = "Volleyball";
                }
                else
                {
                    price = 20.0;

                    sport = "Swimming";
                }
                break;
        }

        double totalPrice = (numberOfStudents * price) * numberOfNights;

        if (numberOfStudents >= 50)
        {
            totalPrice = totalPrice * 0.50;
        }
        else if (numberOfStudents >= 20 && numberOfNights < 50)
        {
            totalPrice = totalPrice * 0.85;
        }
        else if (numberOfStudents >= 10 && numberOfStudents < 20)
        {
            totalPrice = totalPrice * 0.95;
        }

        Console.WriteLine($"{sport} {totalPrice:F2} lv.");
    }
}
