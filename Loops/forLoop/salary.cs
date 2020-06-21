/*
A company boss notices that more and more employees are spending time on sites that distract them.
To prevent this, he introduces surprise checks on the open tabs of his employees' browsers.

According to the site, various fines are imposed:
⦁ "Facebook" -> BGN 150.
⦁ "Instagram" -> BGN 100.
* "Reddit"-> BGN 50.

Two lines are read from the console:
⦁ Number of open tabs in the browser n - integer in the interval [1 ... 10]
⦁ Salary - a number in the interval [700 ... 1500]

Then n - the name of the website - text is read a number of times
If during the inspection the salary becomes less than or equal to BGN 0, it is written on the console
"You have lost your salary." and the program ends. Otherwise, after checking the console, 
the rest of the salary is displayed (to be written as an integer).

Sample case:

In:
10
750
Facebook
Dev.bg
Instagram
Facebook
Reddit
Facebook
Facebook

Out:
You have lost your salary.
*/

using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double restSalary = salary;
            double facebookForfeit = 150;
            double instagramForfeit = 100;
            double redditForfeit = 50;

            for (int i = 0; i < numberTabs && restSalary > 0; i++)
            {
                string sites = Console.ReadLine();
                
                if (sites == "Facebook")
                {
                    restSalary -=  facebookForfeit;
                }
                else if (sites == "Instagram")
                {
                    restSalary -= instagramForfeit;
                }
                else if (sites == "Reddit")
                {
                    restSalary -= redditForfeit;
                }
            }
            if (restSalary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine((int)restSalary);
            }
        }
    }
}
