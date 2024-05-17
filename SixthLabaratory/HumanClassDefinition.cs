using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLabaratory
{
    public class HumanClassDefinition
    {
        public string full_name;
        public string gender;
        public DateTime date_of_birth;

        public HumanClassDefinition()
        {
            full_name = "Кулеш Сергей Алексеевич";
            gender = "Мужской";
            date_of_birth = new  DateTime(2001, 27, 01);
        }

        public HumanClassDefinition(string full_name, string gender, DateTime date_of_birth)
        {
            this.full_name = full_name;
            this.gender = gender;
            this.date_of_birth = date_of_birth;
        }
    }
}
