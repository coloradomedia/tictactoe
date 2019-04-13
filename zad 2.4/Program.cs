using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Pobierz wartosc dzielnej (a) i dzielnika (b)
                int a, b;
                string text;
                Console.Write("Podaj waetosc dzielnej (a): ");
                text = Console.ReadLine();
                Int32.TryParse(text, out a);
                Console.Write("Podaj waetosc dzielnika (b): ");
                text = Console.ReadLine();
                Int32.TryParse(text, out b);

                //Sprobuj wy konac dzielenie i obsluz wyjatek przy dzieleniu przez zero
                Console.WriteLine("Wynik dzielenia {0}", a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nie wolno dzielic przez zero!");
            }
            finally
            {
                Console.WriteLine("Dziekuje");

                Console.ReadKey();
            }
        }
    }
}
