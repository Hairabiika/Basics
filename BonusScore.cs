namespace Basic
{
    using System;

    public class SumSeconds
    {
        public static void Main()
        {
            double number = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (number <= 100) { bonus = 5; }
            else if (number > 100) { 
                bonus = number / 5;
                if (number > 1000) 
                { 
                    bonus = number / 10; 
                }
            }

            if (number % 2 == 0) { bonus++; }
            if (number % 10 == 5) { bonus += 2; }

            Console.WriteLine(bonus);
            Console.WriteLine(bonus + number);
        }
    }
}
