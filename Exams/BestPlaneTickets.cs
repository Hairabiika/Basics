namespace Basic
{
    using System;
    public class BestPlaneTickets
    {
        public static void Main()
        {
            string biletNumber = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            int stay = int.Parse(Console.ReadLine());

            
            string bilet = biletNumber;
            double bestPrice = price;
            int min = stay;

            while (true)
            {

                biletNumber = Console.ReadLine();
                if (biletNumber == "End") { break; }

                price = double.Parse(Console.ReadLine());
                stay = int.Parse(Console.ReadLine());

                if (stay < min) 
                {
                    bilet = biletNumber;
                    bestPrice = price;
                    min = stay;
                }

            }
            int hours = min / 60;
            int mins = min % 60;

            Console.WriteLine($"Ticket found for flight {bilet} costs {(bestPrice * 1.96):F2} leva with {hours}h {mins}m stay");
        }
    }
}
