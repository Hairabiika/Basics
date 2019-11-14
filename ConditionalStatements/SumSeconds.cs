namespace Basic
{
    using System;

    public class AlcoholMarket
    {
        public static void Main()
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secindTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            
            int totalTime = firstTime + secindTime + thirdTime;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;
            if (seconds < 10) { Console.WriteLine("{0}:0{1}", minutes, seconds); }
            else { Console.WriteLine("{0}:{1}", minutes, seconds); }
        }
    }
}
