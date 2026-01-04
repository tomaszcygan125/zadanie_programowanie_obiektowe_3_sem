using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TxtContactRepository
    {
        private readonly string _path;
        public TxtContactRepository(string path)
        {
            _path = path;
            CheckFileExists(_path);
        }
        public void CheckFileExists(string path)
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");
            }
        }
        public void ReadAll()
        {
            var contacts = new List<Contacts>();

            var lines = File.ReadAllLines(_path);
            foreach (var line in lines)
            {
                var part = line.Split(";");

                if (part.Length != 3) continue;
                contacts.Add(new Contacts(int.Parse(part[0]), part[1], part[2]));
            }
            foreach(var contact in contacts)
            {
                contact.Display();
            }
            
        }
        public List<Contacts> GetAll()
        {
            var contacts = new List<Contacts>();

            var lines = File.ReadAllLines(_path);
            foreach (var line in lines)
            {
                var part = line.Split(";");

                if (part.Length != 3) continue;
                contacts.Add(new Contacts(int.Parse(part[0]), part[1], part[2]));
            }
           
            return contacts;

        }
        public void AddContact(Contacts c)
        {
            try
            {
                if (File.ReadAllLines(_path).Any(Line =>
                 {
                     var parts = Line.Split(";");
                     int temp_id = int.Parse(parts[0]);
                     if (c.Id == temp_id)
                     {
                         return true;
                     }
                     else
                     {
                         return false;
                     }
                 }))
                {
                    throw new Exception("Contact already exists");
                }
                else {
                    string line = $"{c.Id.ToString()};{c.Name};{c.Email}";
                    File.AppendAllLines(_path, new[] { line });
                }
                }
            catch (Exception ex)
            {
                Console.WriteLine("nie da sie zapisac do pliku");
            }

        }
    }
}
