namespace Basic
{
    using System;

    public class RadToDeg
    {
        public static void Main()
        {
            double radians = double.Parse(Console.ReadLine());
            
            Console.WriteLine("{0:F0}", radians * 180 / Math.PI);
        }
    }
}
