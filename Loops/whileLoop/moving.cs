/*
On Jose's eighteenth birthday, he decided to move out. He packed his luggage in boxes and found a suitable advertisement
for an apartment for rent. He starts carrying his luggage in parts because he can't carry it all at once.

He has limited free space in his new home, where he can place his belongings so that the place is suitable for living.
Write a program that calculates the free volume of Jose's home that remains after you carry your luggage.
Note: One box has the exact dimensions: 1m. x 1m. x 1m.

Input
The user enters the following data on separate lines:
⦁ Width of free space - integer in the interval [1 ... 1000]
⦁ Length of free space - integer in the interval [1 ... 1000]
⦁ Height of free space - integer in the interval [1 ... 1000]
⦁ On the following lines (until receiving the command "Done") - number of boxes that are transferred to the accommodation - 
integers in the interval [1 ... 10000];

The program should finish reading data at the "Done" command or if the free space runs out.

Output
Print one of the following lines to the console:
⦁ If you reach the "Done" command and there is still free space:
"{number of available cubic meters} Cubic meters left."
⦁ If the free space runs out before the "Done" command arrives:
"No more free space! You need {number of missing cubic meters} Cubic meters more."

Sample case:

In:
10
10
2
20
20
20
20
122

Out:
No more free space! You need 2 Cubic meters more.

*/
using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthFreeSpace = int.Parse(Console.ReadLine());
            int lengthFreeSpace = int.Parse(Console.ReadLine());
            int heightFreeSpace = int.Parse(Console.ReadLine());

            int space = widthFreeSpace * lengthFreeSpace * heightFreeSpace;
            int boxes = 0;
            string command = null;

            while (true)
            {
                command = Console.ReadLine();
                if (command != "Done")
                {
                    boxes += int.Parse(command);
                }
                else
                {
                    break;
                }
                
                if (boxes >= space)
                {
                    break;
                }
            }
            if (space > boxes)
            {
                Console.WriteLine($"{space - boxes} Cubic meters left.");
            }
            else if (boxes >= space)
            {
                Console.WriteLine($"No more free space! You need {boxes - space} Cubic meters more.");
            }
        }
    }
}
