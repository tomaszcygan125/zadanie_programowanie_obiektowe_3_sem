using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab4
{
    public class Osoba
    {
        public string imie;
        public string nazwisko;
        public string Pesel;

        public void SetFirstName(string imie)
        {
            this.imie = imie;   
        }
        public void SetLasttName(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }
        public void SetPesel(string pesel)
        {
            this.Pesel = pesel;
        }
        public int GetAge()
        {
            int year = int.Parse(Pesel.Substring(0, 2));
            int month = int.Parse(Pesel.Substring(2, 2));
            int day = int.Parse(Pesel.Substring(4, 2));

            int century;

            if (month >= 1 && month <= 12)
                century = 1900;
            else if (month >= 21 && month <= 32)
            {
                century = 2000;
                month -= 20;
            }
            else if (month >= 41 && month <= 52)
            {
                century = 2100;
                month -= 40;
            }
            else if (month >= 61 && month <= 72)
            {
                century = 2200;
                month -= 60;
            }
            else if (month >= 81 && month <= 92)
            {
                century = 1800;
                month -= 80;
            }
            else
            {
                throw new Exception("Niepoprawny PESEL");
            }

            int fullYear = century + year;

            // Obliczenie wieku
            DateTime birthDate = new DateTime(fullYear, month, day);
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;


            return age;

        }
        public void GetEducationInfo()
        {
            Console.WriteLine($"imie: {imie} nazwisko {nazwisko}  pesel {Pesel}");
        }
        public void GetFullName()
        {
            Console.WriteLine($"imie: {imie} nazwisko: {nazwisko}");
        }
        public bool CanGoAloneToHome()
        {
            return true;
        }
        public string getGender()
        {

            int gender = int.Parse(Pesel.Substring(9, 1));
            if (gender %2 == 0)
            {
                return "k";
            }
            else
            {
                return "M";
            }


        }


    }
}
