namespace Basic
{
    using System;
    public class NumberPyramid
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int numbers = number;
            int numbersCounter = 0;

            while (numbers != 0)
            {
                numbers /= 10;
                numbersCounter++;
            }

            numbers = number;
            for (int i = 0; i < numbersCounter; i++)
            {
                for (int j = 0; j < numbers % 10; j++)
                {

                    Console.Write((char)(numbers % 10 + 33));
                }
                if (numbers % 10 == 0) { Console.Write("ZERO"); }
                number /= 10;
                numbers = number;
                Console.WriteLine();
            }
        }
    }
}
