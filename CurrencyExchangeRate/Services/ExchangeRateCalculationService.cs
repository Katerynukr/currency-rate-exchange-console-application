using CurrencyExchangeRate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.Services
{
    public class ExchangeRateCalculationService
    {
        public decimal CalculateExchangeRate(UserCurrencyInput userInput)
        {
            var result = userInput.ExchangeCurrencyFrom.Amount / userInput.ExchangeCurrencyTo.Amount
                * userInput.Amount;

            return result;
        }
    }
}
