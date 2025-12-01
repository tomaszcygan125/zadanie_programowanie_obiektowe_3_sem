using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ConsoleApp1
{   
    public  class AdventureBook : Book 
    {
        public string adventure_scale;
        public AdventureBook(string tytul, Person autor, DateOnly data_wydania, string adventure_scale) : base( tytul, autor, data_wydania)
        {
            this.adventure_scale = adventure_scale;

        }
        public new void View()
        {
            base.View();
            Console.WriteLine($"adventure_scale: {adventure_scale} ");
        }
    }
}
