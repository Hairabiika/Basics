namespace Basic
{
    using System;
    using System.Text;

    public class Seats
    {
        public static void Main()
        {
            int numberBilets = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numberBilets; i++)
            {
                string bilet = Console.ReadLine();
                for (int j = 0; j < bilet.Length; j++)
                {
                    if (bilet.Length < 5)
                    {
                        if (bilet[0] >= 'A' && bilet[0] <= 'Z')
                        {
                            sb.AppendLine($"Seat decoded: {bilet[0]}{bilet[1]}{bilet[2]}");
                            break;
                        }

                        else
                        {
                            sb.AppendLine($"Seat decoded: {bilet[3]}{bilet[1]}{bilet[2]}");
                            break;
                        }
                    }

                    else
                    {
                        sb.AppendLine($"Seat decoded: {bilet[0]}{bilet[1] + 0}");
                        break;
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
}
