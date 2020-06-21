using System;
 
class BonusScore
{
    static void Main()
    {
    
    /*
An integer is given - the initial number of points. Bonus points are accrued on it according to the rules described in
down. Write a program that calculates the bonus points that the number and the total number of points receive
(number + bonus).
> If the number is up to 100 inclusive, the bonus points are 5.
> If the number is greater than 100, the bonus points are 20% of the number.
> If the number is greater than 1000, the bonus points are 10% of the number.
> Additional bonus points (accrued separately from the previous ones):
For an even number> + 1 point.
For a number ending in 5> + 2 points./

Input:
20
Output:
6
26
*


        int number = int.Parse(Console.ReadLine());
        double bonusScore = 0;
 
        if (number <= 100)
        {
            bonusScore += 5;
        }
        else if ((number > 100) && (number <= 1000))
        {
            bonusScore += 0.2 * number;
        }
        else
        {
            bonusScore += 0.1 * number;
        }
 
        if (number % 2 == 0)
        {
            bonusScore += 1;
        }
 
        if (number % 10 == 5)
        {
            bonusScore += 2;
        }
 
        double totalScore = bonusScore + number;
        Console.WriteLine(bonusScore);
        Console.WriteLine(totalScore);
    }
}
