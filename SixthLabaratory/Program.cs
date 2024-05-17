using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixthLabaratory;

namespace SixthLabaratory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelsRoomDefinition roomDefinition = new HotelsRoomDefinition();
            HotelClassDefinition hotelDefinition = new HotelClassDefinition();
            for (; ; )

            {

                switch (Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine(hotelDefinition.HotelInforamtion()); // показ информации о отеле
                        break;
                    case "7":
                        roomDefinition.AddClientToRoom(); // добавить клиента
                        break;

                    case "9":
                        Environment.Exit(0); // выход из приложения
                        break;
                    default:
                        Console.WriteLine("Такой команды не существует ");
                        ; break;
                }
            }
        }
    }
}
