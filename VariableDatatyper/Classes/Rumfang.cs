using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper.Classes
{
    class Rumfang
    {
        private void Main()
        {
            Console.WriteLine("Rumfangomregner\n");

            try
            {
                // Vi parser vi 3 double værdier ved input vi laver i konsollen.
                Console.Write("Længde: ");
                double L = double.Parse(Console.ReadLine());
                Console.Write("Højde: ");
                double H = double.Parse(Console.ReadLine());
                Console.Write("Bredde: ");
                double B = double.Parse(Console.ReadLine());

                // Her outputter vi den resulteret Rumfang. 
                Console.WriteLine($"\nRumfang: {L * H * B}");

            }
            catch
            {
                Console.WriteLine("\nDer skete en fejl, husk at det skal være double værdier!");
            };

            Console.ReadLine();
        }
    }
}
