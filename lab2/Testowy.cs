using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Zadanie1
    {
        private string _imie;
        private string _naziwsko;
        private int _wiek;
        public string Imie {
            get { return _imie; }
            set {
                if (value.Length > 1)
                    _imie = value;
            }

        }
        public string Nazwisko
        {
            get { return _naziwsko; }
            set
            {
                if (value.Length > 1)
                    _naziwsko = value;
            }
        }
        public int Wiek
        {
            get { return _wiek; }
            set
            {
                if (value > 0)
                    _wiek = value;
            }
        }
        public Zadanie1(string imie, string nazwisko, int wiek)
        {
            _imie = imie;
            _naziwsko = nazwisko;
            _wiek = wiek;
        }
        public void WyswietlInformacje()
        {
            Console.WriteLine($"imie: {_imie}, nazwisko: {_naziwsko}, wiek: {_wiek}");
        }
    }
    public class Zadanie2
    {
        public decimal _saldo { get; private set; }
        public string _wlasciciel { get; private set; }
        public void Wplata(decimal kwota)
        {
            if (kwota > 0)
            {
                _saldo += kwota;
            }
        }
        public void Wyplata(decimal kwota)
        {
            if (kwota > 0 && _saldo >= kwota)
            {
                _saldo -= kwota;
            }
        }

        public Zadanie2(decimal kwota_startowa, string dane_usera)
        {
            _saldo = kwota_startowa;
            _wlasciciel = dane_usera;
        }
    }
    public class Zadanie3{
        private int[] _tablica_ocen;
        public string _imie { get; private set; }
        public string _nazwisko { get; private set; }
        public Zadanie3(string imie, string nazwisko, int[] oceny)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _tablica_ocen = oceny;

        }
        public decimal Srednia_ocen()
        {
            int liczba_ocen;
            int suma;
            decimal wynik = 0;

            // ta funkcja zwraca 2 zmienne 
            get_liczba_ocen(out liczba_ocen, out suma);
            Console.WriteLine($"liczba ocen: {liczba_ocen}, suma: {suma}");
            if (liczba_ocen > 0 && suma > 0)
            {
                // obliczenie sredniej i rzut do decimal
                wynik = (decimal) suma/liczba_ocen;
                Console.WriteLine($"wynik: {wynik}");
                

            }
            return wynik;
        }
        private void get_liczba_ocen(out int licznik, out int suma)
        {
            licznik = 0;
            suma    = 0;
            foreach( int ocena in _tablica_ocen)
            {
                if (ocena > 0)
                {
                    licznik++;
                    suma += ocena;
                }
            }
            
        }
        public void dodaj_ocene(int ocena)
        {
            if (ocena >= 1 && ocena <= 6)
            {
                
                // tworzenie nowej tablicy wiekszej o 1
                
                int[] oceny = new int[_tablica_ocen.Length + 1];
                //przepisanie ocen do nowej tablicy 
                for (int i =0; i < _tablica_ocen.Length; i++)
                {
                    oceny[i] = _tablica_ocen[i];
                }
                // przypisanie oceny do ostatniej wolnej pozycji
       
                oceny[_tablica_ocen.Length] = ocena;
                // zmiana nazwy (przypisanie nowej tablicy do starej
                _tablica_ocen = oceny;
            }
            Wyswietl_oceny();
        }
        private void Wyswietl_oceny()
        {
            foreach (int ocena in _tablica_ocen)
            {
                Console.WriteLine($"ocena: {ocena}");
            }
        }
            


    }
    public class Zadanie4
    {
        private int _value ;

        public Zadanie4(int wartosc)
        {
            _value = wartosc;
        }
        public void Wypisz_value()
        {
            Console.WriteLine($"value: {_value}");
        }
        public void Dodaj(int wartosc)
        {
            _value += wartosc;
        }
        public void Odejmij(int wartosc)
        {
            _value -= wartosc;
        }
    }
    public class Sumator
    {
        private int[] Liczby;
        public Sumator( int [] tablica_wejsciowa)
        {
            Liczby = tablica_wejsciowa;
        }
        public int Suma()
        {
            int wynik = 0;
            foreach (int wartosc in Liczby)
            {
                wynik += wartosc;

            }
            return wynik;
        }

        public int SumaPodziel2()
        {
            int wynik = 0;
            foreach (int wartosc in Liczby)
            {
                if (wartosc % 2 == 0)
                {
                    wynik += wartosc;
                }

            }
            return wynik;
        }
        public int IleElementow()
        {
            return Liczby.Length;
        }
        public void WypiszLiczby()
        {
            foreach (int x in Liczby)
            {
                Console.WriteLine($"Zadanie4 liczby: {Liczby}");
            }
        }
        public void Low_high(int low_index, int high_index)
        {
            if(low_index > high_index)
                throw new ArgumentException("Nie da sie");
            if (low_index < 0)
                low_index = 0;
            if (high_index > Liczby.Length-1) 
                high_index = Liczby.Length-1;
            Console.WriteLine($"low: {low_index} high: {high_index}");
            for (int i=low_index; i<=high_index; i++)
            {
                Console.WriteLine($"Zadanie 4 low-high: {Liczby[i]}  i = {i}");
            }   
        }
    }




}
