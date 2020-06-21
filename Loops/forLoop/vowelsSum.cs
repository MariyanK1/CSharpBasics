/*Write a program that reads text (string) entered by the user
and calculates and prints the sum of the values of the vowels according to the table below:

letter:	a	e	i	o	u
value:	1	2	3	4	5

*/

using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            int result = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                char courentChar = inputString[i];

                switch (courentChar)
                {
                    case 'a':
                        result += 1;
                        break;
                    case 'e':
                        result += 2;
                        break;
                    case 'i':
                        result += 3;
                        break;
                    case 'o':
                        result += 4;
                        break;
                    case 'u':
                        result += 5;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
