using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolitycznie
{
    class Program
    {
        /// <summary>
        /// Generuje liczbę pseudolosową z podanego zakresu włącznie z krańcami.
        /// </summary>
        /// <param name="min">dowolna liczba całkowita</param>
        /// <param name="max">dowolna liczba całkowita</param>
        /// <returns>liczba całkowita z podanego zakresu</returns>
        static int Losuj(int min = 1, int max = 100)
        {
            Random generator = new Random();
            if (min > max)
            { //swap
                int temp = min;
                min = max;
                max = temp;
            }
            return generator.Next(min, max + 1);
        }

        /// <summary>
        /// Wczytuje z konsoli liczbę lub znak X
        /// </summary>
        /// <returns>Liczba całkowita odpowiadająca podanej wartości na konsoli</returns>
        /// <exception cref="OperationCanceledException">gdy wprowadzono 'x' lub 'X'</exception>
        static int WczytajLiczbe(string prompt = "Podaj liczbę (lub X aby zakończyć): ")
        {
            int propozycja = 0;

            while (true)
            {
                Console.Write(prompt);
                string tekst = Console.ReadLine();

                if (tekst.ToLower() == "x")
                    throw new OperationCanceledException("Wprowadzono X");

                try
                {
                    propozycja = Convert.ToInt32(tekst);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podano liczby! Spróbuj jeszcze raz.");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba nie mieści się w rejestrze! Spróbuj jeszcze raz.");
                    continue;
                }
            }

            return propozycja;
        }

        static string Ocena(int propozycja)
        {
            if (propozycja < wylosowana)
                return "za mało";
            else if (propozycja > wylosowana)
                return "za dużo";
            else
                return "trafiono";
        }

        static int wylosowana = 0;

        static void Main(string[] args)
        {
            // 1. Komputer losuje liczbę
            int min = WczytajLiczbe("Podaj zakres - min: ");
            int max = WczytajLiczbe("Podaj zakres - max: ");

            wylosowana = Losuj(min, max);
            Console.WriteLine($"Wylosowałem liczbę od {min} do {max}. \n Odgadnij ją");

#if (DEBUG)
            Console.WriteLine(wylosowana);
#endif

            //wykonuj
            bool trafiono = false; //wartownik (zwany czasami flagą)
            do
            {
                int propozycja = 0;
                try
                {
                    propozycja = WczytajLiczbe("Podaj swoją propozycję (lub X aby poddać się): ");
                    Console.WriteLine($"Przyjąłem wartość {propozycja}");
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Koniec");
                    return;
                }

                //Console.WriteLine(Ocena(propozycja));
                string wynik = Ocena(propozycja);
                Console.WriteLine(wynik);
                if (wynik == "trafiono")
                    break;
            }
            while (true);
            //do momentu trafienia

            Console.WriteLine("Koniec gry");
        }
    }
}