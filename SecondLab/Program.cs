using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    class Program
    {
        static void Main(string[] args)
        {
            CraneDefinition craneDefinition_program_class = new CraneDefinition();
            Console.WriteLine(craneDefinition_program_class.CranePassport() + "\n");
            CraneDefinition craneDefinition_program_class_another_crane = new CraneDefinition(100, 500, 150);
            Console.WriteLine(craneDefinition_program_class_another_crane.CranePassport() + "\n");
            //craneDefinition_program_class_another_crane.location_determination(1);
            //craneDefinition_program_class_another_crane.raise_to_a_given_height(300);
            //craneDefinition_program_class_another_crane.cargo_attach(50);
            //Console.WriteLine(craneDefinition_program_class_another_crane.MethodsPassport() + "\n");
            //craneDefinition_program_class_another_crane.raise_to_a_given_height(150);
            //craneDefinition_program_class_another_crane.cargo_deattach(50);
            //Console.WriteLine(craneDefinition_program_class_another_crane.MethodsPassport() + "\n");
            craneDefinition_program_class_another_crane.current_height_property = 600;
            Console.WriteLine("Измененная высота {0} \n", craneDefinition_program_class_another_crane.current_height_property);

            Console.Read();
        }
    }
}
