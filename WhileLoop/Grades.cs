namespace Basic
{
    using System;
     
    public class Grades
    {
        public static void Main()
        {
            int badGrades = int.Parse(Console.ReadLine());
            int count = 0;
            double problems = 0;
            string lastExercise = "";
            double allGrades = 0;

            while (badGrades > 0)
            {
                string exercise = Console.ReadLine();
                if (exercise == "Enough")
                {
                    Console.WriteLine("Average score: {0:F2}", allGrades/problems);
                    Console.WriteLine($"Number of problems: {problems}");
                    Console.WriteLine($"Last problem: {lastExercise}");
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                lastExercise = exercise;
                problems++;
                allGrades += grade;
                
                if (grade <= 4) 
                { 
                    badGrades--;
                    count++;
                }

                if (badGrades == 0) 
                { 
                    Console.WriteLine($"You need a break, {count} poor grades."); 
                    break; 
                }
            }
        }
    }
}
