using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in which the user enters the type and dimensions of a geometric figure and calculates
her face. The figures are of four types: square, rectangle, circle and triangle
(triangle). The first line of the input reads the type of figure (square, rectangle, circle or triangle). If
the figure is a square, the next line reads a number - the length of its side. If the figure is
rectangle, on the next two lines read two numbers - the lengths of its sides. If the figure is a circle, the
the next line reads a number - the radius of the circle. If the figure is a triangle, the next two rows
read two numbers - the length of his side and the length of the height to it. Round the result to
3 digits after the decimal point.*/

            string figure = (Console.ReadLine());
            double area = 0.0;

            if (figure == "square")
            {
                double sideofSquare = double.Parse(Console.ReadLine());
                area = sideofSquare * sideofSquare;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "rectangle")
            {
                double sideOne = double.Parse(Console.ReadLine());
                double sideTwo = double.Parse(Console.ReadLine());
                area = sideOne * sideTwo;
                Console.WriteLine(Math.Round(area,3));
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = r * r * Math.PI;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double hight = double.Parse(Console.ReadLine());
                area = side * hight / 2;
                Console.WriteLine(Math.Round(area, 3));
            }
           
        }
    }
}
