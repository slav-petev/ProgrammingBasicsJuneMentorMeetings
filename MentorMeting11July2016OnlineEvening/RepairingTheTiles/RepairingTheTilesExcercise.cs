using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheTiles
{
    class RepairingTheTilesExcercise
    {
        static void Main(string[] args)
        {
            int platformSideLength = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLength = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchLength = int.Parse(Console.ReadLine());

            int platformArea = platformSideLength * platformSideLength;
            int benchArea = benchWidth * benchLength;
            int platformAreaToBeCoveredWithTiles = platformArea - benchArea;
            double tileArea = tileWidth * tileLength;

            double numberOfTilesToCoverThePlatform = platformAreaToBeCoveredWithTiles / tileArea;

            double timeNeededToCoverThePlatform = numberOfTilesToCoverThePlatform * 0.2;

            Console.WriteLine(numberOfTilesToCoverThePlatform);
            Console.WriteLine(timeNeededToCoverThePlatform);
        }
    }
}
