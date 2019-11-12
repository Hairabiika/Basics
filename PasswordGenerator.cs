namespace Basic
{
    using System;
    public class Fishing
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            double firstDigit;
            double secondDigit;
            char digit;

            for (int i = 1; i < n; i++)
            {               
                for (int j = 1; j < n; j++)
                {                    
                    for (int k = 1; k <= l; k++)
                    {                       
                        for (int a = 1; a <= l; a++)
                        {
                            for (int s = 2; s <= n; s++)
                            {
                                if (s > j && s > i)
                                {
                                    Console.Write(i);
                                    Console.Write(j);
                                    Console.Write((char)(k + 96));
                                    Console.Write((char)(a + 96));
                                    Console.Write(s + " ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}