using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAfterFifteenMinutes
{
    class TimeAfterFifteenMinutesCalculatorExcercise
    {
        static void Main(string[] args)
        {
            const int minutesInHour = 60;

            var initialHours = int.Parse(Console.ReadLine());
            var initialMinutes = int.Parse(Console.ReadLine());

            var timeInMinutes = (initialHours * minutesInHour) + initialMinutes;
            var timeInMinutesAfterFifteenMinutes = timeInMinutes + 15;

            var finalHours = timeInMinutesAfterFifteenMinutes / minutesInHour;
            var finalMinutes = timeInMinutesAfterFifteenMinutes % minutesInHour;

            var finalHoursToBeDisplayed = finalHours % 24; 
            Console.WriteLine("{0}:{1:00}", finalHoursToBeDisplayed, finalMinutes);
        }
    }
}
