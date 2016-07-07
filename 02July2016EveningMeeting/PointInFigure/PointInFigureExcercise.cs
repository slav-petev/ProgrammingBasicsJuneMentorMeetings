using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
    class PointInFigureExcercise
    {
        static void Main(string[] args)
        {
            int blockSize = int.Parse(Console.ReadLine());
            int pointToCheckX = int.Parse(Console.ReadLine());
            int pointToCheckY = int.Parse(Console.ReadLine());

            int lowerRectangleLowerLeftPointX = 0;
            int lowerRectangleLowerLeftPointY = 0;

            int lowerRectangleLowerRightPointX = 3 * blockSize;

            int lowerRectangleUpperLeftPointY = blockSize;

            bool pointHorizontallyInsideLowerRectangle =
                lowerRectangleLowerLeftPointX < pointToCheckX && 
                pointToCheckX < lowerRectangleLowerRightPointX;
            bool pointVerticallyInsideLowerRectangle =
                lowerRectangleLowerLeftPointY < pointToCheckY &&
                pointToCheckY < lowerRectangleUpperLeftPointY;
            bool pointInsideLowerRectangle =
                pointHorizontallyInsideLowerRectangle && pointVerticallyInsideLowerRectangle;

            bool pointHorizontallyOutsideLowerRectangle =
                pointToCheckX < lowerRectangleLowerLeftPointX ||
                lowerRectangleLowerRightPointX < pointToCheckX;
            bool pointVericallyOutsideLowerRectangle =
                pointToCheckY < lowerRectangleLowerLeftPointY ||
                lowerRectangleUpperLeftPointY < pointToCheckY;
            bool pointOutsideLowerRectangle =
                pointHorizontallyOutsideLowerRectangle || pointVericallyOutsideLowerRectangle;

            bool pointOnBorderOfLowerRectangle =
                !pointInsideLowerRectangle && !pointOutsideLowerRectangle;

            int upperRectangleLowerLeftPointX = blockSize;
            int upperRectangleLowerLeftPointY = blockSize;

            int upperRectangleLowerRightPointX = 2 * blockSize;

            int upperRectangleUpperLeftPointY = 4 * blockSize;

            bool pointHorizontallyInsideupperRectangle =
                upperRectangleLowerLeftPointX < pointToCheckX &&
                pointToCheckX < upperRectangleLowerRightPointX;
            bool pointVerticallyInsideUpperRectangle =
                upperRectangleLowerLeftPointY < pointToCheckY &&
                pointToCheckY < upperRectangleUpperLeftPointY;
            bool pointInsideUpperRectangle =
                pointHorizontallyInsideupperRectangle && pointVerticallyInsideUpperRectangle;

            bool pointHorizontallyOutsideUpperRectangle =
                pointToCheckX < upperRectangleLowerLeftPointX ||
                upperRectangleLowerRightPointX < pointToCheckX;
            bool pointVericallyOutsideUpperRectangle =
                pointToCheckY < upperRectangleLowerLeftPointY ||
                upperRectangleUpperLeftPointY < pointToCheckY;
            bool pointOutsideUpperRectangle =
                pointHorizontallyOutsideUpperRectangle || pointVericallyOutsideUpperRectangle;

            bool pointOnBorderOfUpperRectangle =
                !pointInsideUpperRectangle && !pointOutsideUpperRectangle;

            bool pointOnCommonSideOfRectangles =
                pointOnBorderOfLowerRectangle && pointOnBorderOfUpperRectangle &&
                blockSize < pointToCheckX && pointToCheckX < 2 * blockSize;

            bool pointInsideFigure = pointInsideLowerRectangle ||
                pointInsideUpperRectangle || pointOnCommonSideOfRectangles;
            bool pointOutsideFigure = pointOutsideLowerRectangle && pointOutsideUpperRectangle;
            bool pointOnBorderOfFigure = !pointInsideFigure && !pointOutsideFigure;

            if (pointInsideFigure)
            {
                Console.WriteLine("inside");
            }
            else if (pointOnBorderOfFigure)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
