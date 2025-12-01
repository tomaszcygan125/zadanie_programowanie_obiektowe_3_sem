// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.ComponentModel;
using System.Security.Cryptography;

/*
Console.WriteLine("Hello, World!");

//tworzenie osob 
Person p1 = new Person("tom", "roe", 12);
Person p2 = new Person("ala", "roe", 33);
Person p3 = new Person("Gerwazy", "roe", 33);
Person a1 = new Person("Lana", "del rey", 15);
Person a2 = new Person("Marcin", "Druajczyk", 15);

// tworzenie randomowych ksiazek
Book book1 = new Book("Władca Pierścieni", a1, new DateOnly(2025,10,10));
Book book2 = new Book("Harry Potter", a1, new DateOnly(2025, 10, 10));
Book book3 = new Book("1984", a2, new DateOnly(2025, 10, 10));
Book book4 = new Book("Mały Książę", a1, new DateOnly(2025, 10, 10));
Book book5 = new Book("Hobbit", a2, new DateOnly(2025, 10, 10));

Reader r1 = new Reader("czytelnik1", "pierwszy", 33);
r1.reedBooks.AddRange(new List<Book> { book1, book2, book3 });

Reader r2 = new Reader("czytelnik2", "drugi", 33);
r2.reedBooks.AddRange(new List<Book> { book1, book3});
//r1.ViewReedBooks();
//r2.ViewReedBooks();

// r1.View();
Person o = new Reader("czytelnik3", "Trzeci", 32);

o.View();

// twoerzenie recenzenta 

Reviewer rev1 = new Reviewer("rev1", "rev2", 32);

rev1.reedBooks.AddRange(new List<Book> { book1, book2, book3 });


Console.WriteLine("wypisz ksiazki recenzenta: ");
rev1.Wypisz();


List<Person> Lista_osob = new List<Person>();

Lista_osob.AddRange(new List<Person> { r1, r2, rev1, r2, new Reviewer("rev3", "last", 31), p1, p2 });

foreach (Person person in Lista_osob)
{
    person.View();
}

*/
Person a2 = new Person("Marcin", "Druajczyk", 15);
AdventureBook a1 = new AdventureBook("Elementarz", a2, new DateOnly(2025, 10, 10), "epic");

a1.View();

DocumentaryBook d1 = new DocumentaryBook("Elementarz", a2, new DateOnly(2025, 10, 10), "epic");
d1.View();


Console.WriteLine("zadnie 2 - ----------------------");

Samochod s1 = new Samochod("marka" ,"model", "nadwozie" , "czerwony", 2011, 185000);
SamochodOsobowy s2 = new SamochodOsobowy("marka", "model", "nadwozie", "czerwony", 2011, 185000, 2, 14);
s1.View();
s2.View();