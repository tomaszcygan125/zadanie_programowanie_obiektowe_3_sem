using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Reader : Person
    {
    public List<Book> ReedBooks { get;set;} = new List<Book>();

    public Reader(string firstName, string lastName, int wiek) : base(firstName, lastName, wiek)
    {// automatyczne wywolanie kontruktora bazowego
    }
    public void ViewReedBooks()
        {
            foreach (Book b1  in ReedBooks)
            {
                Console.WriteLine($"Przeczytana ksiazka tytul: {b1.Title} przez usera: {firstName}");
            }
        }
    
    public override void View()

    {
            Console.WriteLine("view w reader");
            base.View();
            ViewReedBooks();
    }

    public void OnlyReader()
        {
            Console.WriteLine("only reader");
        }

}
}
