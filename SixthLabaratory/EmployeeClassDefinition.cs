using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLabaratory
{
    public class EmployeeClassDefinition : HumanClassDefinition
    {
        public string job_title;
        double salary;

        public EmployeeClassDefinition(): base()
        {
            job_title = "Управляющий";
            salary = 100000;
        }

        public EmployeeClassDefinition(string job_title, double salary, string full_name, string gender, DateTime date_of_birth) : base(full_name, gender, date_of_birth)
        {
            this.job_title = job_title;
            this.salary = salary;
        }

        public string EmployeeInformation()
        {
            return string.Format("Имя Фамилия Отчество работника: {0}\n"
                + "Пол {1}\n"
                + "Дата рождения {2}\n"
                + "Должность: {3}\n"
                + "Зарплата: {4}\n", full_name, gender, date_of_birth, job_title, salary);
        }
    }
}
