
// Podstawowa instrukcja warunkowa wymaga sprawdzenia warunku, którego wynikiem bedzie wartość boolean
// Zatem można zamiast warunku wstawić jako argument dowolną wartość boolean, np.:
bool czyKompletny = true;

// Po sprawdzeniu w
if (czyKompletny)
{
    // Po sprawdzeniu warunku w przypadku wyniku: prawda, wykonane zostaną wszystkie instrukcje zawarte pomiędzy nawiasami {}
    Console.WriteLine("Wartość wynosi: prawda");
    Console.WriteLine("Wyświetla się tylko i wyłącznie gdy prawda.");
}
else // Mozna (nie trzeba) dodać także instrukcje do wykonania w przypadku gdy warunek będzie miał wynik fałsz przy użyciu słowa else
{
    // Po sprawdzeniu warunku w przypadku wyniku: fałsz, wykonane zostaną wszystkie instrukcje zawarte pomiędzy nawiasami {}
    Console.WriteLine("Wartość wynosi: fałsz");
    Console.WriteLine("Wyświetla się tylko i wyłącznie gdy fałsz.");
}

Console.WriteLine();

// Jeśli w wyniku sprawdzenie warunku wykonana zostanie tylko i wyłącznie 1 instrukcja to można pominąć nawiasy {}:
if (czyKompletny)
    Console.WriteLine("Wartość wynosi: prawdziwa prawda");
else
    Console.WriteLine("Wartość wynosi: fałszywy fałsz");

Console.WriteLine( );

// Bardziej praktycznym sposobem wykorzystania warunków jest jednak porównanie dwóch wartości, np. zmiennej i jakiejś wartości:
Console.Write("Podaj swoje pierwsze imię: ");
string? pierwszeImie = Console.ReadLine();

if (pierwszeImie.ToLower() == "mariusz") // warto pamiętać o różnych sytuacjach w przypadku sprawdzania warunków np. o niepoprawnych danych wejściowych
{
    Console.WriteLine("Dzień dobry Panie Mariuszu!");
    string? nazwisko = "Jaguścik"; // Uwaga deklaracja zmiennej wewnątrz warunku spowoduje, że będzie ona NIEDOSTĘPNA poza warunkiem!
}
else
{
    Console.WriteLine($"Dzień dobry {pierwszeImie}!");
}


Console.WriteLine("Koniec programu");