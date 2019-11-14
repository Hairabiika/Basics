namespace Basic
{
    using System;

    public class TimePlus15Min
    {
        public static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes >= 60)
            {
                minutes -= 60;
                hours++;

                if (hours == 24)
                {
                    hours = 0;
                }
            }
            
            if (minutes < 10) { Console.WriteLine("{0}:0{1}", hours, minutes);}
            else { Console.WriteLine("{0}:{1}", hours, minutes); }
        }
    }
}
