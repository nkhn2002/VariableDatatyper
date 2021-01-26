using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper.Classes
{
    class Pythagoras
    {
        public static double a;
        public static double b;

        private void Main()
        {
            Console.WriteLine("Pythagoras\n");

            Console.Write("\nTal 1: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Tal 2: ");
            b = double.Parse(Console.ReadLine());

            Resultat();

            if (a > b)
            {
                Console.WriteLine("Tal 1 har største værdi");
            }
            else if (a < b)
            {
                Console.WriteLine("Tal 2 har største værdi");
            }
            else if (a == b)
            {
                Console.WriteLine("Begge har samme værdi");
            }

            Console.ReadLine();
        }

        public static void Resultat()
        {
            double pythagoras = a * a + b * b;

            Console.WriteLine("\n" + Math.Sqrt(pythagoras) + "\n");
        }
    }
}
