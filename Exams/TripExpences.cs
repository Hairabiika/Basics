namespace Basic
{
    using System;
    using System.Text;

    public class TripExpences
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            double moneyCounter = 0;
            double dayCounter = 0;

            for (int i = 0; i < days; i++)
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "Day over") 
                    {
                        sb.AppendLine($"Money left from today: {60 - moneyCounter:F2}. You've bought {dayCounter} products.");
                        moneyCounter = moneyCounter - 60;
                        dayCounter = 0;
                        break;
                    }

                    dayCounter++;
                    moneyCounter += double.Parse(input);
                    if (moneyCounter >= 60)
                    {
                        sb.AppendLine($"Daily limit exceeded! You've bought {dayCounter} products.");
                        moneyCounter = 0;
                        dayCounter = 0;
                        break;
                    }
                }
            }

            Console.WriteLine(sb);
        }
    }
}
