//1.Powitanie
Console.WriteLine("Witaj w mojej aplikacji StudentCheck");

//2.Zapytanie o imię
Console.Write("Podaj proszę swoje imię: ");
string? pierwszeImie = Console.ReadLine();

//3. Zapytanie o wiek
Console.Write("Podaj proszę swój wiek: ");
int? wiek = int.Parse(Console.ReadLine());
Console.WriteLine("--------------------------");

//4. Sprawdzenie wieku
if (wiek < 21)
{
    //	- jeżeli poniżej 21 roku życia to
    //		- oblicz różnicę (X) do 21 lat 
    //	    - poleć poczekać jeszcze X lat przed rozpoczęciem kursu
    Console.WriteLine($"{pierwszeImie} jesteś jeszcze za młody(/a), masz jeszcze czas! Poczekaj {21 - wiek} lat zanim przystąpisz do tego kursu");
}
else//	- jeżeli 21 lat lub więcej
{
    //	- sprawdź czy na imię ma Sue lub Bob
    if (pierwszeImie.ToLower() == "bob" || pierwszeImie.ToLower() == "sue")
    {
        //	- jeśli tak to przywitaj profesora
        Console.WriteLine($"Witaj Profesorku {pierwszeImie}!!!");
    }
    else
    {
        //	- jeśli nie to przywitaj po imieniu
        Console.WriteLine($"Witaj Studencie {pierwszeImie}");
    }
}
Console.WriteLine("--------------------------");

//5. Podziękowanie i zamknięcie aplikacji
Console.WriteLine("Dziękuję za skorzystanie z mojej aplikacji. Polecam się na przyszłość!");