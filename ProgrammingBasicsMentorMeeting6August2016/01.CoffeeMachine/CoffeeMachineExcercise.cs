using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CoffeeMachine
{
    public class CoffeeMachineExcercise
    {
        static void Main()
        {
            int numberOfFiveStotinkiInMachineTray =
                int.Parse(Console.ReadLine());
            int numberOfTenStotinkiInMachineTray =
                int.Parse(Console.ReadLine());
            int numberOfTwentyStotinkiInMachineTray =
                int.Parse(Console.ReadLine());
            int numberOfFiftyStotinkiInMachineTray =
                int.Parse(Console.ReadLine());
            int numberOfOneBgnInMachine =
                int.Parse(Console.ReadLine());
            double moneyPutInTheMachine =
                double.Parse(Console.ReadLine());
            double selectedDrinkPrice =
                double.Parse(Console.ReadLine());

            if (moneyPutInTheMachine < selectedDrinkPrice)
            {
                double additionalMoneyToPutInMachine = 
                    selectedDrinkPrice - moneyPutInTheMachine;

                Console.WriteLine("More {0:F2}",
                    additionalMoneyToPutInMachine);
            }
            else
            {
                double fiveStotinkiInMachineTrayAmount = 
                    numberOfFiveStotinkiInMachineTray * 0.05;

                double tenStotinkiInMachineTrayAmount = 
                    numberOfTenStotinkiInMachineTray * 0.1;

                double twentyStotinkiInMachineTrayAmount = 
                    numberOfTwentyStotinkiInMachineTray * 0.2;

                double fiftyStotinkiInMachineTrayAmount = 
                    numberOfFiftyStotinkiInMachineTray * 0.5;

                double oneBgnInMachineTrayAmount =
                    numberOfOneBgnInMachine;

                double totalMoneyInMachineTraysAmount =
                fiveStotinkiInMachineTrayAmount +
                tenStotinkiInMachineTrayAmount +
                twentyStotinkiInMachineTrayAmount +
                fiftyStotinkiInMachineTrayAmount +
                oneBgnInMachineTrayAmount;

                double changeToGive = moneyPutInTheMachine -
                                      selectedDrinkPrice;
                double moneyDifference = Math.Abs(
                    totalMoneyInMachineTraysAmount - changeToGive);
                if (totalMoneyInMachineTraysAmount < moneyPutInTheMachine)
                {
                    Console.WriteLine("No {0:F2}", 
                        moneyDifference);
                }
                else
                {
                    Console.WriteLine("Yes {0:F2}",
                        moneyDifference);
                }
            }
        }
    }
}
