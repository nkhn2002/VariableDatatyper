using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper.Classes
{
    class Alder
    {
        private void Main()
        {
            Console.Write("Indtast dit navn: "); // Skaffer navnet fra user input
            string navn = Console.ReadLine();

            Console.Write("Indtast din alder: "); // Skaffer alderen fra user input
            int alder = int.Parse(Console.ReadLine());

            if (alder < 3)
            {
                Console.WriteLine($"\n{navn}, du må gå med ble");
            }
            else if (alder > 3 && alder <= 15)
            {
                Console.WriteLine($"\n{navn}, du må ingenting");
            }
            else if (alder > 15 && alder < 18)
            {
                Console.WriteLine($"\n{navn}, du må drikke");
            }
            else if (alder == 18 || alder > 18)
            {
                Console.WriteLine($"\n{navn}, du må stemme og køre bil");
            }

            Console.ReadLine();
        }
    }
}
