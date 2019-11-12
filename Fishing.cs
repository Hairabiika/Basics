namespace Basic
{
    using System;
    public class TrainTheTrainers
    {
        public static void Main()
        {
            double fishCount = double.Parse(Console.ReadLine());
            int counter = 0;
            double sum = 0;
            double price = 0;
            double total = 0;

            for (int i = 1; i <= fishCount; i++)
            {
                string input = Console.ReadLine();
                if (input == "Stop") { break; }

                double weightOfFishes = double.Parse(Console.ReadLine());
                counter++;

                foreach (var symbol in input)
                {
                    sum += (char)(symbol);
                }

                price = sum / weightOfFishes;
                if (i % 3 == 0) { total += price; }
                else { total -= price; }               
                price = 0;
                sum = 0;
            }

            if (counter == fishCount)
            { 
                Console.WriteLine("Lyubo fulfilled the quota!");
            }

            if (total < 0)
            {
                Console.WriteLine("Lyubo lost {0:F2} leva today.", total * -1);
            }

            else
            {
                Console.WriteLine($"Lyubo's profit from {counter} fishes is {total:F2} leva.");
            }
        }
    }
}