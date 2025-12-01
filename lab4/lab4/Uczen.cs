using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    internal class Uczen :Osoba
    {
        public string Szkola;
        public bool MozeSamWracacDoDomu;
        public bool Pozwolenie;
        public void SetSchool(string school)
        {
            this.Szkola = school;
        }
        public void ChangeSchool(string school)
        {
            this.Szkola = school;
        }

        public void SetCanGoHomeAlone(bool MozeSamWracacDoDomu)
        {
            this.MozeSamWracacDoDomu = MozeSamWracacDoDomu;
        }
        public new bool CanGoAloneToHome()
        {
            int wiek = GetAge();
            if (wiek > 12 || Pozwolenie)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
