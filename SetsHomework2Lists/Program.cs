
//1.Powitanie
Console.WriteLine("Witaj w mojej aplikacji domowej dotyczącej wykorzystania list");
Console.WriteLine("-------------------------------------------------------------");

//2.Stwórz listę studentów
List<string> imiona = new List<string>();
List<string> nazwiska = new List<string>();
int indeks = 1;
string imie;
string nazwisko;
string koniec;

do
{
    //3. Zapytaj się o imię i nazwisko studenta
    Console.Write($"Podaj imię {indeks}. studenta: ");
    imie = Console.ReadLine();

    //- jeśli poda puste imię uznaj, zapytaj czy wszystkie osoby zostały już podane
    if (imie.Length!=0)
    {
        Console.Write($"Podaj nazwisko {indeks}. studenta: ");
        nazwisko = Console.ReadLine();
        imiona.Add(imie);
        nazwiska.Add(nazwisko);
        indeks++;
        Console.Clear();
        //4. Zapytaj się czy użytkownik chce zakończyć dodawanie nowych studentów
        Console.Write("Jeśli chcesz zakończyć dodawanie nowych studentów wpisz Tak: ");
        koniec = Console.ReadLine();
        Console.Clear();
    }
    else
    {
        Console.Clear();
        //4. Zapytaj się czy użytkownik chce zakończyć dodawanie nowych studentów
        Console.Write("Jeśli chcesz zakończyć dodawanie nowych studentów wpisz Tak: ");
        koniec = Console.ReadLine();
        Console.Clear();
    }
} while (koniec.ToLower() != "tak");

//5. Wyświetl liczbę studentów w grupie
Console.WriteLine($"Liczba wszystkich studentów w grupie to: {imiona.Count} studentów.");

//6. Podziękowanie
Console.WriteLine();
Console.WriteLine("Dziękuję za skorzystanie z mojej aplikacji");