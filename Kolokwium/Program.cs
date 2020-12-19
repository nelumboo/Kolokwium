using System;
using System.Linq;

namespace Kolokwium
{
    class Program
    {

        static void Fun(int mm)
        {
           int profile = 2000 / mm;
           var odpadki = 2000 - ((profile * mm) - profile);

            Console.WriteLine($"Piłka wytnie {profile} profili i zostanie {odpadki} mm odpadków");

        }

        static void Fun2(string policz)
        {
            var zm = policz.Split(" ");
            double size = zm.Length;
            double ile = 0.24 * size;

            Console.WriteLine($"W zadanym zdaniu znajduje się {size} słów. Do przeczytania potrzebne będzie {ile} sekund");

        }
        
        
        static void Main(string[] args)
        {
            var a = 165;
            Fun(a);

            var zdanie = "Napisz funkcję, która przyjmie tekst a następnie obliczy ile jest w nim słów (np. na podstawie ilości spacji) a następnie obliczy ile czasu zajmie średnio przeczytanie tekstu. Średnia prędkość czytania to 250 słów na minutę. Funkcja powinna wypisać na ekran komunikat ile słów ma tekst i ile powinno zająć jego przeczytanie. Wywołaj funkcję na dowolnym tekście (np. 1 zdaniu).";
            
            Fun2(zdanie);

            Klasa paczka = new Klasa("Józek", "Kwiatkowski");

            Console.WriteLine(paczka);
            paczka.Dorecz();
            Console.WriteLine(paczka);

        }
    }
}