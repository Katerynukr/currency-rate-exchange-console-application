using CurrencyExchangeRate.Models;
using System.Collections.Generic;

namespace CurrencyExchangeRate.Interfaces
{
    public interface IFetchData
    {
        IEnumerable<ExchangeRate> LoadJson(string path);
    }
}