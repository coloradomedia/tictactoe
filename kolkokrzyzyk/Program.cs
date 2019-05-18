using System;

namespace kolkokrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            GraczLudzki gA = new GraczLudzki();
            GraczKomputerowy gB = new GraczKomputerowy();
            gA.Imie = "Uzytkownik";
            gB.Imie = "Komputer";
            gA.Znak = 'o';
            gB.Znak = 'x';

            char[,] plansza = new char[3, 3]
            {
                {'1','2','3' },
                {'4','5','6' },
                {'7','8','9' }
            };

            bool koniecGry = false;
            bool ruchGraczaA = true;
            while (!koniecGry)
            {
                Console.Clear();
                RysujPlansze(plansza);

                if (ruchGraczaA)
                {
                    Console.WriteLine("Ruch wykonuje: " + gA.Imie);
                    koniecGry = gA.WykonajRuch(plansza);
                    ruchGraczaA = false;
                }
                else
                {
                    Console.WriteLine("Ruch wykonuje: " + gB.Imie);
                    koniecGry = gB.WykonajRuch(plansza);
                    ruchGraczaA = true;
                }

                Console.ReadKey();
            }
        }
    }
    static void RysujPlansze(char[,] plansza)
    {
        int wysokosc = plansza.GetLength(0);
        int szerokosc = plansza.GetLength(1);

        for (int i = 0; i < wysokosc; ++i)
        {
            for (int j = 0; j < szerokosc; ++j)
                Console.Write(plansza[i, j]);
            Console.WriteLine();
        }
    }

    interface IRuch
    {
        bool WykonajRuch(char[,] plansza);
    }

    abstract class Gracz
    {
        public string Imie { get; set; }
        public char Znak { get; set; }
    }

    class GraczLudzki : Gracz, IRuch
    {
        public bool WykonajRuch(char[,] plansza)
        {
            return false;
        }
    }
    class GraczKomputerowy : Gracz, IRuch
    {
        public bool WykonajRuch(char[,] plansza)
        {
            return false;
        }
    }
}
