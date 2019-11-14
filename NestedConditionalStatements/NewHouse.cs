namespace Basic
{
    using System;
     
    public class NewHouse
    {
        public static void Main()
        {
            string flowerType = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            switch (flowerType)
            {
                case "Roses":
                    totalPrice = numberFlowers * 5;
                    if (numberFlowers > 80) { totalPrice = 9 * totalPrice / 10; }
                    break;

                case "Dahlias":
                    totalPrice = numberFlowers * 3.8;
                    if (numberFlowers > 90) { totalPrice = 8.5 * totalPrice / 10; }
                    break;

                case "Tulips":
                    totalPrice = numberFlowers * 2.8;
                    if (numberFlowers > 80) { totalPrice = 8.5 * totalPrice / 10; }
                    break;

                case "Narcissus":
                    totalPrice = numberFlowers * 3;
                    if (numberFlowers < 120) { totalPrice = 11.5 * totalPrice / 10; }
                    break;

                case "Gladiolus":
                    totalPrice = numberFlowers * 2.5;
                    if (numberFlowers < 80) { totalPrice = 12 * totalPrice / 10; }
                    break;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", numberFlowers, flowerType, budget - totalPrice);
            }

            else
            {
                Console.WriteLine("Not enough money, you need {0:F2} leva more.", totalPrice - budget);
            }   
        }
    }
}
