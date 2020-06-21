/*An enterprising Bulgarian opens neighborhood shops in several cities and sells at different prices according to the city:
city /  product 

        coffee  water  beer   sweets   peanuts
Sofia   0.50    0.80   1.20  1.45    1.60
Plovdiv 0.40    0.70  1.15  1.30    1.50
Varna   0.45    0.70  1.10  1.35    1.55

Write a program that reads the product (string), city (string) and quantity (decimal number) entered by the user,
and calculates and prints how much the corresponding quantity of the selected product costs in the specified city.

Sample case:

In:
coffee
Varna
2

Out:
0.9

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (city == "sofia")
            {
                switch (product)
                {
                    case "coffee": Console.WriteLine(quantity * 0.50); break;
                    case "water": Console.WriteLine(quantity * 0.80); break;
                    case "beer": Console.WriteLine(quantity * 1.20); break;
                    case "sweets": Console.WriteLine(quantity * 1.45); break;
                    case "peanuts": Console.WriteLine(quantity * 1.60); break;
                    default:
                        break;
                }
            }
            else if (city == "plovdiv")
            {
                switch (product)
                {
                    case "coffee": Console.WriteLine(quantity * 0.40); break;
                    case "water": Console.WriteLine(quantity * 0.70); break;
                    case "beer": Console.WriteLine(quantity * 1.15); break;
                    case "sweets": Console.WriteLine(quantity * 1.30); break;
                    case "peanuts": Console.WriteLine(quantity * 1.50); break;
                    default:
                        break;
                }
            }
            else if (city == "varna")
            {
                switch (product)
                {
                    case "coffee": Console.WriteLine(quantity * 0.45); break;
                    case "water": Console.WriteLine(quantity * 0.70); break;
                    case "beer": Console.WriteLine(quantity * 1.10); break;
                    case "sweets": Console.WriteLine(quantity * 1.35); break;
                    case "peanuts": Console.WriteLine(quantity * 1.55); break;
                    default:
                        break;
                }
            }
            
        }
    }
}
