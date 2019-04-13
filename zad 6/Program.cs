using System;

namespace zad_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Podaj wartosc n: ");
            string text = Console.ReadLine();
            if (!Int32.TryParse(text, out n))
                throw new ArgumentException("n nie jest liczba calkowita!\n");

            //Policz silnie liczby n i wydrukuj ja na ekranie
            int silnia = Factorial(n);
            Console.WriteLine("Silnia liczby {0} wynosi: {1}", n, silnia);

            Console.ReadKey();

        }
            /*****************************************************************************/
        static int Factorial(int mm)
        {
            //Policz silnie liczby mm, liczac ja w kolejnosci: 1*2*...*mm
            int i = 1;
            int wynik = 1;
            while (i <= mm)
                wynik *= i++;

            return wynik;
        }
    }
}
