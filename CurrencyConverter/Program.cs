using System;

using CurrencyConverter.Domain;
using CurrencyConverter.Helpers;
using CurrencyConverter.Scenarios;

namespace CurrencyConverter
{
    class Program
    {
        static void Main()
        {
            var exchanger = new CurrencyExchanger();

            var currencyExchangeScenario = new CurrencyExchangeScenario(exchanger);
            var currencyCreationScenario = new CurrencyCreationScenario(exchanger);

            UIHelper.ShowAvailableCurrencies(exchanger.GetExchangeCurrenciesAsDictionary());
            UIHelper.ShowMainMenu();

            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey();
                
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Backspace:
                        UIHelper.ShowAvailableCurrencies(exchanger.GetExchangeCurrenciesAsDictionary());
                        UIHelper.ShowMainMenu();
                        break;

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        currencyExchangeScenario.Start();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        currencyCreationScenario.Start(); 
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Environment.Exit(0);
                        break;
                }
            } 
            while (keyInfo.Key != ConsoleKey.X);
        }
    }
}
