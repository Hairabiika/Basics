namespace Basic
{
    using System;
    public class Matrix
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            for (int a = firstNumber; a <= secondNumber; a++)
            {
                for (int b = firstNumber; b <= secondNumber; b++)
                {
                    for (int c = thirdNumber; c <= fourthNumber; c++)
                    {
                        for (int d = thirdNumber; d <= fourthNumber; d++)
                        {
                            if (a + d == b + c && a != b && c != d)
                            {
                                Console.WriteLine($"{a}{b}");
                                Console.WriteLine($"{c}{d}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
