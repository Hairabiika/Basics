namespace Basic
{
    using System;
    public class OldBooks
    {
        public static void Main()
        {
            string wantedBook = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int count = 0;
            bool found = false;

            while (capacity > 0)
            {
                capacity--;
                count++;
                string book = Console.ReadLine();
                if (book == wantedBook)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"You checked {count - 1} books and found it.");
            }

            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
