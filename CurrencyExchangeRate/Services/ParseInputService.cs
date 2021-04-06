using CurrencyExchangeRate.Interfaces;
using CurrencyExchangeRate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.Services
{
    public class ParseInputService : IParseInputService
    {
        private readonly InputProcessingService _inputProcessingService;
        private readonly IEnumerable<ExchangeRate> _exchangeRates;

        public ParseInputService(InputProcessingService inputProcessingService, IEnumerable<ExchangeRate> exchangeRates)
        {
            _inputProcessingService = inputProcessingService;
            _exchangeRates = exchangeRates;
        }

        public UserCurrencyInput ParseInput(string userInput)
        {
            var inputData = _inputProcessingService.GetKeyValuePairs(userInput);
            var amount = Int32.Parse(inputData["amount"]);
            var currencies = inputData["currency pair"].Split("/");
            var currencyExchangeFrom = _exchangeRates.Where(c => c.ISO == currencies[0]).FirstOrDefault();
            var currencyExchangeTo = _exchangeRates.Where(c => c.ISO == currencies[1]).FirstOrDefault();

            return new UserCurrencyInput()
            {
                ExchangeCurrencyFrom = currencyExchangeFrom,
                ExchangeCurrencyTo = currencyExchangeTo,
                Amount = amount
            };
        }
    }
}

