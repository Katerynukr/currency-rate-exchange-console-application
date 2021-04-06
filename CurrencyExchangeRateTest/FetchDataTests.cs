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
    public class FetchDataTests
    {
        [Fact]
        public void LoadJson_GivePathToJSONFile()
        {
            // Arange
            var path = "C:\\Users\\kater\\Documents\\dot-net\\CurrencyExchangeRate\\CurrencyExchangeRate\\Data\\ExchangeRates.json";
            FetchData fetchData = new FetchData();
            //Act
            var result = fetchData.LoadJson(path);
            //Assert
            result.Should().NotBeEmpty();
        }
    }
}
