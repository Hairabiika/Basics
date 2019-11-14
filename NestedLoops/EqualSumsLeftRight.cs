namespace Basic
{
    using System;
    public class EqualSumsOfDigits
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());



            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int firstDesethl = i / 10000;
                int firstHl = i / 1000 % 10;
                int firstSt = i / 100 % 10;
                int firstDes = i / 10 % 10;
                int firstEd = i % 10;

                if (firstHl + firstDesethl == firstDes + firstEd)
                {
                    Console.Write(i + " ");
                }

                else if (firstHl + firstDesethl > firstDes + firstEd && firstHl + firstDesethl == firstDes + firstEd + firstSt)
                {
                    Console.Write(i + " ");
                }

                else if (firstHl + firstDesethl < firstDes + firstEd && firstHl + firstDesethl + firstSt == firstDes + firstEd)
                {
                    Console.Write(i + " ");
                }

            }
        }
    }
}
