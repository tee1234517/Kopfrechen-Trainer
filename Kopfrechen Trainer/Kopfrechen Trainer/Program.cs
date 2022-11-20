using System;

namespace Kopfrechen_Trainer 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rnd = new Random();

                int num1 = rnd.Next(1, 100);
                int num2 = rnd.Next(1, 100);
                int operation = rnd.Next(0, 3);

                decimal solution = Calculate(num1, num2, operation);
                decimal input = InputNumber(num1, num2, operation);

                bool dings = CheckIfTheInputIsRight(input, solution);

                if (dings == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Richtig!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Falsch!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }

        static decimal Calculate(decimal num1, decimal num2, int operation)
        {
            switch (operation)
            {
                case 1:
                    return num1 + num2;

                case 2:
                    return num1 - num2;

                default:
                    return num1 * num2;
            }
        }

        static bool CheckIfTheInputIsRight(decimal input, decimal solution)
        {
            return input == solution;
        }

        static decimal InputNumber(decimal num1, decimal num2, int operation)
        {
            decimal input;

            switch (operation)
            {
                case 1:
                    Console.Write("{0} + {1} = ", num1, num2);
                    input = Convert.ToDecimal(Console.ReadLine());
                    return input;

                case 2:
                    Console.Write("{0} - {1} = ", num1, num2);
                    input = Convert.ToDecimal(Console.ReadLine());
                    return input;

                default:
                    Console.Write("{0} * {1} = ", num1, num2);
                    input = Convert.ToDecimal(Console.ReadLine());
                    return input;
            }
        }
    }
}
