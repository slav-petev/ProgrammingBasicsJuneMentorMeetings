using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationBetweenNumbers
{
    class OperationBetweenNumbersExcercise
    {
        static void Main(string[] args)
        {
            const string Addition = "+";
            const string Subtraction = "-";
            const string Multiplication = "*";
            const string Division = "/";
            const string ModulusDivision = "%";

            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = double.NaN;
            bool shouldPrintEvenOrOdd = (operation == Addition ||
                operation == Subtraction || operation == Multiplication);
            bool shouldCheckForZeroSecondArgument = (operation == Division ||
                operation == ModulusDivision);
            if (shouldPrintEvenOrOdd)
            {
                if (operation == Addition)
                {
                    result = firstNumber + secondNumber;
                }
                else if (operation == Subtraction)
                {
                    result = firstNumber - secondNumber;
                }
                else
                {
                    result = firstNumber * secondNumber;
                }

                string resultType = (result % 2 == 0) ? "even" : "odd";

                Console.WriteLine("{0} {1} {2} = {3} - {4}",
                    firstNumber, operation, secondNumber, result, resultType);
            }
            else if (shouldCheckForZeroSecondArgument)
            {
                if (secondNumber == 0.0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                }
                else
                {
                    string resultFormat = string.Empty;
                    if (operation == Division)
                    {
                        result = firstNumber / secondNumber;
                        resultFormat = "{3:F2}";
                    }
                    else
                    {
                        result = firstNumber % secondNumber;
                        resultFormat = "{3}";
                    }

                    string outputFormatString =
                        string.Concat("{0} {1} {2} = ", resultFormat);

                    Console.WriteLine(outputFormatString,
                        firstNumber, operation, secondNumber, result);
                }
            }
        }
    }
}
