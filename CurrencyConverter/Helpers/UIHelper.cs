using System;
using System.Collections.Generic;

namespace CurrencyConverter.Helpers
{
    public static class UIHelper
    {
        public static void ShowAvailableCurrencies(Dictionary<string, decimal> menuItems)
        {
            Console.Clear();
            Console.WriteLine("Available currencies");
            Console.WriteLine();

            foreach (var item in menuItems)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }

        public static void ShowOrderedCurrenciesToSelect(Dictionary<string, decimal> menuItems, string side)
        {
            Console.WriteLine($"Select your {side} currency");
            Console.WriteLine();

            int index = 0;

            foreach (var item in menuItems)
            {
                index++;
                Console.WriteLine($"{index}. {item.Key} {item.Value}");
            }

            Console.WriteLine();
            Console.WriteLine("Type appropriate digit to select currency");
        }

        internal static void ShowSelectedCurrencyToExchange(string side, string currencyCode, decimal exchangeRate)
        {
            Console.WriteLine($"{side} currency selected: {currencyCode} {exchangeRate}");
            Console.WriteLine();
        }

        public static int GetSelectedItemIndex()
        {
            var keyinfo = Console.ReadLine();

            if (int.TryParse(keyinfo, out int itemNumber))
            {
                return itemNumber - 1;
            }

            throw new Exception("Parsing error");
        }

        internal static decimal GetEnteredSourceCurrencyAmount()
        {
            Console.WriteLine();
            Console.WriteLine("Enter your source currency Amount");

            var keyinfo = Console.ReadLine();

            Console.WriteLine();

            return decimal.Parse(keyinfo);
        }

        public static void ShowMainMenu()
        {
            Console.WriteLine();

            Console.WriteLine("1. Exchange currency");
            Console.WriteLine("2. Add new currency");
            Console.WriteLine("3. Exit");
        }

        internal static void DisplayGoBackMessage()
        {
            Console.WriteLine("Press Backspace to go back to the main menu");
        }

        internal static void DisplayConvertaionResult(string currencyCode, decimal destinationCurrencyAmount)
        {
            Console.WriteLine($"Finally you have {currencyCode} {String.Format("{0:0.0000}", destinationCurrencyAmount)}");
        }


    }
}



