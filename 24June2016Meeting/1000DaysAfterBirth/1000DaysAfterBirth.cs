using System;
using System.Globalization;

public class _1000DaysAfterBirth
{
    public static void Main()
    {
        const string dateFormat = "d/M/yyyy";

        DateTime birthDate = DateTime.ParseExact(Console.ReadLine(),
            dateFormat, null);

        DateTime dateAfterThousandDays = birthDate.AddDays(999);

        string formattedOutputDate = dateAfterThousandDays.ToString(dateFormat);
        Console.WriteLine(formattedOutputDate);
    }
}