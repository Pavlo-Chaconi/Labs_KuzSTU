using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyConverter;

namespace ThirdLabaratoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Для конвертации рублей в доллары нажмите 1 \n" + 
                    "Для конвертации долларов в евро нажмите 2 \n" + 
                    "Для конвертации юаней в рубли нажмите 3 \n" + "Для вывода информации о курсах обмена нажмите 4 \n");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Введите сумму для ковертации в доллары");
                        double RUBStoUSD = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Конвертировано {0} рублей в {1} долларов", RUBStoUSD, CurrencyConverterClass.convertRUBtoUSD(RUBStoUSD));
                        break;

                    case "2":
                        Console.WriteLine("Введите сумму для ковертации в евро");
                        double USDtoEUR = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Конвертировано {0} долларов в {1} евро", USDtoEUR, CurrencyConverterClass.convertUSDtoEUR(USDtoEUR));
                        break;
                    case "3":
                        Console.WriteLine("Введите сумму для ковертации в рубли");
                        double CNYtoRUB = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Конвертировано {0} юаней в {1} рубли", CNYtoRUB, CurrencyConverterClass.convertCNYtoRUB(CNYtoRUB));
                        break;
                    case "4":
                        Console.WriteLine(CurrencyConverterClass.information_about_converter_course());
                        break;

                }
            }
            while (true);

        }
    }
}
