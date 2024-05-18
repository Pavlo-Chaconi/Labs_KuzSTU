using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public List<HotelsRoomDefinition> hotelrooms { get; private set; }


        public HotelClassDefinition()
        {
            Name = "Звездный путь";
            Adress = "Центральная, 19";
            stars_quantity = 5;
            Employees = new List<EmployeeClassDefinition>();
            hotelrooms = new List<HotelsRoomDefinition>();
            
        }

        public HotelClassDefinition(string name, string adress, int stars_quantity, List<EmployeeClassDefinition> employees, List<HotelsRoomDefinition> rooms)
        {
            this.Name = name;
            this.Adress = adress;
            this.stars_quantity = stars_quantity;
            this.Employees = employees;
            this.hotelrooms = rooms;
        }

        public string HotelInforamtion()
        {
            string roomsInformation = "";
            foreach(HotelsRoomDefinition room_temp in hotelrooms)
            {
                roomsInformation += "\n" + room_temp.roomId;
            }
            return string.Format("Название - {0} \nАдресс - {1} \nКоличество звёзд - {2} \nНомера комнат: {3}", Name, Adress, stars_quantity, roomsInformation );
        }

        public void EmployeeAdder()
        {
            Console.WriteLine("Введите добавляемую должность:");
            string job_title = Console.ReadLine();
            Console.WriteLine("Введите заработную плату:");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО добавляемого сотрудника:");
            string full_name = Console.ReadLine();
            Console.WriteLine("Введите пол сотрудника:");
            string gender = Console.ReadLine();
            Console.WriteLine("Введите дату рождения сотрудника в формате: год, месяц, день ");
            DateTime Birthday = Convert.ToDateTime(Console.ReadLine());
            EmployeeClassDefinition emloyee_adder = new EmployeeClassDefinition(job_title, salary, full_name, gender, Birthday);
            Employees.Add(emloyee_adder);
            Console.WriteLine("Добавление сотрудника завершено!");
        }

        public void ShowEmployee()
        {
            foreach(EmployeeClassDefinition employee in Employees)
            {
                Console.WriteLine(employee.EmployeeInformation());
            }
        }

        public void EmployeeRemover(int EmployeeIndex)
        {
            if (EmployeeIndex >= 0 && EmployeeIndex < Employees.Count) Employees.RemoveAt(EmployeeIndex);
        }
    }
}
