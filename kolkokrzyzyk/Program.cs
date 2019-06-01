using System;

namespace kolkokrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            GraczKomputerowy gB = new GraczKomputerowy();
            gA.Imie = "Uzytkownik";
            gB.Imie = "Komputer";
            gA.Znak = 'x';
            gB.Znak = 'o';

            char[,] plansza = new char[3, 3] {
                {'1','2','3' },
                {'4','5','6' },
                {'7','8','9' }
            };
            char[,] planszaKopia = plansza.Clone() as char[,];

            //petla na kolejne ruchy graczy
            bool koniecGry = false;
            bool ruchGraczaA = true;
            for (int runda = 0; runda < plansza.Length; ++runda)
            {
                Console.Clear();
                RysujPlansze(plansza);

                if (ruchGraczaA)
                {
                    Console.WriteLine("Ruch wykonuje: " + gB.Imie);
                    koniecGry = gB.WykonajRuch(plansza, planszaKopia);
                    ruchGraczaA = true;
                }
                Console.ReadKey();
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

    }
    interface IRuch
    {
        bool
    }
    abstract class Gracz
    {
        public char Znak { get; set; }
        public bool SprawdzCzyKoniecGry(char[,] plansza)
        {
            int wysokosc = plansza.GetLength(0);
            int szerokosc = plansza.GetLength(1);
            if (szerokosc != wysokosc)
                throw new Exception("Plansza nie jest kwadratowa!");

            //sprawdz wiersze
            for (int i = 0; i < wysokosc; ++i)
            {
                int sumaWiersza = 0;
                for (int j = 0; j < szerokosc; ++j)
                {
                    if (plansza[i, j] == Znak)
                        ++sumaWiersza;
                }
                if (sumaWiersza == szerokosc)
                    return true;
            }
            //sprawdz kolumny
            for (int j = 0; j < szerokosc; ++j)
            {
                int sumaKolumny = 0;
                for (int i = 0; i < szerokosc; ++i)
                {
                    if (plansza[i, j] == Znak)
                        ++sumaKolumny;
                }
                if (sumaKolumny == szerokosc)
                    return true;
            }
            //sprawdz przekatne
            int sumaPrzekatnejA = 0;
            int sumaPrzekatnejB = 0;
            for (int k = 0; k < szerokosc; ++k)
            {
                if (plansza[k, k] == Znak)
                    ++sumaPrzekatnejA;
                if (plansza[k, szerokosc - 1 - k] == Znak)
                    ++sumaPrzekatnejB;
                }
            if (sumaPrzekatnejA == szerokosc || sumaPrzekatnejB == szerokosc)
                return true;
            //zadna z opcji, czyli jeszcze nie koniec gry
            return false;
        }
    }
    class GraczLudzki : Gracz, IRuch
    {
        public bool WykonajRuch(char[,] plansza, char[,] planszaKopia)
        {
            return SprawdzCzyKoniecGry(plansza);
        }
    }
    class GraczKomputerowy : Gracz, IRuch
    {
        public bool WykonajRuch(char[,] plansza, char[,] planszaKopia)
        {
            return SprawdzCzyKoniecGry(plansza);
        }
    }

}
