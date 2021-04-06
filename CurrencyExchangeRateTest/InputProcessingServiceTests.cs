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
    public class InputProcessingServiceTests
    {
        [Fact]
        public void GetKeyValuePairs_GivenUserInputString_ArrangeInDictionary()
        {
            //Arrange
            var input = " Exchange USD/EUR 5 ";
            var processingData = new InputProcessingService();
            //Act
            var result = processingData.GetKeyValuePairs(input);
            //Assert
            result.Count.Should().Be(3);
            result["currency pair"].Should().NotBeNullOrEmpty();
            result["command"].Should().NotBeNullOrEmpty();
            //why
            //result["amount"].Should().NotBeNullOrEmpty();
        }
    }
}
