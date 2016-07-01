using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreas
{
    class FigureAreasCalculatorExcercise
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine();

            var figureArea = double.NaN;

            if (figureType == "square")
            {
                var squareSide = double.Parse(Console.ReadLine());

                figureArea = squareSide * squareSide;
            }
            else if (figureType == "rectangle")
            {
                var length = double.Parse(Console.ReadLine());
                var width = double.Parse(Console.ReadLine());

                figureArea = length * width;
            }
            else if (figureType == "circle")
            {
                var radius = double.Parse(Console.ReadLine());

                figureArea = Math.PI * radius * radius;
            }
            else if (figureType == "triangle")
            {
                var triangleSide = double.Parse(Console.ReadLine());
                var triangleHeight = double.Parse(Console.ReadLine());

                figureArea = (triangleSide * triangleHeight) / 2;
            }

            Console.WriteLine("{0:F3}", figureArea);
        }
    }
}
