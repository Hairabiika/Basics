namespace Basic
{
    using System;
    public class Scholarship
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool insideForX = false;
            bool insideForY = false;

            if (x > x1 && x < x2) { insideForX = true; }
            if (y > y1 && y < y2) { insideForY = true; }
            if (((x == x1 || x == x2) && (y > y1 && y < y2)) || ((y == y1 || y == y2) && (x > x1 && x < x2))) 
            {
                Console.WriteLine("Border"); 
            }
            else { Console.WriteLine("Inside / Outside"); }

        }
    }
}
