using CurrencyExchangeRate.Interfaces;
using CurrencyExchangeRate.Loggers;
using CurrencyExchangeRate.Services;
using System;

namespace CurrencyExchangeRate
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "C:\\Users\\kater\\Documents\\dot-net\\CurrencyExchangeRate\\CurrencyExchangeRate\\Data\\ExchangeRates.json";
            ILogger logger = new ConsoleLogger();
            DisplayMessageService displayMessageService = new DisplayMessageService(logger);
            displayMessageService.WriteCommand("Usage: Exchange <currency pair> <amount to exchange>");
            var userResponse = displayMessageService.ReadCommand();
            FetchData fetchData = new FetchData();
            var exchangeRates = fetchData.LoadJson(path);
            InputProcessingService inputProcessingService = new InputProcessingService();
            ParseInputService parseInput = new ParseInputService(inputProcessingService, exchangeRates);
            var userCurrencyInputObject = parseInput.ParseInput(userResponse);
            ExchangeRateCalculationService exchangeRateCalculationService = new ExchangeRateCalculationService();
            var result = exchangeRateCalculationService.CalculateExchangeRate(userCurrencyInputObject);
            displayMessageService.WriteCommand($"The result is {result}");
            displayMessageService.ReadCommand();
        }
    }
}
