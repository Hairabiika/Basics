namespace Basic
{
    using System;
    public class Reservation
    {
        public static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            double beachRobe = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double umbrella = 2 * beachRobe / 3;
            double flipFlops = 3 * umbrella / 4;
            double bag = (beachRobe + flipFlops) / 3;

            double total = (beachRobe + umbrella + flipFlops + bag) * (100 - percentDiscount) / 100;
            if (budget - total >= 0)
            {
                Console.WriteLine($"Annie's sum is {total:F2} lv. She has {(budget - total):F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {total:F2} lv. She needs {(total - budget):F2} lv. more.");
            }
        }
    }
}