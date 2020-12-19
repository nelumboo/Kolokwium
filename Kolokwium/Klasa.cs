// Stwórz klasę Przesyłka. Powinna zawierać właściwości Nadawca, Odbiorca, DataNadania, DataDoreczenia i Status. Status to enum o wartościach Nadana, WTransporcie i Doreczona. Dodaj konstruktor, który przyjmie parametr i wypełni informacjeNadawca
//     i Odbiorca a także sprawdzi czy parametr Odbiorca nie jest pusty. Data nadania to data stworzenia obiektu, Status to Nadana. Dodaj funkcję Przyjmij która ustawi status na WTransporcie. Dodaj metodę Dorecz która ustawi status na Doreczona i uzupełni właściwość
//     DataDoreczenia aktualną datą. 

using System;

namespace Kolokwium
{
    public enum Status
    {
        Nadana,
        WTransporcie,
        Doreczona
    }

    public class Klasa
    {
        public string Nadawca { get; set; }
        public string Odbiorca { get; set; }
        public DateTime DataNadania { get; set; }
        public DateTime DataDoreczenia { get; set; }
        public Status Status { get; set; }

        public Klasa(string nadawca, string odbiorca)
        {
            Nadawca = nadawca;

            if (string.IsNullOrWhiteSpace(odbiorca))
                throw new AggregateException("Pole odbiorca nie moze byc puste");
            else
            {
                Odbiorca = odbiorca;
            }

            DataNadania = DateTime.Now;
            Status = Status.Nadana;
        }

        public void Dorecz()
        {
            Status = Status.Doreczona;
            DataDoreczenia = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{nameof(Nadawca)}: {Nadawca}, {nameof(Odbiorca)}: {Odbiorca}, {nameof(DataNadania)}: {DataNadania}, {nameof(DataDoreczenia)}: {DataDoreczenia}, {nameof(Status)}: {Status}";
        }
    }
}