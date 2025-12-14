using System.ComponentModel;
using System.Diagnostics;

namespace ConsoleApp1
{
    public enum Operacje
    {
        dodawanie,
        odejmowanie,
        mnozenie,
        dzielenie
    }
    public enum StatusZamowienia { 
        oczekujace,
        przyjete,
        zrealizowane,
        anulowane

    
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            //KalkulatorZad1();
            SklepZad2();

        }
        public static void KalkulatorZad1() {
            bool continueLoop = true;
            string choice = "x";
            Console.WriteLine("welcome");
            double l1 = 0;
            double l2 = 0;
            int operation_choice;
            Operacje op;
            List<double> previous_operations = new List<double>();

            try
            {
                while (continueLoop)
                {
                    Console.WriteLine("Podaj czy chccesz kontynuwowac 'x' to continue");
                    choice = Console.ReadLine();
                    if (choice == "x")
                    {
                        Console.WriteLine("podaj l1: ");
                        double.TryParse(Console.ReadLine(), out l1);
                        Console.WriteLine("podaj l2: ");
                        double.TryParse(Console.ReadLine(), out l2);
                        wyswietloperacje();
                        Console.WriteLine("podaj swoj wybor");

                        // proba sparsowania warosci podanej przez usera do enum OPERACJE
                        Enum.TryParse<Operacje>(Console.ReadLine(), out op);
                        var result = PerfromOperation(l1, l2, op);
                        int wynik = result.ReturnCode;
                        if (wynik == 0)
                        {

                            Console.WriteLine($"wynik to : {result.Wynik} ");
                            // jezeli wynik jest poprawny zapisz go w liscie 
                            previous_operations.Add(result.Wynik);
                        }
                        else
                        {
                            Console.WriteLine("wystapil blad");
                        }

                    }
                    else
                    {
                        continueLoop = false;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Niepoprawny format danych!!");
            }
            catch (Exception)
            {

                Console.WriteLine("unexpected error");
            }
        };
        public static void wyswietloperacje()
        {
            Console.WriteLine("0. dodawanie");
            Console.WriteLine("1. odejmowanie");
            Console.WriteLine("2. mnozenie");
            Console.WriteLine("3. dzielenie");
        }
        // zwraca return code oraz wynik
        public static (int ReturnCode, double Wynik ) PerfromOperation(double l1, double l2, Operacje operation_choice)
        {

            Console.WriteLine($"l1: {l1} l2: {l2} operacja: {operation_choice}");
            try
            {


                switch (operation_choice)
                {
                    case Operacje.dodawanie:
                        Console.WriteLine("dodawanie");
                        return (0, l1 + l2);
                        break;
                    case Operacje.odejmowanie:
                        Console.WriteLine("odejmowanie");
                        return (0, l1 - l2);
                        break;
                    case Operacje.mnozenie:
                        Console.WriteLine("mnozenie");
                        return (0, l1 * l2);
                        break;
                    case Operacje.dzielenie:
                        Console.WriteLine("dzielenie");
                        if (l2 == 0)
                        {
                            throw new DivideByZeroException("Nie dziel przez zero");
                        }
                        return (0, l1 / l2);
                        break;
                    default:
                        throw new Exception("Wybrano złą opcje");
                        break;
                    
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nie mozna dzielic przez zero");
            }
            // w przypadku gdy w tym momencie nie nastąpiło przekazanie controli do wołającego procesu 
            // oznacza to blad;
            return (9, 0); // blad 
        }
        public static Dictionary<int, List<string> > ListaZamowien = new Dictionary<int, List<string>>();
        public static List<int, StatusZamowienia> Status_lista = new List<int, StatusZamowienia>;
        public static void SklepZad2()
        {
            
            dodaj_zamowienia();
        }
        public static void dodaj_zamowienia()
        {
            // dodanie 10 
            for(int i = 0; i < 10; i++) 
            {
                ListaZamowien.Add(i, new List<string> { "jajka" , "mleko" , "ser" });
            }
        }
    }
    
}

