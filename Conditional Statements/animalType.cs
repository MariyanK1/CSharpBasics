/*
Write a program that prints the type of the animal according to its name entered by the user.
⦁ dog -> mammal
⦁ crocodile, tortoise, snake -> reptile
⦁ others -> unknown
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = Console.ReadLine().ToLower();
            switch (animal)
            {
                case "dog": Console.WriteLine("mammal"); break;
                case "crocodile":
                case "tortoise":
                case "snake": Console.WriteLine("reptile"); break;
                default: Console.WriteLine("unknown"); break;
            }

        }
    }
}
