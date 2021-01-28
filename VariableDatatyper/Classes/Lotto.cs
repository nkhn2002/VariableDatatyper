using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper
{
    class Lotto
    {
        private void Main()
        {
            Console.WriteLine("Eksempel på kupon: 13 10 3 12 6 3 16\n");

            Random r = new Random();

            List<int> lottoTal = new List<int>();

            // Tilføj 7 random tal til lottoTal listen
            for (int i = 0; i < 7; i++)
            {
                int ran = r.Next(1, 21);

                if (lottoTal.Contains(ran))
                {
                    i--;
                }
                else if (!lottoTal.Contains(ran))
                {
                    lottoTal.Add(ran);
                }

            }

            // Brugerens kupon
            int[] brugerKupon = { };

            Console.Write("Din kupon: ");

            string kupon = Console.ReadLine();

            // Splitter kuppon på hvert mellemrum
            int[] split = Array.ConvertAll(kupon.Split(' '), s => int.Parse(s));

            // Error handling
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i] > 20)
                {
                    Console.WriteLine("\nDu må ikke have et tal mere end 20");
                }
            }

            // Error handling
            if (split.Length < 7 || split.Length > 7)
            {
                Console.WriteLine("\nIkke den korrekte format");
                Console.ReadLine();
                return;
            }

            Console.Write($"\nKorrekt tal: ");

            // Korrekte tal brugeren har i kupponen
            List<int> rigtigeTal = new List<int>();

            foreach (int sTal in split)
            {
                foreach (int tal in lottoTal)
                {
                    if (sTal == tal)
                    {
                        rigtigeTal.Add(sTal);
                    }
                }
            }

            switch (rigtigeTal.Count)
            {
                case 1:
                    Console.WriteLine("\nDu fik kun 1 rigtig tal og ingen gevinst, prøv igen en anden gang!");
                    break;

                case 2:
                    Console.WriteLine("\nTillykke! Du fik 2 rigtige tal og har vundet 50kr!");
                    break;

                case 3:
                    Console.WriteLine("\nTillykke! Du fik 3 rigtige tal og har vundet 171kr!");
                    break;

                case 4:
                    Console.WriteLine("\nTillykke! Du fik 4 rigtige tal og har vundet 1.432kr!");
                    break;

                case 5:
                    Console.WriteLine("\nTillykke! Du fik 5 rigtige tal og har vundet 17.113kr!");
                    break;

                case 6:
                    Console.WriteLine("\nTillykke! Du fik 6 rigtige tal og har vundet 172.606kr!");
                    break;

                case 7:
                    Console.WriteLine("\nTillykke! Du fik alle rigtige tal og har vundet 1.000.000kr!");
                    break;

                default:
                    Console.WriteLine("\nDu fik kun 0 rigtig tal og ingen gevinst, prøv igen en anden gang!");
                    break;

            }

            Console.ReadLine();
        }
    }
}
