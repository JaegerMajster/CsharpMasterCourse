using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class KomendyKonsoli
    {
        // Deklaracja metody składa się z kilku elementów
        // public - to określenie dostępu do klasy
        // static - pozwala uruchamiać metody bezpośrednio w konsoli
        // void - ten parametr decyduje, cz metoda ma zwracać jakieś czy nie (void oznacza, brak zwracania jakichkolwiek danych, typ danych określa typ zwracanych danych)
        // PowiedzCzesc - nazwa metody - wykorzytywana do odwołania się do metody. Nazwa powinna być samowyjaśnialna, czyli jasno wskazywać co dana metoda robi
        // () - parametry metody, najczęściej dane przekazywane z zewnątrz do środka metody
        // {} - wewnątrz nawiasów znajdują się wszystkie instrukcje, które mają zostać wykonane po odwołaniu się do danej metody

        // Do metody można dodawać dowolne parametry, które przekazywane są z zewnątrz. Należy je zadeklarować przy tworzeniu metody, wraz z typem danych.
        public static void PowiedzCzesc(string pierwszeImie)
        {
            Console.WriteLine($"Siema {pierwszeImie}!");
            Console.WriteLine("Miło Cię poznać!");
            Console.WriteLine("-----------------------");
        }

        public static string PobierzNazweUzytkownika()
        {
            // Metoda może również zwrócić w wyniku swojego działania jakąś wartość, należy jednak pamiętać, aby przy jej deklaracji podać typ zwracanej wartości
            Console.Write("Jak masz na imię: ");
            string dane = Console.ReadLine();
            
            return dane;
        }

        public static (string pierwszeImie, string nazwisko) PobierzPelneDaneUzytkownika()
        {
            // Metoda może także zwrócić wiele wartości w postaci tupli
            // Należy wtedy zadeklarować metodę podając tuplę wraz z typami danych jakie będzie zawierała
            // oraz zwrócić tuplę podając odpowiednie wartości.

            Console.Write("Podaj swoje imie: ");
            string imie = Console.ReadLine();

            Console.Write("Podaj swoje nazwisko: ");
            string nazwisko = Console.ReadLine();

            return (imie, nazwisko);
        }
        public static void Zegnaj(string pierwszeImie)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Żegnaj {pierwszeImie}.");
            Console.WriteLine("Miło było Cię znać,");
            Console.WriteLine("A teraz won!");
        }
    }
}
