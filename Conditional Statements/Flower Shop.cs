using System;
class Program
{
    static void Main(string[] args)
    {
        int magnolias = int.Parse(Console.ReadLine());
        int zumbuls = int.Parse(Console.ReadLine());
        int roses = int.Parse(Console.ReadLine());
        int cactus = int.Parse(Console.ReadLine());
        double giftPrice = double.Parse(Console.ReadLine());

        double totalPrice = magnolias * 3.25 + zumbuls * 4 + roses * 3.50 + cactus * 8;
        double taxes = totalPrice * 0.95;

        if (taxes >= giftPrice)
        {
            Console.WriteLine($"She is left with {Math.Floor(taxes - giftPrice)} leva.");
        }

        else
        {
            Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - taxes)} leva.");

        }
    }
}
