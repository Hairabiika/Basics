namespace Basic
{
    using System;
    public class Coins
    {
        public static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            double realMoney = Math.Round(money * 100);
            int count = 0;

            while (realMoney > 0)
            {
                if (realMoney - 200 >= 0)
                {
                    realMoney -= 200;
                    count++;
                }

                if (realMoney - 200 < 0 && realMoney - 100 >= 0)
                {
                    realMoney -= 100;
                    count++;
                }

                if (realMoney - 100 < 0 && realMoney - 50 >= 0)
                {
                    realMoney -= 50;
                    count++;
                }

                if (realMoney - 50 < 0 && realMoney - 20 >= 0)
                {
                    realMoney -= 20;
                    count++;
                }

                if (realMoney - 20 < 0 && realMoney - 10 >= 0)
                {
                    realMoney -= 10;
                    count++;
                }

                if (realMoney - 10 < 0 && realMoney - 5 >= 0)
                {
                    realMoney -= 5;
                    count++;
                }

                if (realMoney - 5 < 0 && realMoney - 2 >= 0)
                {
                    realMoney -= 2;
                    count++;
                }
                if (realMoney - 1 == 0)
                {
                    count++;
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}