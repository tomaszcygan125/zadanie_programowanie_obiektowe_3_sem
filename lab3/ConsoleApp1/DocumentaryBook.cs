using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class DocumentaryBook : Book 
    {
        public string arm;  
        public DocumentaryBook(string tytul, Person autor, DateOnly data_wydania, string arm) : base(tytul, autor, data_wydania)  {
        this.arm = arm; 
        }

        public new void View()
        {
            base.View();
            Console.WriteLine($"arm: {arm}");
        }
    }
}
