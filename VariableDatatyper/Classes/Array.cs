using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper.Classes
{
    class Array
    {
        private void Main()
        {
            Console.Clear();

            int[] tal = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int line in tal)
            {
                if (tal[5] == line)
                {
                    Console.WriteLine(line);

                    tal[5] = tal[4] + tal[4];
                }
            }
        }
    }
}
