namespace Basic
{
    using System;
    public class Coins
    {
        public static void Main()
        {
            int legnth = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int cake = legnth * width;
            int pieces = 0;

            while (cake >= 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine($"{cake - pieces} pieces are left.");
                    break;
                }

                pieces += int.Parse(input);
                if (pieces > cake)
                {
                    Console.WriteLine($"No more cake left! You need {pieces-cake} pieces more.");
                    break;
                }
            }
        }
    }
}
