using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHomework
{
    public static class KomendyKonsoli
    {
        //1. Stwórz metodę powitalną
        public static void Powitanie()
        {
            Console.WriteLine("Witaj w mojej aplikacji dotyczącej użycia metod w C#!");
            Console.WriteLine("-----------------------------------------------------");
        }
        
        //2.Stwórz metodę pytającą o imię użytkownika
        public static string PobierzDane()
        {
            Console.Write("Podaj proszę swoje imię: ");
            string wynik=Console.ReadLine();

            return wynik;
        }

        //3. Stwórz metodę wypisującą w konsoli: "Witaj <imie>""
        public static void Komunikat(string imie)
        {
            Console.WriteLine($"Witaj {imie}");
        }
        public static void Podziekowanie()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Dziękuję za skorzystanie z mojej aplikacji");
        }
    }
}
