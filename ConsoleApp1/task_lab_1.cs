using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1
{
    /// <summary>
    /// Klasa ktora zawiera zestaw metod do zadan z lab 1. 
    /// </summary>
    /// 
    /// <remarks>
    /// Autor: Tomasz Cygan
    /// version: 1.0
    /// Environment 
    /// </remarks>s
    internal class task_lab_1
    {
            /// <summary>
            /// zadanie 1 wyznaczanie pierwsiastkow rownania kwadratowego
            /// </summary>            
            /// <remarks> wyniki wyswietlane sa na konsoli</remarks>
        private void Zadanie1()
        {
            double a, b, c, delta,x1,x2;
            Console.WriteLine("Podaj wartosc a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wartosc b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wartosc c: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"podane wartosci: {a} , {b}, {c} ");

            if (a != 0)
            {
                delta = (b * b) - (4 * a * c);
                if (delta> 0)
                {
                    x1 = (-b - Math.Sqrt(delta)/(a*2));
                    x2 = (-b + Math.Sqrt(delta) / (a * 2));
                    Console.WriteLine($"x1: {x1:F2}  , x2: {x2:F2}");
                }
                else
                {
                    if (delta == 0)
                    {
                        x1 = (-b / (a * 2));
                        Console.WriteLine($"wartosc x0: {x0:F2");
                    }
                }
            }
           

        }
        

    }
}
