using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLabaratory
{
    public class HotelsRoomDefinition
    {
        public int roomId { get; set; }
        public string roomType { get; private set; }
        public int roomcapacity { get; private set; }
        public List<ClientClassDefinition> clients;
        public List<HotelsRoomDefinition> rooms { get; private set; }
        int clients_counter;
        int roomCount;

        public HotelsRoomDefinition()
        {
            roomId = 1;
            roomcapacity = 3;
            roomType = "Люкс";
            clients = new List<ClientClassDefinition>();
            rooms = new List<HotelsRoomDefinition>();
        }

        public HotelsRoomDefinition(int roomId, string roomType, int roomcapacity)
        {
            this.roomId = roomId;
            this.roomType = roomType;
            this.roomcapacity = roomcapacity;
            clients = new List<ClientClassDefinition>();
        }

        public void InitializeRooms(int numberOfRooms)
        {
            Random random = new Random();
            for (int i = 1; i <= numberOfRooms; i++)
            {
                HotelsRoomDefinition newRoom = new HotelsRoomDefinition(
                    roomId: i,
                    roomType: i % 2 == 0 ? "Вип" : "Обыкновенная",
                    roomcapacity: 3
                    );
                rooms.Add(newRoom);
            }
        }

        public string ClientRoomInfo()
        {
            string client_room_info = "";
            foreach(ClientClassDefinition c in clients)
            {
                if (c.room == this)
                {
                    client_room_info = client_room_info + c.full_name + " , ";
                }
            }return string.Format("Номер: {0}\n" + "Вместимость {1}\n" + "Вид номера{2}\n" + "Список постояльцев\n", roomId, roomcapacity, roomType, client_room_info);
        }

        public void AddClientToRoom()
        {
            Console.WriteLine("Введите номер комнаты");
            string room_num_temp = Console.ReadLine();
            HotelsRoomDefinition current_room = null;
            if(int.TryParse(room_num_temp, out int roomNumber))
            {
                HotelsRoomDefinition room_finder_temp = rooms.Find(room => room.roomId == roomNumber);
                if (room_finder_temp != null)
                {
                    Console.WriteLine($"Комната найдена! Номер комнаты = {room_finder_temp.roomId}, Тип комнаты = {room_finder_temp.roomType}");
                    current_room = room_finder_temp;
                }
                else
                {
                    Console.WriteLine("Комнаты не найдено!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
                return;
            }
            Console.WriteLine("Введите паспортные данные");
            string Pass_Info_Temp = Console.ReadLine();
            Console.WriteLine("Введите дату заселения в формате: год, месяц, день ");
            DateTime date_of_check_in_temp = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите дату выселения в формате: год, месяц, день ");
            DateTime date_of_check_out_temp = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите ФИО клиента ");
            string Full_name_temp = Console.ReadLine();
            Console.WriteLine("Введите пол клиента ");
            string Gender_temp = Console.ReadLine();
            Console.WriteLine("Введите дату рождения клиента в формате: год, месяц, день ");
            DateTime Birthdate_temp = Convert.ToDateTime(Console.ReadLine());
            ClientClassDefinition client_registration = new ClientClassDefinition(Pass_Info_Temp, date_of_check_in_temp, date_of_check_out_temp,0,Full_name_temp,Gender_temp,Birthdate_temp,current_room);
            Console.WriteLine("Информация о клиенте создана и добавлена в базу. \n" + $"Клиент заселен в комнату {current_room.roomId}");
        }

        public void ClientRemoveFromRoom()
        {
            Console.WriteLine("Введите номер комнаты");
            string room_num_temp = Console.ReadLine();
            HotelsRoomDefinition current_room = null;
            if (int.TryParse(room_num_temp, out int roomNumber))
            {
                HotelsRoomDefinition room_finder_temp = rooms.Find(room => room.roomId == roomNumber);
                if (room_finder_temp != null)
                {
                    Console.WriteLine($"Комната найдена! Номер комнаты = {room_finder_temp.roomId}, Тип комнаты = {room_finder_temp.roomType}");
                    current_room = room_finder_temp;
                }
                else
                {
                    Console.WriteLine("Комнаты не найдено!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
                return;
            }
            if (current_room.clients.Count == 0)
            {
                Console.WriteLine($"В комнате {room_num_temp} нет клиентов!");
                return;
            }
            Console.WriteLine("Введите номер клиента для удаления");
            int client_ind = Convert.ToInt32(Console.ReadLine());
            if (client_ind < 0 || client_ind >= current_room.clients.Count)
            {
                Console.WriteLine($"Клиент с номером {client_ind} не найден!");
                return;
            }
            ClientClassDefinition removed_client = current_room.clients[client_ind];
            current_room.clients.RemoveAt(client_ind);
            current_room.roomcapacity--;

            Console.WriteLine($"Клиент {removed_client.full_name} удален из комнаты {current_room.roomId}");
        }
    }
}
