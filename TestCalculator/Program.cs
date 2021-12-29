using System;
using static System.Console;

namespace TestCalculator
{
    public class Program
    {
        static double ReadUserDouble()
        {
            double userInput = 0;
            bool hasUserMakedTheIput = false;
            do
            {
                if (Double.TryParse(ReadLine(), out userInput))
                    hasUserMakedTheIput = true;
                else
                    WriteLine("Felaktikigt format, ange ett tal");
            }
            while (!hasUserMakedTheIput);
            return userInput;
        }

        static string ReadUserOperand()
        {
            string userInput = "";
            string operatorList = "*/ +-";
            bool hasUserMakedTheIput = false;
            do
            {
                userInput = Console.ReadLine();


                if (operatorList.Contains(userInput) && userInput.Length == 1)
                    hasUserMakedTheIput = true;
                else
                    WriteLine("Felaktikigt format, ange någon av operanderna * / + -");

            } while (!hasUserMakedTheIput);
            return userInput;
        }


         static double Addition(double [] doubleArray)
        {
            double result = 0;
            for (int i = 0; i < doubleArray.Length; i++)
            {
                result += doubleArray[i];
            }
            return result;
        }

        public static double Subtraction(double[] doubleArray)
        {
            if (doubleArray.Length == 0)
                return 0;
            double value = doubleArray[0];


            if (doubleArray.Length == 1)
                return value;

            

            for (int i = 1; i < doubleArray.Length; i++)
            {
                value -= doubleArray[i];
            }
            return value;
        }

        public static double Addition(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }

        public static double Division(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
                throw new DivideByZeroException("Du kan inte dela med noll");
            else
                return firstArgument / secondArgument;
        }

        public static double Subtraction(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }


        public static double Multiplication(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }

        static void PrintResultToConsole(double firstArgument, double secondArgument, double result, string usedOperator)
        {
            Console.WriteLine($"{firstArgument} {usedOperator} {secondArgument} = {result}");
        }

        static void Main(string[] args)
        {
            bool running = true;
            WriteLine("Välkommen till calculatorn version 1.0");


            double firstArgument, secondArgument, result = 0;
            string userOperator = "";
            while (running)
            {
                WriteLine("Skriv in ditt första tal");
                firstArgument = ReadUserDouble();
                WriteLine("Skriv in operand, välj mellan * / + - ");
                userOperator = ReadUserOperand();
                WriteLine("Skriv in ditt andra tal");
                secondArgument = ReadUserDouble();
                switch (userOperator)
                {
                    case "*":
                        result = Multiplication(firstArgument, secondArgument);
                        break;
                    case "/":
                        if ((firstArgument > 0) && (secondArgument == 0))
                            PrintDivsionError();
                        else
                            result = Division(firstArgument, secondArgument);
                        break;
                    case "+":
                        result = Addition(firstArgument, secondArgument);
                        break;
                    case "-":
                        result = Subtraction(firstArgument, secondArgument);
                        break;

                    default:
                        WriteLine("Something strange has happened, call the suport");
                        break;
                }
                PrintResultToConsole(firstArgument, secondArgument, result, userOperator);


                WriteLine("Vill du avsluta, tryck y plus enter annars bara enter för ny beräkning");
                if (ReadLine() == "y")
                    Environment.Exit(0);
            }

        }

        private static void PrintDivsionError()
        {
            WriteLine("Ogliltlig nämnare för division");
        }
    }
}
