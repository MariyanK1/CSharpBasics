/*
Write a console program that reads the age (real number) and gender ('m' or 'f') entered by the user and prints an the title 
from the following:
⦁ "Mr." - male (gender 'm') aged 16 or over
⦁ "Master" - a boy (gender 'm') under 16 years
⦁ "Ms." - a woman (gender 'f') aged 16 or over
⦁ "Miss" - a girl (gender 'f') under 16 years
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issue1
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            
            if (age < 16)
            {
                    if (gender=="m")
                {
                    Console.WriteLine("Master");
                }
                    else
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if(gender=="m")
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
