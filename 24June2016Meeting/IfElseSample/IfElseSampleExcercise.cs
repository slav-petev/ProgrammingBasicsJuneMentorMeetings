using System;

public class IfElseSampleExcercise
{
    public static void Main()
    {
        
        int number = int.Parse(Console.ReadLine());

        //1) If sample
        if (number == 1)
        {
            Console.WriteLine("1");
        }

        if (number == 2)
        {
            Console.WriteLine("2");
        }

        //2) If-Else sample
        if (number == 1)
        {
            Console.WriteLine("1");
        }
        else if (number == 2)
        {
            Console.WriteLine("2");
        }
    }
}