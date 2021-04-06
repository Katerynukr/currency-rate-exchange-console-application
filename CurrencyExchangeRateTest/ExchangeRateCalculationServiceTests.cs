using CurrencyExchangeRate.Models;
using CurrencyExchangeRate.Services;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CurrencyExchangeRateTest
{
    public class ExchangeRateCalculationServiceTests
    {
        [Theory]
        [InlineData("EUR", "DKK", 14.8788)]
        [InlineData("EUR", "EUR", 2)]
        [InlineData("CHF", "DKK", 13.6716)]
        [InlineData("SEK", "GBP", 0.22952451)]
        public void ExchangeRateCalculationService_GivenCurrencies_CalculateCorrectExchange(string currencyFrom, string currencyTo, int result)
        {
            //Arange
            var path = "C:\\Users\\kater\\Documents\\dot-net\\CurrencyExchangeRate\\CurrencyExchangeRate\\Data\\ExchangeRates.json";
            FetchData fetchData = new FetchData();
            var exchangeRates = fetchData.LoadJson(path);
            var currencyExchangeFrom = exchangeRates.Where(c => c.ISO == currencyFrom).FirstOrDefault();
            var currencyExchangeTo = exchangeRates.Where(c => c.ISO == currencyTo).FirstOrDefault();
            var amount = 2;
            var userInputObject = new UserCurrencyInput()
            {
                Amount = amount,
                ExchangeCurrencyFrom = currencyExchangeFrom,
                ExchangeCurrencyTo = currencyExchangeTo
            };

            //Act
            var rateCalculation = new ExchangeRateCalculationService();
            var rateResult = rateCalculation.CalculateExchangeRate(userInputObject);
            //Assert
            result.Should().Be(result);
        }
    }
}
