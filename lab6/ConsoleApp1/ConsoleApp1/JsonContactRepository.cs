using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace ConsoleApp1
{
    internal class JsonContactRepository
    {
        private string _path;
        public JsonContactRepository(string path)
        {
            _path = path;
            CheckFileExists(_path);
        }
        private void CheckFileExists(string path)
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, ";;");
            }
        }
        public void ReadAll()
        {
            string JsonFile = File.ReadAllText(_path);
            var contacts = JsonSerializer.Deserialize<List<Contacts>>(JsonFile);

            foreach (Contacts c in contacts)
            {
                c.Display();
            }
        }
        public void AddContact(Contacts contact)
        {
            var contacts = new List<Contacts>();
            if (!File.Exists(_path))
            {
                contacts = new List<Contacts>();
            }
            else
            {
                var json = File.ReadAllText(_path);

                if (string.IsNullOrWhiteSpace(json))
                {
                    contacts = new List<Contacts>();
                }
                else
                {
                    contacts = JsonSerializer.Deserialize<List<Contacts>>(json)
                               ?? new List<Contacts>();
                }
            }
        
            

            contacts.Add(contact);
            
            var updatedJson = JsonSerializer.Serialize(contacts);
            File.WriteAllText(_path, updatedJson);

        }

    }
}
