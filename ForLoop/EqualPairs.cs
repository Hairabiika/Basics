namespace Basic
{
    using System;
    public class OddEvenPosition
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            double firstNumber;
            double secondNumber;
            double firstValue = 0;
            double value = 0;
            double maxValue = 0;
            double minValue = 0;
            bool equal = true;

            for (int i = 0; i < number * 2; i+=2)
            {
                firstNumber = double.Parse(Console.ReadLine());
                secondNumber = double.Parse(Console.ReadLine());
                value = firstNumber + secondNumber;

                if (i == 0)
                {
                    firstValue = firstNumber + secondNumber;
                    minValue = firstValue;
                    maxValue = firstValue;
                }

                if (value - firstValue != 0)
                {
                    if (value > firstValue) { maxValue = value; }
                    else { minValue = value; }
                    equal = false;
                }
            }

            if (equal) { Console.WriteLine($"Yes, value={value}"); }
            else { Console.WriteLine($"No, maxdiff={maxValue-minValue}"); }
        }
    }
}
