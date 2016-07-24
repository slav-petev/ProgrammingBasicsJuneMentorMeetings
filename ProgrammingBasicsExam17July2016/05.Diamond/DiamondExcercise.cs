using System;

namespace _05.Diamond
{
    public class DiamondExcercise
    {
        static void Main()
        {
            int diamondSize = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",
                new string('.', diamondSize), 
                new string('*', 3 * diamondSize));

            int numberOfDotsPerSideInUpperPart = diamondSize - 1;
            int numberOfDotsInsideUpperPart = 3 * diamondSize;
            int upperPartHeight = diamondSize - 1;

            for (int currentDiamondRow = 0;
                currentDiamondRow < upperPartHeight; currentDiamondRow++)
            {
                string dotsPerSideInCurrentRow = new string('.', numberOfDotsPerSideInUpperPart);
                string dotsInsideCurrentRow = new string('.', numberOfDotsInsideUpperPart);
                Console.WriteLine("{0}*{1}*{0}", dotsPerSideInCurrentRow, dotsInsideCurrentRow);

                numberOfDotsPerSideInUpperPart--;
                numberOfDotsInsideUpperPart += 2;
            }

            Console.WriteLine(new string('*', 5 * diamondSize));

            int numberOfDotsPerSideInLowerPart = 1;
            int numberOfDotsInsideLowerPart = 5 * diamondSize -
                2 * numberOfDotsPerSideInLowerPart - 2;
            int lowerPartHeight = 2 * diamondSize;

            for (int currentDiamondRow = 0;
                currentDiamondRow < lowerPartHeight; currentDiamondRow++)
            {
                string dotsPerSideInCurrentRow = 
                    new string('.', numberOfDotsPerSideInLowerPart);
                string dotsInSideCurrentRow = new string('.', numberOfDotsInsideLowerPart);

                Console.WriteLine("{0}*{1}*{0}",
                    dotsPerSideInCurrentRow, dotsInSideCurrentRow);

                numberOfDotsPerSideInLowerPart++;
                numberOfDotsInsideLowerPart -= 2;
            }

            Console.WriteLine("{0}{1}{0}",
                new string('.', numberOfDotsPerSideInLowerPart),
                new string('*', 5 * diamondSize - 2 * numberOfDotsPerSideInLowerPart));
        }
    }
}
