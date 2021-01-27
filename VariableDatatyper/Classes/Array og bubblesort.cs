using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper.Classes
{
    class Array_og_bubblesort
    {
        private void Main()
        {
            int[] tal = new int[100];

            Random r = new Random();

            for (int i = 0; i < tal.Length; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 1000);

                tal[i] = randomNumber;

                for (int j = 0; j < (tal.Length - 1) - i; j++)
                {
                    if (tal[j] > tal[j + 1])
                    {
                        int temp = tal[j + 1];
                        tal[j + 1] = tal[j];
                        tal[j] = temp;
                    }
                }

            }
        }
    }
}
