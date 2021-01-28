using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper.Classes
{
    class Array_og_Matematik
    {
        private void Main()
        {
            int[] listeB = new int[20];

            for(int i = 1; i < 20; i++)
            {
                listeB[i] = i;
                Console.Write(i + " ");
            }
        }
    }
}
