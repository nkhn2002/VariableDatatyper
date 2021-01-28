using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper
{
    class Array_og_Matematik
    {
        public static int temp { get; set; }
        private void Main()
        {
            // Vores listeB
            int[] listeB = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            for (int i = 0; i < listeB.Length; i++)
            {
                temp++;

                if (temp == 3)
                {
                    listeB = listeB.Where(w => w != listeB[i]).ToArray();
                    temp = 1;
                }
            }

            // Erstat plads nr 3 med værdien 17
            listeB[2] = 17;

            // Ny liste
            int[] listeA = new int[15];

            // Kopier listeB til listeA
            listeB.CopyTo(listeA, 1);

            // Fjern et ekstra array som bliver tilføjet (Er ikke sikker på hvorfor den er der)
            listeA = listeA.Where(w => w != listeA[0]).ToArray();

            // Gør rækkefølgen omvendt end listeB
            Array.Reverse(listeA);

            // Output listerne
            Console.Write("Liste B: ");
            foreach (int a in listeB)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine("");

            Console.Write("Liste A: ");
            foreach (int a in listeA)
            {
                Console.Write(a + " ");
            }
        }
    }
}
