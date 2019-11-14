namespace Basic
{
    using System;
     
    public class CruiseShip
    {
        public static void Main()
        {
            string cruiseType = Console.ReadLine();
            string cabinType = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            if (nights <= 7)
            {
                if (cruiseType == "Mediterranean")
                {
                    if (cabinType == "standard cabin")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(4 * nights * 27.50):F2} lv.");
                    }

                    else if (cabinType == "cabin with balcony")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(4 * nights * 30.20):F2} lv.");
                    }

                    else if (cabinType == "apartment")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(4 * nights * 40.50):F2} lv.");
                    }
                }

                else if (cruiseType == "Adriatic")
                {
                    if (cabinType == "standard cabin")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(4 * nights * 22.99):F2} lv.");
                    }

                    else if (cabinType == "cabin with balcony")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(4 * nights * 25.00):F2} lv.");
                    }

                    else if (cabinType == "apartment")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(4 * nights * 34.99):F2} lv.");
                    }
                }

                else if (cruiseType == "Aegean")
                {
                    if (cabinType == "standard cabin")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(4 * nights * 23.00):F2} lv.");
                    }

                    else if (cabinType == "cabin with balcony")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(4 * nights * 26.60):F2} lv.");
                    }

                    else if (cabinType == "apartment")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(4 * nights * 39.80):F2} lv.");
                    }
                }
            }

            if (nights > 7)
            {
                if (cruiseType == "Mediterranean")
                {
                    if (cabinType == "standard cabin")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(3 * nights * 27.50):F2} lv.");
                    }

                    else if (cabinType == "cabin with balcony")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(3 * nights * 30.20):F2} lv.");
                    }

                    else if (cabinType == "apartment")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(3 * nights * 40.50):F2} lv.");
                    }
                }

                else if (cruiseType == "Adriatic")
                {
                    if (cabinType == "standard cabin")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(3 * nights * 22.99):F2} lv.");
                    }

                    else if (cabinType == "cabin with balcony")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(3 * nights * 25.00):F2} lv.");
                    }

                    else if (cabinType == "apartment")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(3 * nights * 34.99):F2} lv.");
                    }
                }

                else if (cruiseType == "Aegean")
                {
                    if (cabinType == "standard cabin")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(3 * nights * 23.00):F2} lv.");
                    }

                    else if (cabinType == "cabin with balcony")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(3 * nights * 26.60):F2} lv.");
                    }

                    else if (cabinType == "apartment")
                    {
                        Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {(3 * nights * 39.80):F2} lv.");
                    }
                }
            }
        }
    }
}
