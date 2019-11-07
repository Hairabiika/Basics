namespace Basic
{
    using System;

    public class AlcoholMarket
    {
        public static void Main()
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double wiskeyQunatity = double.Parse(Console.ReadLine());

            double rakiaPrice = wiskeyPrice / 2;
            double winePrice = 3 * rakiaPrice / 5;
            double beerPrice = rakiaPrice / 5;

            double totalPrice = wiskeyPrice * wiskeyQunatity + beerPrice * beerQuantity + winePrice * wineQuantity + rakiaPrice * rakiaQuantity;
            Console.WriteLine("{0:F2}", totalPrice);
        }
    }
}
