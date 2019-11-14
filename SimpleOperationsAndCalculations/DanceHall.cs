namespace Basic
{
    using System;

    public class DanceHall
    {
        public static void Main()
        {
            double hallLength = double.Parse(Console.ReadLine());
            double hallWidth = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double hallArea = hallLength * hallWidth * 100 * 100;
            double wardrobeArea = wardrobeSide * wardrobeSide * 100 * 100;
            double benchArea = hallArea / 10;
            double freeSpace = hallArea - wardrobeArea - benchArea;
            
            Console.WriteLine(Math.Floor(freeSpace / (7040)));
        }
    }
}
