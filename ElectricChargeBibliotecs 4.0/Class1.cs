using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricChargeBibliotecs
{
    public struct ElectricalCharge
    {
        double charge_value;
        int coordinate_x;
        int coordinate_y;

        public ElectricalCharge(double charge, int x, int y)
        {
            charge_value = charge;
            coordinate_x = x;
            coordinate_y = y;
        }

        public double force_interactions_of_charges(int x, int y)
        {
            double distance_between_charges = Math.Sqrt(Math.Pow(coordinate_x - x, 2) + Math.Pow(coordinate_y - y, 2));
            double culon_const = 9 * Math.Pow(10, 9);
            return culon_const * charge_value / Math.Pow(distance_between_charges, 2);
        }

        public double distance_between_of_charges(int x, int y)
        {
            return Math.Sqrt(Math.Pow((coordinate_x - x), 2) + Math.Pow(coordinate_y - y, 2));
        }

        public string information_about_charges()
        {
            return string.Format("Информация о заряде: \n" + "Сила заряда: {0} \n" + "Координата X: {1}\n" + "Координата Y: {2}\n", charge_value, coordinate_x, coordinate_y);
        }

        public static bool operator ==(ElectricalCharge obj1, ElectricalCharge obj2)
        {
            if ((obj1.charge_value == obj2.charge_value) && (obj1.coordinate_x == obj2.coordinate_x) && (obj1.coordinate_y == obj2.coordinate_y))
                return true;
            return false;
        }

        public static bool operator !=(ElectricalCharge obj1, ElectricalCharge obj2)
        {
            if ((obj1.charge_value != obj2.charge_value) && (obj1.coordinate_x != obj2.coordinate_x) && (obj1.coordinate_y != obj2.coordinate_y))
                return true;
            return false;
        }

    }
}
