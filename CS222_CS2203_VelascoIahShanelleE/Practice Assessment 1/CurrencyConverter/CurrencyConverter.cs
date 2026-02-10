using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.Write("Enter amount in USD: ");
        double USD = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exchange rate from USD to EUR: ");
        double exchangeRate = Convert.ToDouble(Console.ReadLine());

        double EUR = USD * exchangeRate;

        Console.WriteLine("Amount in EUR: " + EUR.ToString("F2"));
    }
}

