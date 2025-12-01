using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public interface IZad3Osoba
    {
        string Imie { get; set; }
        string Nazwisko { get; set; }
        void ZwrocPelnaNazwe();        
    }
}
