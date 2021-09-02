using System;

using CurrencyConverter.Domain;

namespace CurrencyConverter.Scenarios
{
    public class CurrencyCreationScenario : BaseScenario
    {
        public CurrencyCreationScenario(CurrencyExchanger exchanger) 
            : base(exchanger) { }

        public void Start()
        {
            Console.Clear();

            try
            {
                Console.WriteLine("Enter currency Code");
                var enteredNewCurrencyCodeKeyInfo = Console.ReadLine();

                Console.WriteLine("Enter Exchange Rate");
                var enteredNewCurrencyExchangeRateKeyInfo = Console.ReadLine();
            
                var enteredNewCurrencyCode = enteredNewCurrencyCodeKeyInfo.ToString();
                var enteredNewCurrencyExchangeRate = decimal.Parse(enteredNewCurrencyExchangeRateKeyInfo.ToString());

                CurrencyExchanger.AddNewCurrency(enteredNewCurrencyCode, enteredNewCurrencyExchangeRate);

                Console.WriteLine("Press Backspace to back to the main menu");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}