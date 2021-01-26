using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VariableDatatyper.Classes
{
    class GætEtTal
    {
        private void Main()
        {
            int gange = 0;

            Random rdm = new Random();
            int tal = rdm.Next(1, 101);

            bool loop = true;

            while (loop)
            {
                Console.Clear();

                Console.WriteLine("Gæt tallet mellem 1-100\nTast '0' for at stoppe");

                Console.WriteLine($"\nAntal gange prøvet: {gange}");

                Console.Write("\nTal: ");
                try
                {
                    int userGuess = int.Parse(Console.ReadLine());

                    if (userGuess == 0)
                    {
                        loop = false;
                    }

                    if (userGuess < tal)
                    {
                        Console.WriteLine("\nVarmere, prøv igen!");
                        Thread.Sleep(500);
                        gange++;
                        continue;
                    }
                    else if (userGuess > tal)
                    {
                        Console.WriteLine("\nKoldere, prøv igen!");
                        Thread.Sleep(500);
                        gange++;
                        continue;
                    }
                    else if (userGuess == tal)
                    {
                        Console.WriteLine($"\nTillykke! Du fandt det hemmelige tal: {tal} - efter {gange} forsøg.");
                        Console.ReadLine();
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("\nFejl! Der må kun være tal");
                    Thread.Sleep(1000);
                    continue;
                }
            }
        }
    }
}
