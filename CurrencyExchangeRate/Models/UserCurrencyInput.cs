using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.Models
{
    public class UserCurrencyInput
    {
        public ExchangeRate ExchangeCurrencyFrom { get; set; }
        public ExchangeRate ExchangeCurrencyTo { get; set; }
        public int Amount { get; set; }
    }
}
