namespace Basic
{
    using System;
    public class FishingBoat
    {
        public static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double totalPrice = budget;

            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer":
                        totalPrice = 3 * totalPrice / 10;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine("Camp - {0:F2}", totalPrice);
                        break;

                    case "winter":
                        totalPrice = 7 * totalPrice / 10;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine("Hotel - {0:F2}", totalPrice);
                        break;
                }      
            }
            else if (budget > 100 && budget <= 1000) 
            {
                switch (season)
                {
                    case "summer":
                        totalPrice = 2 * totalPrice / 5;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine("Camp - {0:F2}", totalPrice);
                        break;

                    case "winter":
                        totalPrice = 4 * totalPrice / 5;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine("Hotel - {0:F2}", totalPrice);
                        break;
                }
            }
            else 
            { 
                totalPrice = 9 * totalPrice / 10;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:F2}", totalPrice);
            }
        }
    }
}
