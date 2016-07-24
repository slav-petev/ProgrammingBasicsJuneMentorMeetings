using System;

namespace _06.StopNumber
{
    public class StopNumberExcercise
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());

            for (int currentNumber = lastNumber;
                currentNumber >= firstNumber; currentNumber--)
            {
                if (currentNumber % 6 == 0)
                {
                    if (currentNumber == stopNumber)
                    {
                        break;
                    }

                    Console.Write("{0} ", currentNumber);
                }
            }
        }
    }
}
