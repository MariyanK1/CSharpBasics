/*
Ani goes to her hometown after a very long period abroad. On her way home, she sees her grandmother's old library and remembers 
her favorite book. Help Annie by writing a program in which she enters the book she is looking for (text)
and the capacity of the library (integer).

Until Annie finds her favorite book or checks everyone in the library, 
the program must read the name of each subsequent book (text) on a new line each time.

⦁ If it does not find the book, print it in two lines:
"" The book you search is not here! "
} "You checked {number} books."
⦁ If he finds his book, one line is printed:
⦁ "You checked {number} books and found it."
*/


using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int valueLibrary = int.Parse(Console.ReadLine());

            string nextBookName = null;
            int counter = 1;

            while (true)
            {
                nextBookName = Console.ReadLine();
                if (nextBookName == bookName || counter == valueLibrary)
                {
                    break;
                }
                counter++;
            }

            if (bookName != nextBookName)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
            else
            {
                Console.WriteLine($"You checked {counter - 1} books and found it.");
            }
        }
    }
}
