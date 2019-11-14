namespace Basic
{
    using System;

    public class DanceHall
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int corrugations = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double totalMoney = days * confectioners * ((cakes * 45) + (corrugations * 5.80) + (pancakes * 3.20));
            Console.WriteLine("{0:F2}", totalMoney * 7 / 8);
        }
    }
}
