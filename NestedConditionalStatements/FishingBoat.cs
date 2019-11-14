namespace Basic
{
    using System;
     
    public class FishingBoat
    {
        public static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            switch (season)
            {
                case "Spring":
                    totalPrice += 3000;
                    break;

                case "Summer":
                    totalPrice += 4200;
                    break;

                case "Autumn":
                    totalPrice += 4200;
                    break;

                case "Winter":
                    totalPrice += 2600;
                    break;
            }

            if (people <= 6) { totalPrice = 9 * totalPrice / 10; }
            else if (people > 6 && people <= 11) { totalPrice = 17 * totalPrice / 20; }
            else { totalPrice = 3 * totalPrice / 4; }

            if (season != "Autumn" && people % 2 == 0) { totalPrice = 19 * totalPrice / 20; }

            if (totalPrice <= budget) { Console.WriteLine("Yes! You have {0:F2} leva left.", budget - totalPrice); }
            else { Console.WriteLine("Not enough money! You need {0:F2} leva.", totalPrice - budget); }
        }
    }
}
