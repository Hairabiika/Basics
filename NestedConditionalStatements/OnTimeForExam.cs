namespace Basic
{
    using System;
     
    public class OnTimeForExam
    {
        public static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrHour = int.Parse(Console.ReadLine());
            int arrMin = int.Parse(Console.ReadLine());

            int hours = examHour - arrHour;
            int min = examMin - arrMin;

            if (hours == 1 && min < 0)
            {
                min += 60;

                if (min > 30 && min < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", min);
                }

                else if (min > 0 && min <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", min);
                }
            }

            else if (hours == 0 && min >= 0)
            {
                if (min > 30)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", min);
                }

                else if (min > 0 && min <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", min);
                }

                else if (min == 0) { Console.WriteLine("On time"); }
            }

            else if (hours >= 1)
            {
                if (min == 0)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:0{1} hours before the start", hours, min);
                }
                if (min < 0)
                {
                    min += 60;
                    Console.WriteLine("Early");
                    if (min >= 10) { Console.WriteLine("{0}:{1} hours before the start", hours - 1, min); }
                    else { Console.WriteLine("{0}:0{1} hours before the start", hours - 1, min); }
                }

                else
                {
                    Console.WriteLine("Early");
                    if (min >= 10) { Console.WriteLine("{0}:{1} hours before the start", hours, min); }
                    else { Console.WriteLine("{0}:0{1} hours before the start", hours, min); }
                }
            }

            else if (hours == 0 && min < 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", min * -1);
            }

            else if (hours <= -1 && min > 0)
            {
                min -= 60;
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", min * -1);
            }

            else if (hours <= -1 && min <= 0)
            {
                Console.WriteLine("Late");
                if (min <= -10) { Console.WriteLine("{0}:{1} hours after the start", hours * -1, min * -1); }
                else { Console.WriteLine("{0}:0{1} hours after the start", hours * -1, min * -1); }
            }
        }
    }
}
