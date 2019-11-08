namespace Basic
{
    using System;
    public class PointOnRecBorder
    {
        public static void Main()
        {
            string typeProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            switch (typeProjection)
            {
                case "Premiere":
                    Console.WriteLine("{0:F2} leva", rows * cols * 10);
                    break;

                case "Normal":
                    Console.WriteLine("{0:F2} leva", rows * cols * 7.5);
                    break;

                case "Discount":
                    Console.WriteLine("{0:F2} leva", rows * cols * 5);
                    break;
            }
        }
    }
}
