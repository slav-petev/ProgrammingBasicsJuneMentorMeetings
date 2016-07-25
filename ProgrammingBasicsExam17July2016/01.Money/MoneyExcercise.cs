using System;

namespace _01.Money
{
    public class MoneyExcercise
    {
        static void Main()
        {
            int bitCoinsCount = int.Parse(Console.ReadLine());
            double chineseYansCount = double.Parse(Console.ReadLine());
            double changeBuroCommissionRate = double.Parse(Console.ReadLine());

            const double bgnInBitCoin = 1168;
            double bgnFromBitCoinsAmount = bitCoinsCount * bgnInBitCoin;
            const double dollarsInChineseYuan = 0.15;
            double dollarsFromChineseYuansAmount = chineseYansCount * dollarsInChineseYuan;
            const double bgnInDollar = 1.76;
            double bgnFromChineseYuansAmount = dollarsFromChineseYuansAmount * bgnInDollar;

            double totalBgnAmount = bgnFromBitCoinsAmount + bgnFromChineseYuansAmount;
            const double bgnInEuro = 1.95;
            double totalEuroAmount = totalBgnAmount / bgnInEuro;

            double commissionAmount = (changeBuroCommissionRate / 100) * totalEuroAmount;
            double netEuroAmount = totalEuroAmount - commissionAmount;

            Console.WriteLine(netEuroAmount);
        }
    }
}
