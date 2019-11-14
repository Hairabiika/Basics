namespace Basic
{
    using System;

    public class GodzillaVsKong
    {
        public static void Main()
        {
            double record = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());

            double waterResistancePer15 = Math.Floor(length / 15);
            double waterResistance = waterResistancePer15 * 12.5;

            double recordChallenge = timeForMeter * length + waterResistance;

            if (recordChallenge < record)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", recordChallenge);
            }

            else
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", recordChallenge - record);
            }
        }
    }
}
