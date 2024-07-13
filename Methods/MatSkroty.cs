using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class MatSkroty
    {
        public static void Suma(double x, double y)
        {
            // Dane można wyrzucać bezpośrednio na ekran wewnątrz metody
            Console.WriteLine($"Wynikiem dodawania {x} i {y} jest {x + y}");
        }

        public static double Roznica(double x, double y)
        {
            // Jeśli operacja jest prosta można ją zwrócić bezpośrednio w komendzie return:
            // return x - y;

            // Warto jednak korzystać z rozdzielenia wartości obliczanej od samego zwracania ponieważ z reguły metody są bardziej skomplikowane
            double wynik = x - y;
            return wynik;
        }

        public static void SumaWszystkich(double[] wartosci)
        {
            // Do metody można przekazać także tablice, listy czy słowniki, na których można potem wykonywać odpowiednie operacje
            // W przypadku tablicy, przy tworzeniu metody, nie trzeba ograniczać jej wielkości.
            double wynik = 0;

            // wartosci.Sum(); - pozwala zsumować wszystkie wartości z tablicy

            foreach (double liczba in wartosci)
            {
                wynik += liczba;
            }

            Console.WriteLine($"Wynikiem dodawania wszystkich elementów będzie {wynik}");
        }
    }
}
