using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Book
    {
        protected string Title;
        protected Person Author;
        DateOnly Data_wydania;
        public string title
        {
            get { return Title; }
            set { Title = value; }
        }
        public Person author
        {
            get { return Author; }
            set { Author = value; }
        }
        public DateOnly data_wydania
        {
            get { return Data_wydania; }
            set { Data_wydania = value; }
        }
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
