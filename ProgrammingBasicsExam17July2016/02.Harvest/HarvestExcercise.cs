using System;

namespace _02.Harvest
{
    public class HarvestExcercise
    {
        static void Main()
        {
            int vineyardArea = int.Parse(Console.ReadLine());
            double grapesInKgPerSquareMeter = double.Parse(Console.ReadLine());
            int litersOfVineNeeded = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            double totalGrapesInKgFromVineyard = vineyardArea * grapesInKgPerSquareMeter;
            const double grapesInKgForWineNeeded = 2.5;
            const double grapesForVineCoefficent = 0.4;
            double totalLitresOfVineProduced = grapesForVineCoefficent * 
                (totalGrapesInKgFromVineyard / grapesInKgForWineNeeded);

            if (totalLitresOfVineProduced < litersOfVineNeeded)
            {
                int additionalLitresOfVineNeeded = 
                    (int)Math.Floor(litersOfVineNeeded - totalLitresOfVineProduced);
                Console.Write("It will be a tough winter! ");
                Console.WriteLine(
                    $"More {additionalLitresOfVineNeeded} liters wine needed.");
            }
            else
            {
                Console.WriteLine(
                    $"Good harvest this year! Total wine: {totalLitresOfVineProduced} liters.");

                double litresOfVineLeft = 
                    Math.Ceiling(totalLitresOfVineProduced - litersOfVineNeeded);
                Console.Write($"{litresOfVineLeft} liters left -> ");
                double litresOfVinePerPerson = litresOfVineLeft / numberOfWorkers;
                Console.WriteLine($"{litresOfVinePerPerson} liters per person.");
            }
        }
    }
}
