using CurrencyExchangeRate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.Services
{
    public class DisplayMessageService : IDisplayMessageService
    {
        private ILogger _logger;

        public DisplayMessageService(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteCommand(string input)
        {
            _logger.Write(input);
        }

        public string ReadCommand()
        {
            string input = _logger.Read();
            return input;
        }
    }
}
