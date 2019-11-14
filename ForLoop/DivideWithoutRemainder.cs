namespace Basic
{
    using System;
     
    public class DivideWithoutRemainder
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            
            for (int i = 0; i < number; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers % 2 == 0) { p1++; }
                if (numbers % 3 == 0) { p2++; }
                if (numbers % 4 == 0) { p3++; }
            }

            if (p1 != 0)
            {
                p1 = 100 * p1 / number;
                Console.WriteLine($"{p1:F2}%");
            }

            else if (p1 == 0) { Console.WriteLine("0.00%"); }

            if (p2 != 0)
            {
                p2 = 100 * p2 / number;
                Console.WriteLine($"{p2:F2}%");
            }

            else if (p2 == 0) { Console.WriteLine("0.00%"); }

            if (p3 != 0)
            {
                p3 = 100 * p3 / number;
                Console.WriteLine($"{p3:F2}%");
            }

            else if (p3 == 0) { Console.WriteLine("0.00%"); }
        }
    }
}
