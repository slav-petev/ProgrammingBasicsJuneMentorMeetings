using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFromZeroToOneHundredNamePrinterExcercise
{
    class NumberFromZeroToOneHundredNamePrinter
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var numberName = string.Empty;
            if (number < 0 || number > 100)
            {
                Console.WriteLine("Invalid Number");
            }
            else if (number >= 0 && number <= 19)
            {
                switch (number)
                {
                    case 0:
                        numberName = "Zero";
                        break;
                    case 1:
                        numberName = "One";
                        break;
                    case 2:
                        numberName = "Two";
                        break;
                    case 3:
                        numberName = "Three";
                        break;
                    case 4:
                        numberName = "Four";
                        break;
                    case 5:
                        numberName = "Five";
                        break;
                    case 6:
                        numberName = "Six";
                        break;
                    case 7:
                        numberName = "Seven";
                        break;
                    case 8:
                        numberName = "Eight";
                        break;
                    case 9:
                        numberName = "Nine";
                        break;
                    case 10:
                        numberName = "Ten";
                        break;
                    case 11:
                        numberName = "Eleven";
                        break;
                    case 12:
                        numberName = "Twelve";
                        break;
                    case 13:
                        numberName = "Thirteen";
                        break;
                    case 14:
                        numberName = "Fourteen";
                        break;
                    case 15:
                        numberName = "Fifteen";
                        break;
                    case 16:
                        numberName = "Sixteen";
                        break;
                    case 17:
                        numberName = "Seventeen";
                        break;
                    case 18:
                        numberName = "Eighteen";
                        break;
                    case 19:
                        numberName = "Nineteen";
                        break;
                    default:
                        break;
                }
            }
            else if (number >= 20 && number <= 99)
            {
                var firstDigit = number / 10;
                var lastDigit = number % 10;

                switch (firstDigit)
                {
                    case 2:
                        numberName += "Twenty ";
                        break;
                    case 3:
                        numberName += "Thirty ";
                        break;
                    case 4:
                        numberName += "Fourty ";
                        break;
                    case 5:
                        numberName += "Fifty ";
                        break;
                    case 6:
                        numberName += "Sixty ";
                        break;
                    case 7:
                        numberName += "Seventy ";
                        break;
                    case 8:
                        numberName += "Eighty ";
                        break;
                    case 9:
                        numberName += "Ninety ";
                        break;
                    default:
                        break;
                }

                switch (lastDigit)
                {
                    case 1:
                        numberName += "One";
                        break;
                    case 2:
                        numberName += "Two";
                        break;
                    case 3:
                        numberName += "Three";
                        break;
                    case 4:
                        numberName += "Four";
                        break;
                    case 5:
                        numberName += "Five";
                        break;
                    case 6:
                        numberName += "Six";
                        break;
                    case 7:
                        numberName += "Seven";
                        break;
                    case 8:
                        numberName += "Eight";
                        break;
                    case 9:
                        numberName += "Nine";
                        break;
                }
            }
            else if (number == 100)
            {
                numberName = "One Hundred";
            }

            if (numberName != string.Empty)
            {
                Console.WriteLine(numberName.Trim()); 
            }
        }
    }
}
