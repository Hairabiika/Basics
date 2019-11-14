namespace Basic
{
    using System;

    public class GodzillaVsKong
    {
        public static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double priceClothes = double.Parse(Console.ReadLine());

            double decor = budget / 10;
            if (people > 150) { priceClothes = priceClothes * 9 / 10; }
            if (budget < people * priceClothes + decor) 
            { 
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:F2} leva more.", (people * priceClothes + decor) - budget);
            }

            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:F2} leva left.", budget - (people * priceClothes + decor));
            }
        }
    }
}
