using CurrencyExchangeRate.Models;

namespace CurrencyExchangeRate.Interfaces
{
    public interface IExchangeRateCalculationService
    {
        decimal CalculateExchangeRate(UserCurrencyInput userInput);
    }
}