namespace Basic
{
    using System;
     
    public class Vacation
    {
        public static void Main()
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double avaiableMoney = double.Parse(Console.ReadLine());
            int countSpend = 0;
            int countDays = 0;
            bool saved = false;

            while (countSpend < 5)
            {
                string text = Console.ReadLine();
                double savedOrSpent = double.Parse(Console.ReadLine());
                countDays++;

                if (text == "spend") 
                { 
                    countSpend++;
                    avaiableMoney -= savedOrSpent;
                    if (avaiableMoney < 0) { avaiableMoney = 0; }
                }
                else 
                { 
                    countSpend = 0;
                    avaiableMoney += savedOrSpent;
                    if (avaiableMoney >= neededMoney) 
                    { 
                        Console.WriteLine($"You saved the money for {countDays} days.");
                        saved = true;
                        break;
                    }
                }
            }

            if (!saved)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(countDays);
            }
        }
    }
}
