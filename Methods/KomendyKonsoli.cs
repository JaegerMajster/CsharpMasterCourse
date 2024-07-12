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
        // void - ten parametr decyduje, cz metoda ma zwracać jakieś czy nie (void oznacza, brak zwracania jakichkolwiek danych)
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
        public static void Zegnaj(string pierwszeImie)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Żegnaj {pierwszeImie}.");
            Console.WriteLine("Miło było Cię znać,");
            Console.WriteLine("A teraz won!");
        }
    }
}
