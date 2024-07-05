
// Instrukcja warunkowa switch pozwala na dobieranie zestawu instrukcji w zależności o wartości badanej zmiennej
Console.Write("Podaj proszę swoje imię: ");
string? pierwszeImie = Console.ReadLine();
Console.Write("Podaj proszę swój wiek: ");
int? wiek = int.Parse(Console.ReadLine());

switch (pierwszeImie.ToLower())
{
    case "mariusz" or "tim": // W porównaniu przypadku można używać operatorów logicznych, ale trzeba pamiętać o ich efekcie
        Console.WriteLine("Witam profesorku");
        break;
    case "tom":
        Console.WriteLine("Witaj Tom");
        break;
    default: // default to koszyka zawierający wszystkie nie wymienione wyżej możliwości
        Console.WriteLine("Nie znam Cię");
        break;
}

switch (wiek)
{
    case >= 0 and < 18: // operator logiczny AND nadaje się doskonale do określania przedziałów
        Console.WriteLine("Jesteś gówniarzem");
        break;
    case >= 18 and < 65:
        Console.WriteLine("Czas do roboty");
        break;
    case >= 66:
        Console.WriteLine("Już za późno na robotę");
        break;
    default :
        Console.WriteLine("Wiek nie został poprawnie zdefiniowany");
        break;
}