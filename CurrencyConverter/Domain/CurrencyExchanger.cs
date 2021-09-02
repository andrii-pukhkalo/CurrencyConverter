using System.Collections.Generic;
using System.Linq;

namespace CurrencyConverter.Domain
{
    public class CurrencyExchanger
    {
        public IReadOnlyList<ExchangeCurrency> ExchangeCurrencies => _exchangeCurrencies;

        private List<ExchangeCurrency> _exchangeCurrencies;
        
        public CurrencyExchanger()
        {
            _exchangeCurrencies = new List<ExchangeCurrency>()
            {
                new ExchangeCurrency("USD", (decimal)26.71),
                new ExchangeCurrency("EUR", (decimal)31.45),
            };
        }

        public Dictionary<string, decimal> GetExchangeCurrenciesAsDictionary()
        {
            return _exchangeCurrencies.ToDictionary(i => i.CurrencyCode, i => i.ExchangeRate);
        }

        public ExchangeCurrency GetCurrencyByIndex(int itemIndex)
        {
            return _exchangeCurrencies[itemIndex];
        }

        public decimal Convert(ExchangeCurrency sourceCurrency, ExchangeCurrency destinationCurrency, decimal sourceCurrencyAmount)
        {
            decimal crossCurrencyAmount = sourceCurrencyAmount * sourceCurrency.ExchangeRate;
            
            return crossCurrencyAmount / destinationCurrency.ExchangeRate;
        }

        public void AddNewCurrency(string enteredNewCurrencyCode, decimal enteredNewCurrencyRate)
        {
            _exchangeCurrencies.Add(new ExchangeCurrency(enteredNewCurrencyCode, enteredNewCurrencyRate));
        }
    }
}
