using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Person
    {
        private string FirstName;
        private string LastName;
        private int Wiek;


        public string firstName
        {
           get { return FirstName; }
           set { firstName = value; }
        }
        public string lastName
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public int wiek
        {
            get { return Wiek; }
            set { Wiek = value; }
        }

        public Person(string first_name, string last_name, int wiek) { 
        
        this.FirstName = first_name;
        this.LastName = last_name;  
        this.Wiek = wiek;   


        }
        public virtual void View()
        {
            Console.WriteLine($"Imię: {FirstName}");
            Console.WriteLine($"Nazwisko: {LastName}");
            Console.WriteLine($"Wiek: {Wiek}");
        }
    }
}
