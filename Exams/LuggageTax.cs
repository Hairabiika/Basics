namespace Basic
{
    using System;
    public class LuggageTax
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int depth = int.Parse(Console.ReadLine());
            bool biletType = bool.Parse(Console.ReadLine());

            if (biletType)
            {
                int total = length * height * depth;
                if (total <= 100)
                {
                    Console.WriteLine("Luggage tax: 0.00");
                }

                if (total > 100 && total < 200)
                {
                    Console.WriteLine("Luggage tax: 10.00");
                }

                if (total > 200 && total <= 300)
                {
                    Console.WriteLine("Luggage tax: 20.00");
                }

            }

            else if (!biletType)
            {
                int total = length * height * depth;
                if (total <= 100)
                {
                    Console.WriteLine("Luggage tax: 25.00");
                }

                if (total > 100 && total < 200)
                {
                    Console.WriteLine("Luggage tax: 50.00");
                }

                if (total > 200 && total <= 300)
                {
                    Console.WriteLine("Luggage tax: 100.00");
                }
            }

        }
    }
}
