
using System.Linq;

Dictionary<int,string> pracownicy = new Dictionary<int,string>();
int indeks = 0;
string danePracownika;
string koniec;
int idPracownika;
bool czyPoprawnyId;

//1.Powitanie
Console.WriteLine("Witaj w mojej aplikacji domowej dotyczącej słowników");
Console.WriteLine("----------------------------------------------------");

Console.WriteLine();
Console.WriteLine("Wprowadzanie danych pracowników:");

//2.Pętla do dodawania pracowników do słownika zawierającego klucz(ID) oraz definicję(imię i nazwisko)
do
{
    indeks++;
    Console.Write("Podaj imię i nazwisko pracownika: ");
    pracownicy[indeks] = Console.ReadLine();
    //3.Zapytanie czy przerwać wpisywanie pracowników
    Console.Write("Czy chcesz zakończyć dodawanie pracowników? (Wpisz Tak aby zakończyć): ");
    koniec = Console.ReadLine();
    if (koniec.ToLower() == "tak")
    {
        Console.Clear();
    }
} while (koniec.ToLower() != "tak");

//4. Prośba o podanie numeru ID użytkownika
do
{
    Console.Write($"Podaj swój numer ID (1 - {pracownicy.Count}): ");
    czyPoprawnyId = int.TryParse(Console.ReadLine(), out idPracownika);
    if (czyPoprawnyId)
    {
        if (idPracownika >= 1 && idPracownika <= pracownicy.Count)
        {
            //5. Wyświetlenie jego danych
            Console.Clear();
            Console.WriteLine($"Twoje imię i nazwisko: {pracownicy[idPracownika]}");
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"Podano nieprawidłowy nr ID (ID musi być z zakresu od 1 do {pracownicy.Count})");
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"Podano nieprawidłowy nr ID (numer ID musi być liczbą)");
    }
} while (!czyPoprawnyId || idPracownika < 1 || idPracownika > pracownicy.Count);

//6. Podziękowanie
Console.WriteLine();
Console.WriteLine("Dziękuję za użycie mojej aplikacji");