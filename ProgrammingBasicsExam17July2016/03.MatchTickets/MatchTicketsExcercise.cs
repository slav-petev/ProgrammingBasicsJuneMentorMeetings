using System;

namespace _03.MatchTickets
{
    public class MatchTicketsExcercise
    {
        static void Main()
        {
            decimal totalBudgetForEuroFinals = decimal.Parse(Console.ReadLine());
            string ticketCategory = Console.ReadLine();
            int numberOfFans = int.Parse(Console.ReadLine());

            decimal percentOfBudgetForTravel;
            if (numberOfFans <= 4)
            {
                percentOfBudgetForTravel = 0.75M;
            }
            else if (numberOfFans >= 5 && numberOfFans <= 9)
            {
                percentOfBudgetForTravel = 0.6M;
            }
            else if (numberOfFans >= 10 && numberOfFans <= 24)
            {
                percentOfBudgetForTravel = 0.5M;
            }
            else if (numberOfFans >= 25 && numberOfFans <= 49)
            {
                percentOfBudgetForTravel = 0.4M;
            }
            else
            {
                percentOfBudgetForTravel = 0.25M;
            }

            decimal moneyForTicketsAmount = (decimal.One - percentOfBudgetForTravel) *  
                totalBudgetForEuroFinals;

            decimal ticketPrice;
            if (ticketCategory == "Normal")
            {
                ticketPrice = 249.99M;
            }
            else
            {
                ticketPrice = 499.99M;
            }

            decimal moneyForTicketsNeeded = ticketPrice * numberOfFans;

            if (moneyForTicketsNeeded <= moneyForTicketsAmount)
            {
                decimal moneyLeft = moneyForTicketsAmount - moneyForTicketsNeeded;
                Console.WriteLine($"Yes! You have {moneyLeft} leva left.");
            }
            else
            {
                decimal additionalMoneyNeeded = moneyForTicketsNeeded - moneyForTicketsAmount;
                Console.WriteLine($"Not enough money! You need {additionalMoneyNeeded} leva.");
            }
        }
    }
}
