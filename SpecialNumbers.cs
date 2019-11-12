namespace Basic
{
    using System;
    public class SpecialNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1111; i <= 9999; i++)
            {
                int hl = i / 1000;
                int st = i / 100 % 10;
                int des = i / 10 % 10;
                int ed = i % 10;

                if (hl != 0 && st != 0 && des != 0 && ed != 0 && n % hl == 0 && n % st == 0 && n % des == 0 && n % ed == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}