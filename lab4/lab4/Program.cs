// See https://aka.ms/new-console-template for more information
using lab4;

/*
Console.WriteLine("Hello, World!");
List<Shape> l1 = new List<Shape>();

l1.AddRange(new Triangle(1, 2, 3, 4), new Circle(1, 2, 3, 4), new Rectangle(1, 2, 3, 4), new Circle(1, 2, 3, 4));

foreach(Shape s in l1)
{
    s.Draw();
}
*/

Console.WriteLine("Hello, World!");
List<Zad3Osoba> lista_osob = new List<Zad3Osoba>();
lista_osob.AddRange(new Zad3Osoba("tom", "zaren"), new Zad3Osoba("tom2", "malek"), new Zad3Osoba("tom3", "arka"));

foreach(Zad3Osoba z3o in lista_osob)
{
    z3o.ZwrocPelnaNazwe();
}

List<IZad3Osoba> listIosoba = new List<IZad3Osoba>();

listIosoba.AddRange(lista_osob);
listIosoba.WypiszOsoby();

listIosoba.PosortujOsobyPoNazwisku();



