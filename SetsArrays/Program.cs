
// Tablice zawierają wiele wartości określonego typu
// Indeks tablic zaczyna się od liczby 0
// Nie można podawać indeksu spoza zakresu, ponieważ wyrzuci to błąd "out of range"

string[] pierwszeImiona = new string[5];

pierwszeImiona[0] = "Tim";
pierwszeImiona[1] = "Mariusz";
pierwszeImiona[2] = "Kacper";
pierwszeImiona[3] = "Monika";
pierwszeImiona[4] = "Julia";

Console.WriteLine($"Pierwsze imiona w tablicy to: {pierwszeImiona[0]}, {pierwszeImiona[1]}, {pierwszeImiona[2]}, {pierwszeImiona[3]}, {pierwszeImiona[4]}");

pierwszeImiona[0] = "Timothy";
Console.WriteLine($"Aktualnie pierwsze imię brzmi: {pierwszeImiona[0]}");

// do dzielenia stringó na zestaw danych służy metoda Split
// apostrofy służą do identyfikacji znaku (char)
// cudzysłowy służą do identyfikacji ciąfu znaków (string)

string dane = "Correy,Kowalski,Nowak,Łobuziak,Chmielewska";
string[] nazwiska = dane.Split(',');

Console.WriteLine($"Pierwsza osoba: {pierwszeImiona[0]} {nazwiska[0]}");

// do sprawdzenia wielkości tablicy służy parametr Length
Console.WriteLine($"Długość tablicy to: {pierwszeImiona.Length}");
Console.WriteLine($"Ostatnia osoba: {pierwszeImiona[pierwszeImiona.Length - 1]} {nazwiska[nazwiska.Length - 1]}");

// inne przykłady inicjowania tablic:
string[] stanowiska = new string[] { "Kowal losu", "Sekretarz generalny", "Wiatrowy", "Kolarka", "Super Woman" };
int[] wieki = new int[] { 44, 32, 23, 32, 18 };