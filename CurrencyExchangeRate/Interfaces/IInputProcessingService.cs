using System.Collections.Generic;

namespace CurrencyExchangeRate.Interfaces
{
    public interface IInputProcessingService
    {
        Dictionary<string, string> GetKeyValuePairs(string userInput);
    }
}