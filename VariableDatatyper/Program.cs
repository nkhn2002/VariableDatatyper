using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            int a = 16;
            double b = 5.16;

            Console.WriteLine(a + b); // Outputter værdien 21.1

            // Opgave 2
            // int c = a + b; // Den vil ikke compile, fordi at den kan ikke convertere double (b variable) om til int. Det er en double, fordi der er et punktum og tal efter.

            // Opgave 3
            double d = a + b; // Den vil gerne compile nu, fordi at nu er datatypen en double værdi, da værdien er 21.1 (den har et punktum og tal efter)

            Console.ReadLine();
        }
    }
}
