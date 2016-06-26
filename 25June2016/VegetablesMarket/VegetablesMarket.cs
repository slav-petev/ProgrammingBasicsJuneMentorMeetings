using System;

public class VegetablesMarket
{
    static void Main(string[] args)
    {
        const decimal bgnInEur = 1.94M;

        decimal vegetablesPricePerKgInBgn = decimal.Parse(Console.ReadLine());
        decimal fruitsPricePerKgInBgn = decimal.Parse(Console.ReadLine());
        int totalVegetablesWeightInKg = int.Parse(Console.ReadLine());
        int totalFruitWeightInKg = int.Parse(Console.ReadLine());

        decimal totalVegetablesIncomeInBgn =
            totalVegetablesWeightInKg * vegetablesPricePerKgInBgn;
        decimal totalFruitsIncomeInBgn =
            totalFruitWeightInKg * fruitsPricePerKgInBgn;
        decimal totalIncomeInBgn =
            totalVegetablesIncomeInBgn + totalFruitsIncomeInBgn;

        decimal totalIncomeInEur = totalIncomeInBgn / bgnInEur;

        Console.WriteLine(totalIncomeInEur);
    }
}