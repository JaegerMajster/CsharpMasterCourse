
//1.Powitanie
Console.WriteLine("Witaj w mojej aplikacji domowej dotyczącej użycia tablic.");
Console.WriteLine("---------------------------------------------------------");

//2.Stworzenie tablicy z 3 imionami
string[] pierwszeImiona = new string[] { "Mariusz", "Zenobiusz", "Pankracy" };
bool czyPoprawnyIndeks;
int indeks;

//3. Zapytanie o liczbę
Console.Write("Podaj proszę liczbę od 1 do 3: ");
czyPoprawnyIndeks = int.TryParse(Console.ReadLine(), out indeks);

do
{
    if (!czyPoprawnyIndeks)
    {
        //- jeśli poda nieprawidłową liczbę (znaki) - poproś ponownie o podanie liczby
        Console.Clear();
        Console.Write("Podano niepoprawną liczbę. Wpisz liczbę od 1 do 3: ");
        czyPoprawnyIndeks = int.TryParse(Console.ReadLine(), out indeks);
    }
    else if (indeks < 1 || indeks > 3)
    {
        //- jeśli poda liczbę spoza zakresu poproś ponownie o podanie liczby
        Console.Clear();
        Console.Write("Podano liczbę spoza zakresu (1 - 3), podaj proszę poprawną liczbę: ");
        czyPoprawnyIndeks = int.TryParse(Console.ReadLine(), out indeks);
    }
    
    if (czyPoprawnyIndeks && indeks >=1 && indeks <= 3)
    {
        //- jeśli poda właściwą liczbę - wypisanie imienia
        Console.WriteLine();
        Console.WriteLine($"Wybrane imię to {pierwszeImiona[indeks-1]}!");
    }
} while (!czyPoprawnyIndeks || indeks <1 || indeks >3);

//4. Podziękowanie
Console.WriteLine();
Console.WriteLine("Dziękuję za skorzystanie z mojej aplikacji!");