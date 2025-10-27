using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    /// <summary>

    /// Klasa która zaweira zestaw metod do zadań z lab 1.

    /// </summary>

    /// <remarks>

    /// Autor: Jan Kowalski

    /// data: 12.10.2025

    /// versia: 1.0

    /// Śreodwiska: net9.0

    /// </remarks>

    internal class Task_lab_1

    {



        private readonly Random _rng = new Random();



        /// <summary>

        /// Zadanie 1: Wyzanczanie pierwiastkó równanai kwadratowego

        /// </summary>

        /// <remarks>Wyniki wyśweitlane są na konsoli</remarks>

        private void Zadanie1()

        {
            double x1, x2, delta;

            Console.WriteLine("Podaj wartość a:");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj wartość b:");

            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj wartość c:");

            double c = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                delta = (b * b) - (4 * a * c);
                if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine($"Dwa rozwiązania x1 = {x1:F2} \t x2 = {x2:F2}");

                    Console.WriteLine("Dwa rozwiązania x1 = " + x1 + "\t x2 = " + x2);
                }
                else if (delta == 0)
                {
                    x1 = (-b) / (2 * a);
                    Console.WriteLine($"Jedno rozwiązanie x1 = {x1:F2}");
                }

                else Console.WriteLine("Brak rozwiązania w zbiorze liczb rzeczywistych");

            }
            else
                Console.WriteLine("To nie jest rówananie kwadratowe");
        }

        public void Run()

        {
            bool should_continue = true;

            while (should_continue)
            {
                Console.WriteLine("Podaj wybor zadania <1-5> 6 to exit");
                if (int.TryParse(Console.ReadLine(), out int wybor))
                {
                    switch (wybor)
                    {
                        case 1:
                            Zadanie1();
                            break;
                        case 2:
                            Zadanie2();
                            break;
                        case 3:
                            Zadanie3();
                            break;
                        case 4:
                            Zadanie4();
                            break;
                        case 5:
                            Zadanie5();
                            break;
                        case 6:
                            Console.WriteLine("koniec programu");
                            should_continue = false;
                            break;

                        default:
                            Console.WriteLine("Zly wyobr");
                            break;

                    }
                }
                else
                {

                }
            }

        }

        private void Zadanie2()

        {
            Console.Write("Podaj liczbę elementów (n): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Błędna wartość n.");
                return;
            }

            Console.Write("Podaj dolną granicę przedziału (min): ");

            if (!double.TryParse(Console.ReadLine(), out double min))
            {
                Console.WriteLine("Błędna wartość min.");
                return;
            }

            Console.Write("Podaj górną granicę przedziału (max): ");

            if (!double.TryParse(Console.ReadLine(), out double max))
            {
                Console.WriteLine("Błędna wartość max.");
                return;
            }
            if (min > max)
            {
                (min, max) = (max, min);

                Console.WriteLine($"Uwaga: zamieniono granice. Nowy przedział: [{min}, {max}].");

            }



            double[] liczby = LosujTabliceDouble(n, min, max);


        }// koniec zadania 2

        /// <summary>
        /// Print number from 20 to 0 without {2,6,9,15,19}
        /// </summary>
        private void Zadanie3()
        {
            int[] values = { 2, 6, 9, 15, 19 };
            for (int i = 20; i >= 0; i--)
            {

                if (values.Contains(i))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"I: {i}");
                }
            }
        }
        /// <summary>
        /// infinite loop that ask user for int, loop breaks when user provides value which is less than zero
        /// </summary>
        private void Zadanie4()
        {
            while (true)
            {
                Console.WriteLine("podaj liczbe calkowitą: ");
                if (int.TryParse(Console.ReadLine(), out int user_input))
                {
                    if (user_input < 0)
                    {
                        Console.WriteLine("podano liczbe mniejsza od zera");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("cos poszlo nie tak sproboj ponownie.");
                }
            }

        }
        private void Zadanie5()
        {
            Console.WriteLine("podaj ile liczb chcesz posortowac: ");
            int ilosc = Convert.ToInt32(Console.ReadLine());
            int[] super_tabelka = new int[ilosc];
            if (ilosc > 1)
            {

                for (int i = 0; i < ilosc; i++)
                {
                    Console.WriteLine($"Podaj {i + 1} liczbe: ");
                    super_tabelka[i] = Convert.ToInt32(Console.ReadLine());
                }

                if (InsertionSort(super_tabelka) != null)
                {

                    Console.WriteLine("printuje posortowaną");

                    foreach (int i in super_tabelka)
                    {
                        Console.WriteLine($"i: {i}");
                    }
                }
                else
                {
                    Console.WriteLine("nie udalo sie posortowac ");
                }


            }
            else
            {
                Console.WriteLine("Nie o to chodzi w tej zabaie :-(");
            }

        }
        private double LosujLiczbeOdUzytkownika()

        {

            Console.Write("Podaj dolną granicę przedziału (min): ");

            double min = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj górną granicę przedziału (max): ");

            double max = Convert.ToDouble(Console.ReadLine());

            if (min > max)
            {
                double temp = min;
                min = max;
                max = temp;
                Console.WriteLine($"Zamieniono granice. Nowy przedział: [{min}, {max}]");
            }

            Random rng = new Random();
            double wynik = min + rng.NextDouble() * (max - min);
            Console.WriteLine($"Wylosowana liczba: {wynik:F2}");
            return wynik;

        }

        private double[] LosujTabliceDouble(int n, double min, double max)

        {

            double[] arr = new double[n];
            double zakres = max - min;

            for (int i = 0; i < n; i++)

                arr[i] = min + _rng.NextDouble() * zakres; // NextDouble() -> [0,1)
            return arr;

        }
        private int[] InsertionSort(int[] tabelka)
        {
            int rozmiar = tabelka.Length;

            if (rozmiar > 1)
            {
                for (int i = 1; i < tabelka.Length; i++)
                {
                    int a = tabelka[i];
                    int j = i - 1;
                    while (j >= 0 && tabelka[j] > a)
                    {
                        tabelka[j + 1] = tabelka[j];
                        j--;
                    }
                    tabelka[j + 1] = a;
                }
                return tabelka;
            }
            else
            {
                Console.WriteLine("nie udalo sie posortowac");
                return null;
            }
        }

    }

}




