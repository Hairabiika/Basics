namespace Basic
{
    using System;

    public class RecAreaAndPerim
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double a = x2 - x1;
            double b = y2 - y1;
            if (a < 0) { a *= -1; }
            if (b < 0) { b *= -1; }
            double area =  a * b;
            double perimeter =  (a + b) * 2;
            
            Console.WriteLine("{0:F2}", area);
            Console.WriteLine("{0:F2}", perimeter);
        }
    }
}
