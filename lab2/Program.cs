using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie1 osoba = new Zadanie1("Jowita", "Śliwa", 19);
            osoba.WyswietlInformacje();

            Zadanie2 rachunek = new Zadanie2((decimal)142.15, "Marcin Nowak");
            rachunek.Wplata((decimal)10);
            rachunek.Wyplata((decimal)15);
            Console.WriteLine($"Saldo: {rachunek._saldo}");

            Zadanie3 uczen = new Zadanie3("Michał", "Palak", new int[] { 1, 2, 3, 4, 5 ,6,3,3,3});
            decimal srednia = uczen.Srednia_ocen();
            Console.WriteLine($"srednia: {srednia:F2}");

            uczen.dodaj_ocene(1);

            Zadanie4 l1 = new Zadanie4(10);

            Zadanie4 l2 = new Zadanie4(10);
            Zadanie4 l3 = new Zadanie4(10);
            Zadanie4 l4 = new Zadanie4(10);
            Zadanie4 l5 = new Zadanie4(10);

            l1.Dodaj(5);
            l2.Odejmij(2);
            l3.Dodaj(11);
            l4.Odejmij(100);
            l5.Dodaj(121125);

            Zadanie4[] tablica_obiektow = { l1, l2, l3, l4, l5 };
            foreach(Zadanie4 obiekt in tablica_obiektow)
            {
                obiekt.Wypisz_value();
            }

            Sumator alfa = new Sumator(new int[] { 1,2,3,4,5,6,7,8,9,10});

            Console.WriteLine($"suma zwykla: {alfa.Suma()}");

            Console.WriteLine($"suma zwykla: {alfa.SumaPodziel2()}");
            Console.WriteLine($"ilosc elementow:{alfa.IleElementow()} ");
            alfa.Low_high(3, 48);

        }

    }
}
