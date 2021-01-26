using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDatatyper.Classes
{
    class Morsekode
    {
        private void Main()
        {
            List<string> morsekode = new List<string>();

            Console.Write("Sætning: ");

            string morse = Console.ReadLine();

            foreach (char line in morse)
            {
                switch (line)
                {

                    case 'a':
                    case 'A':
                        morsekode.Add(".-");
                        break;

                    case 'b':
                    case 'B':
                        morsekode.Add("-...");
                        break;

                    case 'c':
                    case 'C':
                        morsekode.Add("-.-.");
                        break;

                    case 'd':
                    case 'D':
                        morsekode.Add("-..");
                        break;

                    case 'e':
                    case 'E':
                        morsekode.Add(".");
                        break;

                    case 'f':
                    case 'F':
                        morsekode.Add("..-.");
                        break;

                    case 'g':
                    case 'G':
                        morsekode.Add("--.");
                        break;

                    case 'h':
                    case 'H':
                        morsekode.Add("....");
                        break;

                    case 'i':
                    case 'I':
                        morsekode.Add("..");
                        break;

                    case 'j':
                    case 'J':
                        morsekode.Add(".---");
                        break;

                    case 'k':
                    case 'K':
                        morsekode.Add("-.-");
                        break;

                    case 'l':
                    case 'L':
                        morsekode.Add(".-..");
                        break;

                    case 'm':
                    case 'M':
                        morsekode.Add("--");
                        break;

                    case 'n':
                    case 'N':
                        morsekode.Add("-.");
                        break;

                    case 'o':
                    case 'O':
                        morsekode.Add("---");
                        break;

                    case 'p':
                    case 'P':
                        morsekode.Add(".--.");
                        break;

                    case 'q':
                    case 'Q':
                        morsekode.Add("--.-");
                        break;

                    case 'r':
                    case 'R':
                        morsekode.Add(".-.");
                        break;

                    case 's':
                    case 'S':
                        morsekode.Add("...");
                        break;

                    case 't':
                    case 'T':
                        morsekode.Add("-");
                        break;

                    case 'u':
                    case 'U':
                        morsekode.Add("..-");
                        break;

                    case 'v':
                    case 'V':
                        morsekode.Add("...-");
                        break;

                    case 'w':
                    case 'W':
                        morsekode.Add(".--");
                        break;

                    case 'x':
                    case 'X':
                        morsekode.Add("-..-");
                        break;

                    case 'y':
                    case 'Y':
                        morsekode.Add("-.--");
                        break;

                    case 'z':
                    case 'Z':
                        morsekode.Add("--..");
                        break;

                    case ' ':
                        morsekode.Add("/");
                        break;
                }

            }

            String[] morselist = morsekode.ToArray();

            Console.WriteLine("\nMorsekode: ");

            foreach (string line in morselist)
            {
                Console.Write(line + " ");
            }

            Console.ReadLine();
        }
    }
}
