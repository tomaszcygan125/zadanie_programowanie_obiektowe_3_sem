using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public class Nauczyciel :Osoba
    {
        string TytulNaukowy { get; set; } 
        List<Uczen> Podwladni_uczniowie = new List<Uczen>();
        public void WhichStudenCanGoHomeALone(DateTime dateTocheck)
        {
            foreach (Uczen u in Podwladni_uczniowie)
            {
                if (u.Pozwolenie || u.CanGoAloneToHome())
                {
                    u.GetEducationInfo();
                }
            }
        }
    }
}
