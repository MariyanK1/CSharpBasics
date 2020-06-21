/*
N integers are given in the interval [1… 1000]. Of these, some percentage of p1 is below 200, 
another percentage of p2 is from 200 to 399, another percentage of p3 is from 400 to 599, 
another percentage of p4 is from 600 to 799 and the remaining p5 percent is from 800 upwards. 
Write a program that calculates and prints the percentages p1, p2, p3, p4 and p5.

Input
On the first line of the input is the integer n (1 ≤ n ≤ 1000) - number of numbers. 
The next n lines contain an integer in the interval [1… 1000] - the numbers on which to calculate the histogram.

Output
Print the histogram on the console - 5 lines, each of which contains a number between 0% and 100%, 
with an accuracy of two digits after the decimal point, for example 25.00%, 66.67%, 57.14%.

Sample case:

In:
3
1
2
999

Out:
66.67%
0.00%
0.00%
0.00%
33.33%


*/

