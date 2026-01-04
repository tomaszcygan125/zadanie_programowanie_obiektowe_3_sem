using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Contacts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }    

        public Contacts(int Id, string Name, string Email )
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
        }
    }
}
