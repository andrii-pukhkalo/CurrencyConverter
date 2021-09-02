using CurrencyConverter.Domain;

namespace CurrencyConverter.Scenarios
{
    public class BaseScenario
    {
        protected readonly CurrencyExchanger CurrencyExchanger;

        public BaseScenario(CurrencyExchanger currencyExchanger)
        {
            CurrencyExchanger = currencyExchanger;
        }
    }
}
