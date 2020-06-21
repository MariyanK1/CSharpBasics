using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
/*Petya has a toy store. She receives a large order that she must fulfill. With the money that
will win wants to go on a trip. Write a program that calculates the profit from the order.
Toy prices:
*** Puzzle - BGN 2.60.
*** Talking doll - BGN 3
*** Teddy bear - BGN 4.10.
*** Minion - BGN 8.20.
*** Truck - BGN 2

If the ordered toys are 50 or more, the store makes a 25% discount on the total price. From the won
money Petya has to give 10% for the rent of the store. To calculate whether the money will be enough for her to go to
the trip.

The following is printed on the console:

    If the money is enough it is printed:
        "Yes! {Remaining money} lv left."
    If the money is NOT enough it is printed:
        "Not enough money! {Lv needed} lv needed."

The result must be formatted to the second decimal place.

Sample case:
320
8
2
5
5
1
Not enough money! 238.73 lv needed.
*/


            double tripPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
 
            double puzzlePrice = 2.6;
            double dollsPrice = 3;
            double bearsPrice = 4.1;
            double minionsPrice = 8.2;
            double trucksPrice = 2;
            double price = (puzzle * puzzlePrice) + (dolls * dollsPrice) + (bears * bearsPrice) + (minions * minionsPrice) + (trucks * trucksPrice);
            double toys = puzzle + dolls + bears + minions + trucks;
           
            if (toys >= 50)
            {
                price = price - (price * 0.25);
            }
 
             price = price - (price * 0.1);
 
            if (price >= tripPrice )
            {
                double enoughMoney = price - tripPrice;
                Console.WriteLine($"Yes! {(enoughMoney):f2} lv left.");
            }
            else
            {
                double moneyNeeded = tripPrice - price;
                Console.WriteLine($"Not enough money! {(moneyNeeded):f2} lv needed.");
            }
        }
    }
}
