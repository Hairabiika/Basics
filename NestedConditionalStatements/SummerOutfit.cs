namespace Basic
{
    using System;
     
    public class SummerOutfit
    {
        public static void Main()
        {        
            int degree = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            
            if (degree >= 10 && degree <= 18)
            {
                switch (dayTime)
                {
                    case "Morning":
                        Console.WriteLine("It's {0} degrees, get your Sweatshirt and Sneakers.", degree);
                        break;

                    case "Afternoon":
                        Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degree);
                        break;

                    case "Evening":
                        Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degree);
                        break;
                }
            }

            else if (degree > 18 && degree <= 24)
            {
                switch (dayTime)
                {
                    case "Morning":
                        Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degree);
                        break;

                    case "Afternoon":
                        Console.WriteLine("It's {0} degrees, get your T-Shirt and Sandals.", degree);
                        break;

                    case "Evening":
                        Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degree);
                        break;
                }
            }

            else
            {
                switch (dayTime)
                {
                    case "Morning":
                        Console.WriteLine("It's {0} degrees, get your T-Shirt and Sandals.", degree);
                        break;

                    case "Afternoon":
                        Console.WriteLine("It's {0} degrees, get your Swim Suit and Barefoot.", degree);
                        break;

                    case "Evening":
                        Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degree);
                        break;
                }
            }
        }
    }
}
