using System;

namespace kolkokrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            string imieGraczaA = "";
            string imieGraczaB = "";
            char znakGraczaA = "x";
            char znakGraczaB = "o";
            char[,] plansza = new char[3, 3]
            {
                {'1','2','3' },
                {'4','5','6' },
                {'7','8','9' }
            };

            Console.Write("Wpisz imie gracza A: ");
            imieGraczaA = Console.ReadLine();
            Console.Write("Wpisz inie gracza B: ");
            imieGraczaB = Console.ReadLine();
        }

    }
}
