using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Reviewer :Reader
    {
        public Reviewer(string firstName, string lastName, int wiek) : base(firstName, lastName, wiek)
        {         
        }
        public void Wypisz()
        {

            foreach (Book b1 in reedBooks)
            {
                Random o = new Random();
                int ocena =  o.Next(1, 10);
                Console.WriteLine($"Przeczytana ksiazka tytul: {b1.title} przez usera: {firstName} ocena {ocena}");
            }

        }
    }
}
