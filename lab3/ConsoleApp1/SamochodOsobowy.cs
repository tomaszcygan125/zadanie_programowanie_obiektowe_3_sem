using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class SamochodOsobowy :Samochod
    {
        private int Waga;
        public int waga { 
            get => Waga;

            set
            {
                if (value > 4500 || value < 2000)
                {
                    throw new Exception("waga nie moze byc mniejsza niz 2 t lub większa niz 4.5 t");
                }
                else {
                Waga = value; 
                }

            }
        }
        public int IloscOsob;
        public SamochodOsobowy() :base() {
            Console.Write("Podaj wage: ");
            Waga = int.Parse(Console.ReadLine());
            Console.Write("Podaj ilosc osob: ");
            IloscOsob = int.Parse(Console.ReadLine());

        }
        public SamochodOsobowy(string marka, string model, string nadwozie, string kolor, int rok_produkcji, int przebieg, int waga, int ilosc_osob) : base(marka, model, nadwozie, kolor, rok_produkcji, przebieg)
        {
            this.Waga = waga;
            this.IloscOsob = ilosc_osob;
        }
        public new  void View()
        {
            base.View();
            Console.WriteLine($"waga: { Waga} ");
            Console.WriteLine($"ilosc osob: {IloscOsob}");
        }
    }
}
