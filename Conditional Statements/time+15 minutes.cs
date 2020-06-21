using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Times_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Write a program that reads the hour and minutes of the 24-hour day entered by the user and
calculates what time it will be in 15 minutes. Print the result in hours: minutes format. The hours
are always between 0 and 23, and minutes are always between 0 and 59. Hours are displayed with one or two digits.
Minutes are always displayed in two digits, with a leading zero when necessary.

Sample case:
Input:
1
46

Output:
2:01
*/
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            minute = minute + 15;
            if (minute > 59)
            {
                hour++;
                minute -= 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            if (minute < 10)
            {
                Console.WriteLine("{0}:0{1}", hour, minute);

            }
            else
            {
                Console.WriteLine("{0}:{1}", hour, minute);
            }
        }
    }
}
