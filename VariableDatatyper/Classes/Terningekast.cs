using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper.Classes
{
    class Terningekast
    {
        private void Main()
        {
            Console.WriteLine("Terningkastet\n");

            Random random = new Random();

            int kast = random.Next(1, 7);

            // Skifter skrifttypen til gul
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Skifter baggrunden til blå
            Console.BackgroundColor = ConsoleColor.Blue;

            // Vælger et tal mellem 1-6
            switch (kast)
            {
                case 1:
                    Console.WriteLine("Du slog en 1'er");
                    break;
                case 2:
                    Console.WriteLine("Du slog en 2'er");
                        break;
                case 3:
                    Console.WriteLine("Du slog en 3'er");
                    break;
                case 4:
                    Console.WriteLine("Du slog en 4'er");
                    break;
                case 5:
                    Console.WriteLine("Du slog en 5'er");
                    break;
                case 6:
                    Console.WriteLine("Du slog en 6'er");
                    break;
            }

            Console.ReadLine();
        }
    }
}
