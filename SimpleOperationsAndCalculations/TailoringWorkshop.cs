namespace Basic
{
    using System;

    public class TailoringWorkshop
    {
        public static void Main()
        {
            int broi = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double pokrivkiArea = broi * ((length + 2 * 0.3) * (width + 2 * 0.3));
            double karetaArea = broi * ((length / 2) * (length / 2));

            double priceInUsd = pokrivkiArea * 7 + karetaArea * 9;
            double priceInBgn = priceInUsd * 1.85;

            Console.WriteLine("{0:F2} USD", priceInUsd);
            Console.WriteLine("{0:F2} BGN", priceInBgn);
        }
    }
}
