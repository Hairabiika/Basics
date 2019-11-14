namespace Basic
{
    using System;
     
    public class Walking
    {
        public static void Main()
        {
            string hello = Console.ReadLine();
            int count = 0;
            bool success = false;

            while (true)
            {
                if (hello == "Going home")
                {
                    hello = Console.ReadLine();
                    count += int.Parse(hello);
                    if (count >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        success = true;
                    }

                    break;
                }
                
                count += int.Parse(hello);

                if (count >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    success = true;
                    break;
                }

                hello = Console.ReadLine();
            }

            if (!success) { Console.WriteLine($"{10000-count} more steps to reach goal."); }
        }
    }
}
