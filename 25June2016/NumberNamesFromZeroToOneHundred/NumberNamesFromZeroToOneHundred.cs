using System;

public class NumberNamesFromZeroToOneHundred
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number >= 0 && number <= 19)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 11:
                    Console.WriteLine("Eleven");
                    break;
                case 12:
                    Console.WriteLine("Twelve");
                    break;
                case 13:
                    Console.WriteLine("Thirteen");
                    break;
                case 14:
                    Console.WriteLine("Fourteen");
                    break;
                case 15:
                    Console.WriteLine("Fifteen");
                    break;
                case 16:
                    Console.WriteLine("Sixteen");
                    break;
                case 17:
                    Console.WriteLine("Seventeen");
                    break;
                case 18:
                    Console.WriteLine("Eighteen");
                    break;
                case 19:
                    Console.WriteLine("Nineteen");
                    break;
                default:
                    break;
            }

        }
        else if (number >= 20 && number <= 99)
        {
            int firstDigit = number / 10;
            int lastDigit = number % 10;

            string numberName = string.Empty;

            switch (firstDigit)
            {
                case 2:
                    numberName += "Twenty";
                    break;
                case 3:
                    numberName += "Thirty";
                    break;
                case 4:
                    numberName += "Fourty";
                    break;
                case 5:
                    numberName += "Fifty";
                    break;
                case 6:
                    numberName += "Sixty";
                    break;
                case 7:
                    numberName += "Seventy";
                    break;
                case 8:
                    numberName += "Eighty";
                    break;
                case 9:
                    numberName += "Ninety";
                    break;
            }
            numberName += " ";

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

            Console.WriteLine(numberName.Trim());
        }
        else if (number == 100)
        {
            Console.WriteLine("One Hundred");
        }
        else
        {
            Console.WriteLine("Invalid Number");
        }
    }
}