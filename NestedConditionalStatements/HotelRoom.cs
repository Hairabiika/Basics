namespace Basic
{
    using System;
    public class HotelRoom
    {
        public static void Main()
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());

            double firstTotalPrice = 0;
            double secondTotalPrice = 0;

            if (month == "May" || month == "October")
            {
                firstTotalPrice = nights * 65;
                if (nights <= 7)
                {
                    secondTotalPrice = nights * 50;
                    Console.WriteLine("Apartment: {0:F2} lv.", firstTotalPrice);
                    Console.WriteLine("Studio: {0:F2} lv.", secondTotalPrice); 
                }

                else if (nights > 7 && nights <= 14)
                {
                    secondTotalPrice = nights * 50 * 19 / 20;
                    Console.WriteLine("Apartment: {0:F2} lv.", firstTotalPrice);
                    Console.WriteLine("Studio: {0:F2} lv.", secondTotalPrice);
                }

                else
                {
                    firstTotalPrice = nights * 65 * 9 / 10;
                    secondTotalPrice = nights * 50 * 7 / 10;
                    Console.WriteLine("Apartment: {0:F2} lv.", firstTotalPrice);
                    Console.WriteLine("Studio: {0:F2} lv.", secondTotalPrice);
                }
            }

            else if (month == "June" || month == "September")
            {
                firstTotalPrice = nights * 68.7;
                secondTotalPrice = nights * 75.20;

                if (nights > 14)
                {
                    firstTotalPrice = nights * 68.7 * 9 / 10;
                    secondTotalPrice = nights * 75.20 * 4 / 5;
                    Console.WriteLine("Apartment: {0:F2} lv.", firstTotalPrice);
                    Console.WriteLine("Studio: {0:F2} lv.", secondTotalPrice);
                }

                else 
                { 
                    Console.WriteLine("Apartment: {0:F2} lv.", firstTotalPrice);
                    Console.WriteLine("Studio: {0:F2} lv.", secondTotalPrice); 
                }
            }

            else
            {
                firstTotalPrice = nights * 77;
                secondTotalPrice = nights * 76;

                if (nights > 14)
                {
                    firstTotalPrice = nights * 77 * 9 / 10;
                    Console.WriteLine("Apartment: {0:F2} lv.", firstTotalPrice);
                    Console.WriteLine("Studio: {0:F2} lv.", secondTotalPrice);
                }

                else
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", firstTotalPrice);
                    Console.WriteLine("Studio: {0:F2} lv.", secondTotalPrice);
                }
            }
        }
    }
}
