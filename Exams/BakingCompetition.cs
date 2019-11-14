namespace Basic
{
    using System;
    using System.Text;

    public class TripExpences
    {
        public static void Main()
        {
            int competitors = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int cookiesCounter = 0;
            int cakesCounter = 0;
            int wafflesCounter = 0;
            int sweetCounter = 0;
            double totalMoney = 0;
            
            for (int i = 0; i < competitors; i++)
            {
                string name = Console.ReadLine();
                cookiesCounter = 0;
                cakesCounter = 0;
                wafflesCounter = 0;

                while (true)
                {
                    string sweet = Console.ReadLine();
                    if (sweet == "Stop baking!") 
                    {
                        sb.AppendLine($"{name} baked {cookiesCounter} cookies, {cakesCounter} cakes and {wafflesCounter} waffles.");
                        totalMoney += (cookiesCounter * 1.5 + cakesCounter * 7.8 + wafflesCounter * 2.3);
                        break; 
                    }
                    
                    int count = int.Parse(Console.ReadLine());

                    if (sweet == "cookies") { cookiesCounter += count; sweetCounter+=count; }
                    else if (sweet == "cakes") { cakesCounter += count; sweetCounter += count; }
                    else if (sweet == "waffles") { wafflesCounter += count; sweetCounter += count; }
                }
            }

            sb.AppendLine($"All bakery sold: {sweetCounter}");
            sb.AppendLine($"Total sum for charity: {totalMoney:F2} lv.");
            Console.WriteLine(sb);
        }
    }
}
