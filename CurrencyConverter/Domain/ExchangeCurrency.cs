namespace CurrencyConverter.Domain
{
    public class ExchangeCurrency
    {
        public string CurrencyCode { get; set; }

        public decimal ExchangeRate { get; set; }

        public ExchangeCurrency(string currencyCode, decimal exchangeRate)
        {
            CurrencyCode = currencyCode;
            ExchangeRate = exchangeRate;
        }
    }
}
