namespace Basic
{
    using System;
    public class NumbersEndingIn7
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int numbers = int.Parse(Console.ReadLine());
            int max = numbers;
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                numbers = int.Parse(Console.ReadLine());
                if (numbers > max)
                {
                    sum += max;
                    max = numbers;
                }
                else
                {
                    sum += numbers;
                }
            }

            if (max == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }

            else
            {
                Console.WriteLine("No");
                int diff = sum - max;
                if (diff < 0) { diff *= -1; Console.WriteLine($"Diff = {diff}");}
                else { Console.WriteLine($"Diff = {diff}"); }
            }
        }
    }
}
