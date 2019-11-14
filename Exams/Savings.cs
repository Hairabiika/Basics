namespace Basic
{
    using System;
    public class SpecialNumbers
    {
        public static void Main()
        {
            double income = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double sum = double.Parse(Console.ReadLine());

            double unpredictExpence = 3 * income / 10;
            double saved = income - unpredictExpence - sum;

            Console.WriteLine($"She can save {(saved / income) * 100:F2}%");
            Console.WriteLine($"{months * saved:F2}");
        }
    }
}
