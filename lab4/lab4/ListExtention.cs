using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public static class ListExtention
    {
        public static void WypiszOsoby(this List<IZad3Osoba> lista)
        {
            foreach (IZad3Osoba o in lista)
            {
                o.ZwrocPelnaNazwe();
            }
        }
        public static void PosortujOsobyPoNazwisku(this List<IZad3Osoba> lista)
        {
            // sortowanie wyrazenie w srodku okresla co ma sie stac 
            lista.Sort((x,y) => string.Compare(x.Nazwisko, y.Nazwisko));
            lista.WypiszOsoby();
        }
    }
}
