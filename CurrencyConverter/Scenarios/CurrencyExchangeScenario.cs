using CurrencyConverter.Domain;
using CurrencyConverter.Helpers;
using System;

namespace CurrencyConverter.Scenarios
{
    public class CurrencyExchangeScenario : BaseScenario
    {
        public CurrencyExchangeScenario(CurrencyExchanger currencyExchanger) 
            : base(currencyExchanger) { }

        public void Start()
        {
            Console.Clear();

            try
            {
                /// Ensure source Currency selection

                UIHelper.ShowOrderedCurrenciesToSelect(CurrencyExchanger.GetExchangeCurrenciesAsDictionary(), "source");

                var sourceCurrencyIndex = UIHelper.GetSelectedItemIndex();

                var sourceCurrency = CurrencyExchanger.GetCurrencyByIndex(sourceCurrencyIndex);

                UIHelper.ShowSelectedCurrencyToExchange("Source", sourceCurrency.CurrencyCode, sourceCurrency.ExchangeRate);

                /// Ensure destination Currency selection

                UIHelper.ShowOrderedCurrenciesToSelect(CurrencyExchanger.GetExchangeCurrenciesAsDictionary(), "destination");

                var destinationCurrencyIndex = UIHelper.GetSelectedItemIndex();

                var destinationCurrency = CurrencyExchanger.GetCurrencyByIndex(destinationCurrencyIndex);

                UIHelper.ShowSelectedCurrencyToExchange("Destination", destinationCurrency.CurrencyCode, destinationCurrency.ExchangeRate);

                /// Enter source currency Amount

                decimal sourceCurrencyAmount = UIHelper.GetEnteredSourceCurrencyAmount();

                /// Convert

                var destinationCurrencyAmount = CurrencyExchanger.Convert(sourceCurrency, destinationCurrency, sourceCurrencyAmount);

                /// Display result

                UIHelper.DisplayConvertaionResult(destinationCurrency.CurrencyCode, destinationCurrencyAmount);

                UIHelper.DisplayGoBackMessage();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                UIHelper.DisplayGoBackMessage();
            }
        }
    }
}
