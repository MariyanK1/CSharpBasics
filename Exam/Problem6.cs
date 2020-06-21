/*
Desi and her basketball team participate in tournaments every month, with each tournament consisting 
of a certain number of matches. Each match has a final result, based on which the winner is determined.
The team with the most points is considered the winner. Help Desi to make statistics about the tournaments in which she
participates with her team. As an entry you will receive tournament names until you receive the "End of tournaments" command. 
For each tournament you will receive an integer that will show the number of matches that are played for a tournament. 

For each match you will receive: in the first row the points scored by Desi's team, and in the second row - the points 
scored by the opposing team. After receiving the points for each match, print:

If Desi's team has won (ie the points scored by her team are more than the points of the opposing team): 
"Game {what is the number of the match they played for the current tournament} of tournament {name of the tournament }: 
win with {the difference between Desi's team points and the opponent's team} points. "

If Desi's team has lost (ie the points scored by her team are less than the points scored by the opposing team): 
"Game {what is the number of the match they played for the current tournament} of tournament {tournament name}: 
lost with {the difference between the points of the opposing team and the team of Desi} points. "
There will be no cases of equality.

Input

A series of tournaments is read from the console until you receive the "End of tournaments" command:
Name of the tournament - text
For each tournament n number of matches - integer in the interval [1… 15]
Two lines are read for each match:
Points scored by Desi's team - an integer in the range of [0… 150]
Points scored by the opposing team - an integer in the range of [0… 150]

Output
Print the following lines on the console:
After each match to print whether Desi's team has won or lost and by what difference.
When receiving the command "End of tournaments" to print two lines:
{percentage of matches won from all tournaments}% matches win
{percentage of lost matches from all tournaments}% matches lost
All percentages must be formatted to the second digit after the decimal point.

Sample case:

In:
Dunkers
2
75
65
56
73
Fire Girls
3
67
34
83
98
66
45
End of tournaments

Out:
Game 1 of tournament Dunkers: win with 10 points.
Game 2 of tournament Dunkers: lost with 17 points.
Game 1 of tournament Fire Girls: win with 33 points.
Game 2 of tournament Fire Girls: lost with 15 points.
Game 3 of tournament Fire Girls: win with 21 points.
60.00% matches win
40.00% matches lost

*/
using System;

namespace BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTournament = Console.ReadLine();
            int winCounter = 0;
            int loseCounter = 0;
            int totalMatches = 0;
            while (nameOfTournament != "End of tournaments")
            {
                int NumberOfMatches = int.Parse(Console.ReadLine());
                totalMatches+= NumberOfMatches;
                for (int i = 1; i <= NumberOfMatches; i++)
                {
                    int myPoints = int.Parse(Console.ReadLine());
                    int enemyPoints = int.Parse(Console.ReadLine());

                    if(myPoints > enemyPoints)
                    {
                        winCounter+=1;
                        int diff = myPoints - enemyPoints;
                        Console.WriteLine($"Game {i} of tournament {nameOfTournament}: win with {diff} points.");
                        
                    }
                    else if(myPoints < enemyPoints)
                    {
                        loseCounter+=1;
                        int diff = enemyPoints - myPoints;
                        Console.WriteLine($"Game {i} of tournament {nameOfTournament}: lost with {diff} points.");
                        
                    }
                }
                
                nameOfTournament = Console.ReadLine();
              
            }
            double winPercent = winCounter * 1.00 / totalMatches * 100;
            double losePercent = loseCounter * 1.00 / totalMatches * 100;
            Console.WriteLine($"{winPercent:f2}% matches win");
            Console.WriteLine($"{losePercent:f2}% matches lost");
        }
    }
}
