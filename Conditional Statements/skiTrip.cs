/*

Atanas decided to spend his vacation in Bansko and ski. Before he leaves, however, 
he must book a hotel and calculate how much his stay will cost.
There are the following types of accommodation, with the following prices for accommodation:

⦁ "room for one person" - BGN 18.00 per night
⦁ "apartment" - BGN 25.00 per night
⦁ "president apartment" - BGN 35.00 per night

Depending on the number of days he will stay in the hotel (example: 11 days = 10 nights)
and the type of room he will choose, he can enjoy different discounts.

The discounts are as follows:
room type less than 10 days between 10 and 15 days more than 15 days
room for one person does not use a reduction does not use a reduction does not use a reduction
apartment 30% of the final price 35% of the final price 50% of the final price
president apartment 10% of the final price 15% of the final price 20% of the final price

After the stay, Atanas' rating for the hotel's services can be positive or negative.
If his assessment is positive, Atanas adds 25% of it to the price with the already deducted discount. 
If his assessment is negative, he deducts 10% from the price.

The input is read from the console and consists of three lines:
⦁ First row - days for stay - integer in the interval [0 ... 365]
⦁ Second row - type of room - "room for one person", "apartment" or "president apartment"
⦁ Third line - evaluation - "positive" or "negative"

Output:
One line should be printed on the console:
⦁ The price for his stay at the hotel, formatted to the second decimal place.

Sample case:

In:
30
president apartment
negative

Out:
730.80

*/


using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDay = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            int night = countDay - 1;
            double pricePerDay = 0.0;

            if (roomType == "room for one person")
            {
                pricePerDay = night * 18.00;
            }
            else if (roomType == "apartment")
            {
                pricePerDay = night * 25.00;
                if (countDay > 15)
                {
                    pricePerDay *= 0.50;
                }
                else if (countDay >= 10 && countDay <= 15)
                {
                    pricePerDay *= 0.65;
                }
                else
                {
                    pricePerDay *= 0.70;
                }
            }
            else if (roomType == "president apartment")
            {
                pricePerDay = night * 35.00;
                if (countDay > 15)
                {
                    pricePerDay *= 0.80;
                }
                else if (countDay >= 10 && countDay <= 15)
                {
                    pricePerDay *= 0.85;
                }
                else
                {
                    pricePerDay *= 0.90;
                }
            }
            
            if (rating == "positive")
            {
                pricePerDay *= 1.25;
            }
            else if (rating == "negative")
            {
                pricePerDay *= 0.90;
            }
            Console.WriteLine($"{pricePerDay:f2}");
        }
    }
}
