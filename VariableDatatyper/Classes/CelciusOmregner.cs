using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper.Classes
{
    class CelciusOmregner
    {
        private void Main()
        {
            Console.WriteLine("Celciusomregner\n");

            Console.Write("Celicus: ");
            try
            {
                // Her parser vi en double værdi fra det input vi laver i konsollen.
                double Celcius = double.Parse(Console.ReadLine());

                // Her ganger vi vores celcius værdi med 0.8 så vi får Reamur værdien.
                double Reamur = Celcius * 0.8;

                // Her ganger vi vores celcius værdi med 1.8 og pludser med 32 så vi får Fahrenheit værdien.
                double Fahrenheit = Celcius * 1.8 + 32;

                // Her outputter vi Reamur og Fahrenheit i konsollen.
                Console.WriteLine($"\nReamur: {Reamur}" +
                    $"\nFahrenheit: {Fahrenheit}");
            }
            catch
            {
                Console.WriteLine("\nDet skal være en double!");
            };

            Console.ReadLine();
        }
    }
}
