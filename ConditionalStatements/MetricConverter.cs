namespace Basic
{
    using System;

    public class MetricConverter
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            string entryUnit = Console.ReadLine();
            string wantedUnit = Console.ReadLine();

            switch (entryUnit)
            {
                case "m":
                    switch (wantedUnit)
                    {
                        case "cm":
                            number *= 100;
                            break;

                        case "mm":
                            number *= 1000;
                            break;
                    }
                    break;

                case "cm":
                    switch (wantedUnit)
                    {
                        case "m":
                            number /= 100;
                            break;

                        case "mm":
                            number *= 10;
                            break;
                    }
                    break;

                case "mm":
                    switch (wantedUnit)
                    {
                        case "cm":
                            number /= 10;
                            break;

                        case "m":
                            number /= 1000;
                            break;
                    }
                    break;
            }

            Console.WriteLine("{0:F3}", number);
        }
    }
}
