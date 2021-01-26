using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper.Classes
{
    class Valutaomregner
    {
        private void Main()
        {
            // Forskellige valuta exchange værdier. 
            double USD = 0.16;
            double EUR = 0.13;
            double SEK = 1.38;
            double GBP = 0.12;

            Console.WriteLine("Valutaomregner");

            Console.Write("\nAntal kr: ");

            try
            {
                // Her parser vi en double værdi fra det input vi laver i konsollen.
                double DKK = double.Parse(Console.ReadLine());

                // Her outputter vi den omregnede valuta ved at gange DKK med de forskellige valutaer vi har sat længere oppe i koden.
                Console.WriteLine("\nOmregnet resultater: " +
                    $"\nUSD: {DKK * USD}" +
                    $"\nEUR: {DKK * EUR}" +
                    $"\nSEK: {DKK * SEK}" +
                    $"\nGBP: {DKK * GBP}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            };

            Console.ReadLine();
        }
    }
}
