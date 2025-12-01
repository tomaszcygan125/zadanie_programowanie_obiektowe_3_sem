using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Samochod
    {
        public string Marka{ get; set; }
        public string Model{ get; set; }
        public string Nadwozie { get; set; }
        public string Kolor { get; set; }
        private int Rok_produkcji ;
        public int rok_produkcji { get => Rok_produkcji; 
            set
            {
                if (value > 0) {
                    rok_produkcji = value;
                }
                else
                {
                    rok_produkcji = 0;
                }

            }
        }
        private int Przebieg;
        public int przebieg {  get => Przebieg;
            set 
            {
                if (value > 0)
                {
                    Przebieg = value;
                }
                else
                {
                    Przebieg = 0;
                }
            } 
        }
        public Samochod(string marka, string model, string nadwozie, string kolor, int rok_produkcji, int przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            Rok_produkcji = rok_produkcji;
            Przebieg = przebieg;
        }
        public Samochod()
        {
            Console.Write("Podaj markę: ");
            Marka = Console.ReadLine();

            Console.Write("Podaj model: ");
            Model = Console.ReadLine();

            Console.Write("Podaj nadwozie: ");
            Nadwozie = Console.ReadLine();

            Console.Write("Podaj kolor: ");
            Kolor = Console.ReadLine();

            Console.Write("Podaj rok produkcji: ");
            Rok_produkcji = int.Parse(Console.ReadLine());

            Console.Write("Podaj przebieg: ");
            Przebieg = int.Parse(Console.ReadLine());
        }
        public void View()
        {            
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Nadwozie: {Nadwozie}");
            Console.WriteLine($"Kolor: {Kolor}");
            Console.WriteLine($"Rok produkcji: {Rok_produkcji}");
            Console.WriteLine($"Przebieg: {Przebieg}");
        }
    }
}
