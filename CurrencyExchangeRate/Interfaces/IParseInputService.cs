using CurrencyExchangeRate.Models;

namespace CurrencyExchangeRate.Interfaces
{
    public interface IParseInputService
    {
        UserCurrencyInput ParseInput(string userInput);
    }
}