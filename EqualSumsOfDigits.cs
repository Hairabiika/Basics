namespace Basic
{
    using System;
    public class Coding
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());



            for (int i = firstNumber; i < secondNumber; i++)
            {
                int firstStohl = i / 100000;
                int firstDesethl = i / 10000 % 10;
                int firstHl = i / 1000 % 10;
                int firstSt = i / 100 % 10;
                int firstDes = i / 10 % 10;
                int firstEd = i % 10;

                if (firstStohl + firstHl + firstDes == firstDesethl + firstSt + firstEd)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}