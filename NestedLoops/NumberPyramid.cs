namespace Basic
{
    using System;
     
    public class NumberPyramid
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int row = 1;
            int counter = 0;
            bool a = false;

            for (int i = 1; i <= number; i++)
            {
                for (int j = row; j <= row + counter; j++)
                {
                    if (j > number) 
                    {
                        a = true;
                        break;
                    }
                    Console.Write(j + " ");
                }

                if (a) { break; }
                else
                {
                    Console.WriteLine();
                    row += i;
                    counter++;
                }
            }
        }
    }
}
