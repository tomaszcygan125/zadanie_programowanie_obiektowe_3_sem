using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace lab4
{
    internal interface Iosoba
    {
        string imie { get; set; }
        string nazwisko { get; set; }
        string ZwrocPelnaNazwe();
    }
}
