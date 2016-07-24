using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BackToThePast
{
    public class BackToThePastExcercise
    {
        static void Main()
        {
            decimal inheritedMoneyAmount = decimal.Parse(Console.ReadLine());
            int finalYearToLiveInThePast = int.Parse(Console.ReadLine());

            const int startYearToLiveInThePast = 1800;
            const decimal baseExpensesPerYear = 12000M;
            const int ageAtStartOfPeriod = 18;
            decimal totalExpensesForTimeInThePast = decimal.Zero;
            for (int currentYearInThePast = startYearToLiveInThePast;
                    currentYearInThePast <= finalYearToLiveInThePast; currentYearInThePast++)
            {
                if (currentYearInThePast % 2 == 0)
                {
                    totalExpensesForTimeInThePast += baseExpensesPerYear;
                }
                else
                {
                    int currentAge = ageAtStartOfPeriod +
                        (currentYearInThePast - startYearToLiveInThePast);
                    decimal currentYearExpenses = baseExpensesPerYear +
                        50 * currentAge;
                    totalExpensesForTimeInThePast += currentYearExpenses;
                }
            }

            decimal moneyDifference = Math.Abs(
                inheritedMoneyAmount - totalExpensesForTimeInThePast);
            if (inheritedMoneyAmount >= totalExpensesForTimeInThePast)
            {
                Console.Write("Yes! He will live a carefree life and will have ");
                Console.WriteLine(
                    $"{moneyDifference:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {moneyDifference:F2} dollars to survive.");
            }
        }
    }
}
