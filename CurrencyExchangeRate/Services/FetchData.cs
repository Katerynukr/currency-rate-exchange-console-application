using CurrencyExchangeRate.Interfaces;
using CurrencyExchangeRate.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.Services
{
    public class FetchData : IFetchData
    {
        public IEnumerable<ExchangeRate> LoadJson(string path)
        {
            if (path != null)
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    IEnumerable<ExchangeRate> rates = JsonConvert.DeserializeObject<IEnumerable<ExchangeRate>>(json);
                    return rates;
                }
            }
            else
            {
                throw new FileNotFoundException();
            }

        }
    }
}
