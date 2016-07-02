using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class TransportPriceCalculator
    {
        static void Main(string[] args)
        {
            const decimal taxiInitialPrice = 0.7M;
            const decimal taxiDayTariff = 0.79M;
            const decimal taxiNightTariff = 0.9M;

            const decimal busTariff = 0.09M;

            const decimal trainTariff = 0.06M;

            int kilometersToTravel = int.Parse(Console.ReadLine());
            string dayPeriod = Console.ReadLine();

            decimal cheapestTransportPrice = decimal.MinusOne;
            
            if (kilometersToTravel < 20)
            {
                decimal taxiPrice = decimal.MinusOne;
                if (dayPeriod == "day")
                {
                    taxiPrice = taxiDayTariff * kilometersToTravel +
                        taxiInitialPrice;
                }
                else if (dayPeriod == "night")
                {
                    taxiPrice = taxiNightTariff * kilometersToTravel +
                        taxiInitialPrice;
                }

                cheapestTransportPrice = taxiPrice;
            }
            else if (kilometersToTravel >= 20 && kilometersToTravel < 100)
            {
                decimal busPrice = busTariff * kilometersToTravel;

                cheapestTransportPrice = busPrice;
            }
            else
            {
                decimal trainPrice = trainTariff * kilometersToTravel;

                cheapestTransportPrice = trainPrice; 
            }

            Console.WriteLine(cheapestTransportPrice);
        }
    }
}
