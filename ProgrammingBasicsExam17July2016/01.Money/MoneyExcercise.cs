using System;

namespace _01.Money
{
    public class MoneyExcercise
    {
        static void Main()
        {
            int bitCoinsCount = int.Parse(Console.ReadLine());
            decimal chineseYansCount = decimal.Parse(Console.ReadLine());
            decimal changeBuroCommissionRate = decimal.Parse(Console.ReadLine());

            const decimal bgnInBitCoin = 1168;
            decimal bgnFromBitCoinsAmount = bitCoinsCount * bgnInBitCoin;
            const decimal dollarsInChineseYuan = 0.15M;
            decimal dollarsFromChineseYuansAmount = chineseYansCount * dollarsInChineseYuan;
            const decimal bgnInDollar = 1.76M;
            decimal bgnFromChineseYuansAmount = dollarsFromChineseYuansAmount * bgnInDollar;

            decimal totalBgnAmount = bgnFromBitCoinsAmount + bgnFromChineseYuansAmount;
            const decimal bgnInEuro = 1.95M;
            decimal totalEuroAmount = totalBgnAmount / bgnInEuro;

            decimal commissionAmount = (changeBuroCommissionRate / 100) * totalEuroAmount;
            decimal netEuroAmount = totalEuroAmount - commissionAmount;

            Console.WriteLine($"{netEuroAmount:F12}");
        }
    }
}
