namespace Basic
{
    using System;

    public class UsdToBgn
    {
        public static void Main()
        {
            double dollars = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", dollars * 1.79549);
        }
    }
}
