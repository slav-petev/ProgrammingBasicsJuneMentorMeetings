using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTom
{
    class SleepyTomExcercise
    {
        static void Main(string[] args)
        {
            const int numberOfDaysInYear = 365;
            const int playMinutesPerHoliday = 127;
            const int playMinutesPerWorkingDay = 63;
            const int neededplayMinutesPerYear = 30000;

            int holidays = int.Parse(Console.ReadLine());

            int workingDays = numberOfDaysInYear - holidays;

            int workingDaysPlayMinutesPerYear = workingDays * playMinutesPerWorkingDay;
            int holidaysPlayMinutesPerYear = playMinutesPerHoliday * holidays;
            int actualPlayTimePerYear = workingDaysPlayMinutesPerYear + 
                holidaysPlayMinutesPerYear;

            int playTimeDifference = Math.Abs(actualPlayTimePerYear - neededplayMinutesPerYear);
            int actualPlayTimeDifferenceHours = playTimeDifference / 60;
            int actualPlayTimeDifferenceMinutes = playTimeDifference % 60;
            string quantityAdjective = string.Empty;
            if (actualPlayTimePerYear > neededplayMinutesPerYear)
            {
                Console.WriteLine("Tom will run away");
                quantityAdjective = "more";
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                quantityAdjective = "less";
            }

            Console.WriteLine("{0} hours and {1} minutes {2} for play",
                    actualPlayTimeDifferenceHours, actualPlayTimeDifferenceMinutes,
                    quantityAdjective);
        }
    }
}
