
// Najcześtszym przypadkiem zamiany typów zmiennych jest zamiana stringa na liczbę, np, int:
Console.Write("Podaj swój wiek: ");
string? wiekTekst = Console.ReadLine();

// Dodanie liczby 15 do zmiennej typu string
Console.WriteLine(wiekTekst + 15);

// Konwersja zmiennej wiekTekst na int i dodanie do niej liczby 15
int wiek = int.Parse(wiekTekst);
Console.WriteLine(wiek + 15);

// Aby zabezpieczyć się przed konwersją nieprawidłowej wartości na inta można skorzystać z metody TryParse
bool isValidInt = int.TryParse(wiekTekst, out int wiek2);
Console.WriteLine($"Ta wartość jest poprawna: {isValidInt}, Podana liczba to: {wiek2}");

// Niektóre zmienne można konwertować przez proste przypisanie:
double testowyDouble = wiek;

// Niektóre zmienne trzeba konwertować przy użyciu castowania:
decimal testowyDecimal = (decimal)testowyDouble;

Console.WriteLine(testowyDouble);
Console.WriteLine(testowyDecimal);