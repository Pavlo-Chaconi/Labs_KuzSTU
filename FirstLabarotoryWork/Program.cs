using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabarotoryWork
{
    class Program
    {
        static void Main(string[] args)
        {
            CraneDefinition craneDefinition_program_class = new CraneDefinition();
            Console.WriteLine(craneDefinition_program_class.CranePassport() + "\n");
            CraneDefinition craneDefinition_program_class_another_crane = new CraneDefinition(100, 200, 150);
            Console.WriteLine(craneDefinition_program_class_another_crane.CranePassport() + "\n");
            Console.Read();
            ewde
        }
    }
}
