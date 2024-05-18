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
            HotelsRoomDefinition first_room = new HotelsRoomDefinition(1, "ВИП", 3);
            hotelDefinition = new HotelClassDefinition("Миртора", "Центральная", 5, new List<EmployeeClassDefinition>(), new List<HotelsRoomDefinition>());
            Console.WriteLine("Панель управления отелем. ver. 1.0 \n" + "Добро пожаловать!");
            HumanClassDefinition humanprogramm = new HumanClassDefinition("Кутищев Павел Дмитриевич", "М", new DateTime(2002, 09, 30));
            humanprogramm = new HumanClassDefinition("Поварич Богдан Олегович", "М", new DateTime(2002, 09, 30));
            EmployeeClassDefinition employeeprogramm = new EmployeeClassDefinition("Директор", 100000, "Кутищев Павел Дмитриевич", "М", new DateTime(2002, 09, 30));
            ClientClassDefinition clientprogramm = new ClientClassDefinition();
            clientprogramm = new ClientClassDefinition("12312312", new DateTime(2024, 12, 11), new DateTime(2024, 12, 25), 0, "Поварич Богдан Олегович", "М", new DateTime(2002, 09, 30), roomDefinition);
            hotelDefinition.Employees.Add(employeeprogramm);
            roomDefinition.clients.Add(clientprogramm);
            roomDefinition.rooms.Add(first_room);
            roomDefinition.InitializeRooms(21);
            for (; ; )

            {
                Console.WriteLine("Команды:\n 0 - информация об отеле \n 1 - показ информации о номере 1 \n 2 - показ информации о номере 2 \n 3 - показ информации о всех работниках \n 4 - Добавить работника \n 5 - Удалить сотрудника по индексу \n 6 - Добавить клиента \n 7 - Удалить клиента по индексу " +
                    "\n 8 - Вывод всех комнат \n 9 - Вывод информации о постояльцах \n 10 - Выход из программы");
                    switch (Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine(hotelDefinition.HotelInforamtion()); 
                        break;
                    case "1":
                        Console.WriteLine(first_room.ClientRoomInfo()); 
                        break;
                    case "2":
                        Console.WriteLine(first_room.ClientRoomInfo()); 
                        break;
                    case "3":
                        hotelDefinition.ShowEmployee();
                        break;
                    case "4":
                        hotelDefinition.EmployeeAdder(); 
                        break;
                    case "5":
                        hotelDefinition.EmployeeRemover(Convert.ToInt32(Console.ReadLine())); 
                        break;
                    case "6":
                        roomDefinition.AddClientToRoom();
                        break;
                    case "7":
                        roomDefinition.ClientRemoveFromRoom(); 
                        break;
                    case "8":
                        foreach (var room in roomDefinition.rooms)
                        {
                            Console.WriteLine($"Номер комнаты: {room.roomId}, Тип комнаты: {room.roomType}, Вместимость: {room.roomcapacity}");
                        }
                        break;
                    case "9":
                        Console.WriteLine(clientprogramm.ClientInformation()); 
                        break;
                    case "10":
                        Environment.Exit(0); 
                        break;
                    default:
                        Console.WriteLine("Такой команды не существует ");
                        ; break;
                }
            }
        }
    }
}
