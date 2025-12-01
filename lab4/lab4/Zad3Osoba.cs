using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public class Zad3Osoba : IZad3Osoba
    {
        public string Imie {  get; set; }
        public string Nazwisko { get; set; }
        public void ZwrocPelnaNazwe()
        {
            Console.WriteLine($"imie: {Imie} nazwisko: {Nazwisko}");

        }
        public Zad3Osoba( string imie , string nazwisko)
        {
            Imie = imie;        
            Nazwisko = nazwisko;
        }
    }
}
