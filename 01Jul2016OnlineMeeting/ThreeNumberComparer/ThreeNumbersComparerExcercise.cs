using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeNumberComparer
{
    class ThreeNumbersComparerExcercise
    {
        static void Main(string[] args)
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber == secondNumber && secondNumber == thirdNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
