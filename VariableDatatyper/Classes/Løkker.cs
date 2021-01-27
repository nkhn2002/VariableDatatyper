using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper.Classes
{
    class Løkker
    {
        private void Main()
        {
            // Opgave A:
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine(" ");

            // Opgave B:
            for (int i = 0; i < 100; i++)
            {
                if (i < 51)
                {
                    Console.WriteLine($"{i}");
                }
            }

            Console.WriteLine(" ");

            // Opgave C:
            int i2 = 0;

            while (i2 < 100)
            {
                i2++;
                Console.WriteLine($"{i2}");
            }

            Console.WriteLine(" ");

            // Opgave D:
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine($"{i}");
            }

            Console.ReadLine();
        }
    }
}
