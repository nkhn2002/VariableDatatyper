using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VariableDatatyper.Classes
{
    class Porto
    {
        public static double Size;
        public static double Weight;
        public static string Country;

        public static double Height;
        public static double Width;
        public static double Length;

        public static double DKK;
        public static double EUR;

        private void Main()
        {
            Start:

            Console.WriteLine("Tilgængelide Lande: Danmark, Europa");

            Console.Write("Vægt (gram): ");
            Weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Land: ");
            Country = Console.ReadLine();

            Console.Write("Højde: ");
            Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Længde: ");
            Length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bredde: ");
            Width = Convert.ToDouble(Console.ReadLine());

            Size = Height + Length + Width;

            DKK = 0;
            EUR = 0;

            if (Country.ToLower() == "danmark")
            {
                if (Size > 90)
                {
                    Console.WriteLine("Det er en pakke");

                    if (Weight <= 50)
                    {
                        DKK = 50;
                        Console.WriteLine($"{DKK}kr");
                    }
                    else
                    {
                        DKK = 100;
                        Console.WriteLine($"{DKK}kr");
                    }
                }
                else
                {
                    Console.WriteLine("Det er et brev");
                    if(Weight <= 50)
                    {
                        DKK = 10;
                        Console.WriteLine($"{DKK}kr");
                    }
                }
            }
            else if(Country.ToLower() == "europa")
            {
                if(Size > 90)
                {
                    Console.WriteLine("Det er en pakke");
                    if(Weight < 50)
                    {
                        DKK = 190;
                        Console.WriteLine($"{DKK}kr");
                    }
                    else
                    {
                        DKK = 100;
                        Console.WriteLine($"{DKK}kr");
                    }
                }
                else
                {
                    Console.WriteLine("Det er et brev");
                    DKK = 30;
                    Console.WriteLine($"{DKK}kr");
                }
            }
            else
            {
                Console.WriteLine("Du kan kun vælge mellem Danmark eller Europa");
                Thread.Sleep(2000);
                Console.Clear();
                goto Start;
            }
        }
    }
}
