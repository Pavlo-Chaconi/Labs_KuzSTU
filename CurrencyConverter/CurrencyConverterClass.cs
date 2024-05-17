using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyConverter;

namespace CurrencyConverter
{
    public static class CurrencyConverterClass
    {
        public const double USD_RUB = 61.87;
        public const double EUR_USD = 70.44;
        public const double CNY_RUB = 9.89;
        public static double response;

        public static double convertRUBtoUSD(double RUB)
        {
            return response = RUB / USD_RUB;
        }

        public static double convertUSDtoEUR(double USD)
        {
            return response = (USD_RUB / USD) * EUR_USD;
        }

        public static double convertCNYtoRUB(double CNY)
        {
            return response = CNY * CNY_RUB;
        }

        public static string information_about_converter_course()
        {
            return string.Format("Курсы валют по состоянию на 12.05.2024 \n" + "1 USD/RUB {0} \n" + "2 EUR/USD {1} \n" + "3 CNY/RUB {2} \n", USD_RUB, EUR_USD, CNY_RUB);
        }
    }
}
