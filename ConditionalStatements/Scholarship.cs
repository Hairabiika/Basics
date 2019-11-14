namespace Basic
{
    using System;

    public class Scholarship
    {
        public static void Main()
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            
            double socialScolarship = 0;
            double successScolarship = 0;

            if (income < minSalary && grade > 4.50)
            {
                socialScolarship = Math.Floor(minSalary * 35 / 100);
            }

            if (grade >= 5.5)
            {
                successScolarship = Math.Floor(25 * grade);
            }

            if (socialScolarship > 0 && successScolarship > 0)
            {
                if (successScolarship > socialScolarship) 
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", successScolarship);
                }

                else if (successScolarship < socialScolarship)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", socialScolarship);
                }

                else
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", successScolarship);
                }
            }

            else if (socialScolarship > 0)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", socialScolarship);
            }

            else if (successScolarship > 0)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", successScolarship);
            }

            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
