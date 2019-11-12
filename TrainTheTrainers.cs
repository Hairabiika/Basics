namespace Basic
{
    using System;
    public class SumPrimeNonPrime
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double average = 0;
            double combined = 0;
            double counter = 0;

            while (true)
            {
                string input = Console.ReadLine();
                average = 0;
                if (input == "Finish") { break; }

                for (int i = 0; i < number; i++)
                {
                    double grades = double.Parse(Console.ReadLine());
                    average += grades;
                }

                double avg = average / number;
                combined += avg;
                counter++;
                Console.WriteLine($"{input} - {avg:F2}.");
                
            }

            Console.WriteLine($"Student's final assessment is {(combined / counter):F2}.");
        }
    }
}