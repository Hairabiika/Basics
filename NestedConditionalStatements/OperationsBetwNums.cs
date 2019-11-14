namespace Basic
{
    using System;
    public class Journey
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    double sum = firstNumber + secondNumber;
                    Console.Write("{0} + {1} = {2} - ", firstNumber, secondNumber, sum);
                    if (sum % 2 == 0) { Console.WriteLine("even"); }
                    else Console.WriteLine("odd");
                    break;

                case '-':
                    double sub = firstNumber - secondNumber;
                    Console.Write("{0} - {1} = {2} - ", firstNumber, secondNumber, sub);
                    if (sub % 2 == 0) { Console.WriteLine("even"); }
                    else Console.WriteLine("odd");
                    break;

                case '*':
                    double mul = firstNumber * secondNumber;
                    Console.Write("{0} * {1} = {2} - ", firstNumber, secondNumber, mul);
                    if (mul % 2 == 0) { Console.WriteLine("even"); }
                    else Console.WriteLine("odd");
                    break;

                case '/':
                    if (secondNumber == 0) 
                    {
                        Console.WriteLine("Cannot divide {0} by zero", firstNumber); 
                        break; 
                    }

                    double div = firstNumber / secondNumber; 
                    Console.WriteLine("{0} / {1} = {2:F2}", firstNumber, secondNumber, div);
                    break;

                case '%':
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                        break;
                    }

                    double mod = firstNumber % secondNumber;
                    Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, mod);
                    break;
            }
        }
    }
}
