using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TxtContactRepository
    {
        private readonly string _path;
        public TxtContactRepository(string path) { 
            _path = path;
            CheckFileExists(_path);
        }
        public void CheckFileExists(string path) {
            if (!File.Exists(path)) {
                File.WriteAllText(path, "");
            }
        }
        public List<Contacts> ReadAll()
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
        public void AddContact(int Id, string Name, string Email)
        {
            File.AppendAllLines(_path, line)
        }

    }
}
