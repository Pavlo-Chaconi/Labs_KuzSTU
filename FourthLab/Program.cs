using ElectricChargeBibliotecs;
using System;
namespace FourthLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectricalCharge first_charge = new ElectricalCharge(10, 15, 20);
            ElectricalCharge second_charge = new ElectricalCharge(20, 15, 30);

            do
            {
                Console.WriteLine("Для того чтобы узнать расстояние между зарядами введите 1\n" + "Для того чтобу узнать силу электростатического заряда введите 2\n" +
                "Для того чтобы узнать информацию о первом заряде введите 3\n" + "Для того чтобы узнать равны ли два заряда введите 4\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Введите значение координаты X второго заряда\n");
                        string x_input_distance_temp = Console.ReadLine();
                        Console.WriteLine("Введите значение координаты Y второго заряда\n");
                        string y_input_distance_temp = Console.ReadLine();
                        double distace_Calculation = first_charge.distance_between_of_charges(Convert.ToInt32(x_input_distance_temp), Convert.ToInt32(y_input_distance_temp));
                        Console.WriteLine("Расстояние между двумя зарядами равняется {0}", distace_Calculation);
                        break;
                    case "2":
                        Console.WriteLine("Введите значение координаты X второго заряда\n");
                        string x_input_force_temp = Console.ReadLine();
                        Console.WriteLine("Введите значение координаты Y второго заряда\n");
                        string y_input_force_temp = Console.ReadLine();
                        double force_calculation = first_charge.force_interactions_of_charges(Convert.ToInt32(x_input_force_temp), Convert.ToInt32(y_input_force_temp));
                        Console.WriteLine("Значение силы взаимодействия двух зарядов: {0}\n", force_calculation);
                        break;
                    case "3":
                        Console.WriteLine("{0}\n", first_charge.information_about_charges());
                        break;
                    case "4":
                        if (first_charge == second_charge)
                            Console.WriteLine("Заряды равны!");
                        else
                            Console.WriteLine("Заряды не равны!");
                        break; 
                }
            }
            while (true); 
        }
    }
}
