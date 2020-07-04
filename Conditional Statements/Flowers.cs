using System;
class Program
{
    static void Main(string[] args)
    {
        int hrizantemi = int.Parse(Console.ReadLine());
        int roses = int.Parse(Console.ReadLine());
        int tulips = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string holiday = Console.ReadLine();

        double priceFlowers = 0.0;
        double making = 2;
        double priceFlowers3 = 0.0;

        double totalPrice = 0.0;
        switch (season)
        {
            case "Spring":
            case "Summer":
                priceFlowers = hrizantemi * 2 + roses * 4.10 + tulips * 2.50;

                if (holiday == "Y")
                {
                    priceFlowers *= 1.15;
                }

                if (tulips > 7 && season == "Spring")
                {
                    priceFlowers *= 0.95;
                }
                break;

            case "Autumn":
            case "Winter":
                priceFlowers = hrizantemi * 3.75 + roses * 4.50 + tulips * 4.15;

                if (holiday == "Y")
                {
                    priceFlowers *= 1.15;
                }

                if (roses >= 10 && season == "Winter")
                {
                    priceFlowers *= 0.90;
                }
                break;

            default:
                break;
        }

        if (roses + tulips + hrizantemi > 20)
        {
            priceFlowers *= 0.80;
        }



        Console.WriteLine($"{priceFlowers + making:f2}");
    }
}
