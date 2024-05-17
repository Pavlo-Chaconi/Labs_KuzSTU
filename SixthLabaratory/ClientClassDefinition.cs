using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLabaratory
{
    public class ClientClassDefinition : HumanClassDefinition
    {
        public string ClientPassportInfo;
        DateTime check_in_date;
        DateTime check_out_date;
        double number_of_days_of_stay;
        public HotelsRoomDefinition room;



        public ClientClassDefinition() : base() { ClientPassportInfo = "3216715318";
            check_in_date = new DateTime(2024, 5, 10);
            check_out_date = new DateTime(2024, 5, 15);
            number_of_days_of_stay = (check_out_date - check_in_date).TotalDays; }

        public ClientClassDefinition(string clientPassportInfo, DateTime check_in_date, DateTime check_out_date, double number_of_days_of_stay, string full_name, string gender, DateTime date_of_birth, HotelsRoomDefinition room) : base(full_name, gender, date_of_birth)
        {
            ClientPassportInfo = clientPassportInfo;
            this.check_in_date = check_in_date;
            this.check_out_date = check_out_date;
            this.number_of_days_of_stay = number_of_days_of_stay;
            this.room = room;
        }

        public string ClientInformation()
        {
            return string.Format("Имя Фамилия Отчество клиента: {0}\n"
                + "Пол {1}\n"
                + "Дата рождения {2}\n"
                + "Номер пасспорта клиента: {3}\n"
                + "Дата заселения: {4}\n"
                + "Дата выселения: {5}\n"
                + "Общее количество проведенных дней: {6}\n", full_name, gender, date_of_birth, ClientPassportInfo, check_in_date, check_out_date, number_of_days_of_stay);
        }
    }
}
