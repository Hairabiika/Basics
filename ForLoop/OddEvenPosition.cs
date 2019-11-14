namespace Basic
{
    using System;
    public class OddEvenPosition
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            double OddSum = 0; 
            double OddMin = 0;
            double OddMax = 0;
            double EvenSum = 0;
            double EvenMin = 0;
            double EvenMax = 0;

            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    double input = double.Parse(Console.ReadLine());

                    if (i % 2 == 0)
                    {
                        if (i == 2)
                        {
                            EvenMax = input;
                            EvenMin = input;
                            EvenSum = input;
                        }

                        else
                        {
                            if (input > EvenMax) { EvenMax = input; }
                            if (input < EvenMin) { EvenMin = input; }
                            EvenSum += input;
                        }
                    }

                    else
                    {
                        if (i == 1)
                        {
                            OddMax = input;
                            OddMin = input;
                            OddSum = input;
                        }

                        else
                        {
                            if (input > OddMax) { OddMax = input; }
                            if (input < OddMin) { OddMin = input; }
                            OddSum += input;
                        }
                    }
                }

                if (number == 1)
                {
                    Console.WriteLine("OddSum={0:F2},", OddSum);
                    Console.WriteLine("OddMin={0:F2},", OddMin);
                    Console.WriteLine("OddMax={0:F2},", OddMax);
                    Console.WriteLine("EvenSum={0:F2},", EvenSum);
                    Console.WriteLine("EvenMin=No,");
                    Console.WriteLine("EvenMax=No");
                }

                else
                {
                    Console.WriteLine("OddSum={0:F2},", OddSum);
                    Console.WriteLine("OddMin={0:F2},", OddMin);
                    Console.WriteLine("OddMax={0:F2},", OddMax);
                    Console.WriteLine("EvenSum={0:F2},", EvenSum);
                    Console.WriteLine("EvenMin={0:F2},", EvenMin);
                    Console.WriteLine("EvenMax={0:F2}", EvenMax);
                }
            }

            else
            {
                Console.WriteLine("OddSum=0.00,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0.00,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
