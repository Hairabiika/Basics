namespace Basic
{
    using System;
    public class DivideWithoutRemainder
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            bool lost = false;

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                if (input == "Facebook") { salary -= 150; }
                if (input == "Instagram") { salary -= 100; }
                if (input == "Reddit") { salary -= 50; }

                if (salary <= 0) 
                {
                    lost = true; 
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (!lost) 
            {
                Console.WriteLine(salary); 
            }
        }
    }
}
