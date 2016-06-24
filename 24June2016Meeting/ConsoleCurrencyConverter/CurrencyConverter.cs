using System;

public class CurrencyConverter
{
    static void Main()
    {
        const decimal bgnInUsd = 1.79549M;
        const decimal bgnInEuro = 1.95583M;
        const decimal bgnInGbp = 2.53405M;

        const decimal eurInUsd = bgnInEuro / bgnInUsd;
        const decimal eurInGbp = bgnInEuro / bgnInGbp;

        const decimal usdInGbp = bgnInUsd / bgnInGbp;

        decimal sourceCurrencyAmount = decimal.Parse(Console.ReadLine());
        string sourceCurrencyName = Console.ReadLine();
        string convertedCurrencyName = Console.ReadLine();

        // sourceCUrrency - USD, targetCurrency - BGN, AMount - 20
        decimal convertedCurrencyAmount = decimal.MinusOne;
        if (sourceCurrencyName == "USD")
        {
            //Kakvo se sluchva - I will encounter Kumcho
            if (convertedCurrencyName == "BGN")
            {
                convertedCurrencyAmount = sourceCurrencyAmount * bgnInUsd;
            }

            if (convertedCurrencyName == "EUR")
            {
                convertedCurrencyAmount = sourceCurrencyAmount / eurInUsd;
            }

            if (convertedCurrencyName == "GBP")
            {
                convertedCurrencyAmount = sourceCurrencyAmount * usdInGbp;
            }
        }

        if (sourceCurrencyName == "EUR")
        {
            if (convertedCurrencyName == "BGN")
            {
                convertedCurrencyAmount = sourceCurrencyAmount * bgnInEuro;
            }

            if (convertedCurrencyName == "USD")
            {
                convertedCurrencyAmount = sourceCurrencyAmount * eurInUsd;
            }

            if (convertedCurrencyName == "GBP")
            {
                convertedCurrencyAmount = sourceCurrencyAmount * eurInGbp;
            }
        }

        if (sourceCurrencyName == "GBP")
        {
            if (convertedCurrencyName == "BGN")
            {
                convertedCurrencyAmount = sourceCurrencyAmount * bgnInGbp;
            }

            if (convertedCurrencyName == "USD")
            {
                convertedCurrencyAmount = sourceCurrencyAmount / usdInGbp;
            }

            if (convertedCurrencyName == "EUR")
            {
                convertedCurrencyAmount = sourceCurrencyAmount / eurInGbp;
            }
        }

        if (sourceCurrencyName == "BGN")
        {
            if (convertedCurrencyName == "EUR")
            {
                convertedCurrencyAmount = sourceCurrencyAmount / bgnInEuro;
            }

            if (convertedCurrencyName == "USD")
            {
                convertedCurrencyAmount = sourceCurrencyAmount / bgnInUsd;
            }

            if (convertedCurrencyName == "GBP")
            {
                convertedCurrencyAmount = sourceCurrencyAmount / bgnInGbp;
            }
        }

        Console.WriteLine("{0:F2} {1}", convertedCurrencyAmount, convertedCurrencyName);
    }
}