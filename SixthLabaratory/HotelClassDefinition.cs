using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLabaratory
{
    public class HotelClassDefinition
    {
        string Name;
        string Adress;
        int stars_quantity;
        public List<EmployeeClassDefinition> Employees;
        public List<HotelsRoomDefinition> hotelrooms { get; set; }


        public HotelClassDefinition()
        {
            Name = "Звездный путь";
            Adress = "Центральная, 19";
            stars_quantity = 5;
            Employees = new List<EmployeeClassDefinition>();
            hotelrooms = new List<HotelsRoomDefinition>();
        }

        public HotelClassDefinition(string name, string adress, int stars_quantity, List<EmployeeClassDefinition> employees, List<HotelsRoomDefinition> hotelsRooms)
        {
            this.Name = name;
            this.Adress = adress;
            this.stars_quantity = stars_quantity;
            this.Employees = employees;
            hotelrooms = hotelrooms;
        }

        public string HotelInforamtion()
        {
            string roomsInformation = "";
            foreach(HotelsRoomDefinition room_temp in hotelrooms)
            {
                roomsInformation += "\n" + room_temp.roomId;
            }
            return string.Format("Название - {0} \nАдресс - {1} \nКоличество звёзд - {2} \nНомера комнат: {3}", Name, Adress, stars_quantity, roomsInformation);
        }
    }
}
