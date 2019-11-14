namespace Basic
{
    using System;
    public class LemonadeStand
    {
        public static void Main()
        {
            double kgLemons = double.Parse(Console.ReadLine());
            double kgSugar = double.Parse(Console.ReadLine());
            double litrWater = double.Parse(Console.ReadLine());

            double totalLemonade = kgLemons * 980 + litrWater * 1000 + 3 * kgSugar / 10;
            double cups = totalLemonade / 150;
            double sum = Math.Floor(cups) * 1.20;


            Console.WriteLine($"All cups sold: {Math.Floor(cups)}");
            Console.WriteLine($"Money earned: {sum:F2}");

        }
    }
}
