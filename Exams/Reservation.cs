namespace Basic
{
    using System;
     
    public class Reservation
    {
        public static void Main()
        {
            int dayOfReservation = int.Parse(Console.ReadLine());
            int monthOfReservation = int.Parse(Console.ReadLine());
            int dayOfAccomodation = int.Parse(Console.ReadLine());
            int monthOfAccomodation = int.Parse(Console.ReadLine());
            int dayOfLeaving = int.Parse(Console.ReadLine());
            int monthOfLeaving = int.Parse(Console.ReadLine());

            if (monthOfAccomodation - monthOfReservation == 0)
            {
                if (monthOfAccomodation == monthOfLeaving)
                {
                    double days = dayOfLeaving - dayOfAccomodation;
                    if (dayOfAccomodation - dayOfAccomodation < 10) {
                        Console.WriteLine($"Your stay from {dayOfAccomodation}/" +
                            $"{monthOfAccomodation} to {dayOfLeaving}/{monthOfLeaving} will cost {(days * 30):F2}");
                    }

                    else
                    {
                        Console.WriteLine($"Your stay from {dayOfAccomodation}/" +
                            $"{monthOfAccomodation} to {dayOfLeaving}/{monthOfLeaving} will cost {(days * 25):F2}");
                    }
                }

                else
                {
                    double days = 31 - dayOfAccomodation + dayOfLeaving;
                    if (dayOfAccomodation - dayOfAccomodation < 10)
                    {
                        Console.WriteLine($"Your stay from {dayOfAccomodation}/" +
                            $"{monthOfAccomodation} to {dayOfLeaving}/{monthOfLeaving} will cost {(days * 30):F2}");
                    }

                    else
                    {
                        Console.WriteLine($"Your stay from {dayOfAccomodation}/" +
                            $"{monthOfAccomodation} to {dayOfLeaving}/{monthOfLeaving} will cost {(days * 25):F2}");
                    }
                }
            }

            else
            {
                if (monthOfAccomodation == monthOfLeaving)
                {
                    double days = dayOfLeaving - dayOfAccomodation;
                    Console.WriteLine($"Your stay from {dayOfAccomodation}/" + 
                        $"{monthOfAccomodation} to {dayOfLeaving}/{monthOfLeaving} will cost {(4 * days * 5):F2}");
                }

                else
                {
                    double days = 31 - dayOfAccomodation + dayOfLeaving;
                    Console.WriteLine($"Your stay from {dayOfAccomodation}/" + 
                        $"{monthOfAccomodation} to {dayOfLeaving}/{monthOfLeaving} will cost {(4 * days * 5):F2}");
                }
            }
        }
    }
}
