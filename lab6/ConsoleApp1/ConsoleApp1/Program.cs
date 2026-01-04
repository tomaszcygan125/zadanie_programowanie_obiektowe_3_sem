// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
TxtContactRepository repo = new TxtContactRepository("txtfile.txt");
//Contacts c = new Contacts(1, "tomasz", "cygan");
//repo.AddContact(c);


JsonContactRepository repojson = new JsonContactRepository("jsonfile.json");

repojson.AddContact(new Contacts(1, "marcin nowak", "m.nowak@interia.pl"));
repojson.AddContact(new Contacts(2, "marcin nowak2", "m.nowak@interia.pl"));
repojson.AddContact(new Contacts(3, "marcin nowak3", "m.nowak@interia.pl"));
repojson.ReadAll();