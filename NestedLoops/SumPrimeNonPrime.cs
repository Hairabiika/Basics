namespace Basic
{
    using System;
     
    public class SumPrimeNonPrime
    {
        public static void Main()
        {
            int sumOfPrime = 0;
            int sumOfNonPrime = 0;
            bool prime = true;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop") { break; }
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                
                else
                {
                    for (int i = 2; i <= number / 2; i++)
                    { 
                        if (number % i == 0) { prime = false; break; }
                        else { prime = true; }
                    }
                    if (prime) { sumOfPrime += number; }
                    else { sumOfNonPrime += number; }
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrime}");
        }
    }
}
