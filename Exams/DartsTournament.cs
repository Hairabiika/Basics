namespace Basic
{
    using System;
    public class DartsTournament
    {
        public static void Main()
        {
            int pointsNeeded = int.Parse(Console.ReadLine());
            int sum = 0;
            int moves = 0;
            bool bullseye = false;

            while (true)
            {
                string input = Console.ReadLine();
                moves++;
                if (input == "bullseye") { bullseye = true; break; }

                int points = int.Parse(Console.ReadLine());
                
                if (input == "double ring") { points *= 2; }
                if (input == "triple ring") { points *= 3; }
                sum += points;
                if (sum >= pointsNeeded) { break; }
            }

            if (bullseye) { Console.WriteLine($"Congratulations! You won the game with a bullseye in {moves} moves!"); }
            else
            {
                if (sum == pointsNeeded) { Console.WriteLine($"Congratulations! You won the game in {moves} moves!"); }
                else { Console.WriteLine($"Sorry, you lost. Score difference: {sum - pointsNeeded}."); }
            }
        }
    }
}
