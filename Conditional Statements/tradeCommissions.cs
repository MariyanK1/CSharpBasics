/*A company gives the following commissions to its traders according to the city in which they work and the volume of sales:
City 
     | 0 ≤ s ≤ 500 | 500 <s ≤ 1,000 | 1,000 <s ≤ 10,000 | s> 10,000
Sofia |      5%    |    7%          |      8%           |     12%
Varna |     4.5%   |    7.5%        |     10%           |     13%
Plovdiv |   5.5%   |    8%          |     12%           |     14.5%

Write a console program that reads the city name (string) and sales volume (real number) entered by the user,
and calculates and displays the amount of the trade commission according to the table above.

Display the result formatted to 2 digits after the decimal point. 
In case of invalid city or sales volume (negative number) print "error".*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            bool error = false;

            double comission = 0.0;

            if (town == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                    error = true;
                }
                
            }
            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.10;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                    error = true;
                }
                
            }
            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                    error = true;
                }
                
            }

            else
            {
                Console.WriteLine("error");
                error = true;
            }

            if (error==false)
            {
                Console.WriteLine($"{comission:f2}");
            }
        }
    }
}
