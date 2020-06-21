using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCount = int.Parse(Console.ReadLine());
            int counter = 0;
            int number = int.MinValue;
            int inputNumber = 0;

            while (counter < nCount)
            {
                inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber > number)
                {
                    number = inputNumber;
                }
                counter++;
            }
            Console.WriteLine(number);
        }
    }
}
