using System;

namespace zad2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definicje i wydruk zmiennych
            int a = 3, b = 4;
            Console.WriteLine("Przed zmiana: a = {0}, b = {1}", a, b);

            //Zamiana i ponowny wydruk zmiennych
            Console.WriteLine("Po zmianie: a = {0}, b = {1}", a, b);

            Console.ReadKey();
        }

        static void Interchange(ref int aa, ref int bb)
        {
            int tmp = aa;
            aa = bb;
            bb = tmp;
        }
    }
}
