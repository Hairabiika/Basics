namespace Basic
{
    using System;
     
    public class Volleyball
    {
        public static void Main()
        {
            string year = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsOutside = double.Parse(Console.ReadLine());

            double weekends = 48 - weekendsOutside;
            double weekendsWithoutWork = 3 * weekends / 4;
            double playingHolidays = 2 * holidays / 3;

            double total = weekendsWithoutWork + playingHolidays + weekendsOutside;
            if (year == "leap") 
            {
                double final = Math.Floor(23 * total / 20);
                Console.WriteLine(final); 
            }
            else { Console.WriteLine(Math.Floor(total)); }
        }
    }
}
