using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.Services
{
    public class InputProcessingService
    {
        public Dictionary<string, string> exchangeRateCommandInput = new Dictionary<string, string>();

        private string[] SplitInput(string userInput)
        {
            if (userInput != null)
            {
                string[] userInputArray = userInput.Split(' ');
                return userInputArray;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        private void CommandInput(string[] userInputArray)
        {
            if (userInputArray.Length != 0)
            {
                string command = userInputArray.FirstOrDefault(i =>(i.ToLower()) == "exchange");
                if (command != null)
                {
                    this.exchangeRateCommandInput.Add("command", command);
                }
                else
                {
                    throw new ArgumentNullException("Ypu have not entered correct command to be performed");
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void CurrencyPairInput(string[] userInputArray)
        {
            if (userInputArray.Length != 0)
            {
                string currencyPair = userInputArray.FirstOrDefault(i => i.ToUpper().Contains("/"));
                if (currencyPair != null)
                {
                    this.exchangeRateCommandInput.Add("currency pair", currencyPair);
                }
                else
                {
                    throw new ArgumentNullException("Ypu have not entered correct currency pair");
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void AmountToExchangeInput(string[] userInputArray)
        {
            if (userInputArray.Length != 0)
            {
                string amount = userInputArray.FirstOrDefault(i => i.All(Char.IsDigit));
                if (amount != null)
                {
                    this.exchangeRateCommandInput.Add("amount", amount);
                }
                else
                {
                    throw new ArgumentNullException("Ypu have not entered correct amount");
                }

            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public Dictionary<string, string> GetKeyValuePairs(string userInput)
        {
           var userInputArray = this.SplitInput(userInput);
            this.CommandInput(userInputArray);
            this.CurrencyPairInput(userInputArray);
            this.AmountToExchangeInput(userInputArray);
            return exchangeRateCommandInput;
        }
    }
}
