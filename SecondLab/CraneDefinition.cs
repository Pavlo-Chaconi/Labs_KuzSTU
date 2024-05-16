using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    public class CraneDefinition
    {
        static int nums_of_crane = 0;
        double max_lifting_height;
        double curent_height;
        double velocity_of_lifting_or_descent;
        double carrying;
        double cargo_weight;
        double deatchment_cargo_weight;

        public CraneDefinition()
        {
            nums_of_crane++;
            max_lifting_height = 100;
            curent_height = 50;
            velocity_of_lifting_or_descent = 15;
            carrying = 100;
            cargo_weight = 35;
        }

        public double location_determination(double location)
        {
            return curent_height;
        }

        public void raise_to_a_given_height(double given_height)
        {
            if (given_height > max_lifting_height)
            {
                Console.WriteLine("ОШИБКА! Превышена допустимая высота!");
                System.Threading.Thread.CurrentThread.Abort();
            }
            else curent_height = curent_height + given_height;

            if (curent_height > max_lifting_height)
            {
                Console.WriteLine("ОШИБКА! Превышена допустимая высота!");
                System.Threading.Thread.CurrentThread.Abort();
            }

        }

        public void cargo_attach(double weight_of_attachment_cargo)
        {
            if (weight_of_attachment_cargo > carrying)
            {
                Console.WriteLine("ОШИБКА! Превышен порог грузоподъемности!");
                System.Threading.Thread.CurrentThread.Abort();
            }
            else cargo_weight = cargo_weight + weight_of_attachment_cargo;

        }

        public void cargo_deattach(double weight_of_attachment_cargo)
        {
            cargo_weight = cargo_weight - weight_of_attachment_cargo;
            deatchment_cargo_weight = weight_of_attachment_cargo;
        }

        public double current_height_property
        {
            get { return curent_height; }
            set
            {
                if (value < 0)
                    curent_height = 0;
                else if (value > max_lifting_height)
                    curent_height = max_lifting_height;
                else
                    curent_height = value;
            }
        }


        public string CranePassport()
        {
            return string.Format("Характеристика подъемного крана:\n" + ":Номер крана - {0}\n:Максимальная высота подъема - {1}\n:Текущая высота подъема - {2}" +
                "\n:Текущая скорость подъема или спуска - {3}\n:Грузоподъемность - {4}\n:Вес груза - {5}" +
                "", nums_of_crane, max_lifting_height, curent_height, velocity_of_lifting_or_descent, carrying, cargo_weight);
        }

        public string MethodsPassport()
        {
            return string.Format("Местоположение крана:\n" + "– Номер {0}" +
                " \n– Поднятая высота : {1} м\n - Прицепил груз {2} кг\n - Отцепил груз: {3} \n",
                nums_of_crane, curent_height, cargo_weight, deatchment_cargo_weight);
        }



        public CraneDefinition(int max_carrying, double max_lifting_height, double velocity_of_lifing_or_descent)
        {
            nums_of_crane++;
            carrying = max_carrying;
            this.max_lifting_height = max_lifting_height;
            this.velocity_of_lifting_or_descent = velocity_of_lifing_or_descent;
        }
    }

}

