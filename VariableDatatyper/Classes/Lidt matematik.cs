using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper.Classes
{
    class Lidt_matematik
    {
        private void Main()
        {
            Console.Write("Tal 1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal 2:");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine(tal1 + tal2);

            Console.WriteLine(tal1 / tal2);

            Console.WriteLine(tal1 ^ tal2);
        }
    }
}
