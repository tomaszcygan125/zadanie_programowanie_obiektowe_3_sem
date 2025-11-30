using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Book
    {
        public string Title { get; set; }
        public Person Author;
        DateOnly Data_wydania;
        public Book(string tytul, Person autor, DateOnly data_wydania)
        {
            this.Title = tytul;
            this.Author = autor;
            this.Data_wydania = data_wydania;
        }
        public void View()
        {
            Console.WriteLine($"tytul: {Title}");
            Console.WriteLine($"autor: {Author}");
            Console.WriteLine($"data wydania: {Data_wydania} ");
        }
    }
}
