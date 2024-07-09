
// Pętle do i while pozwalają wykonać szereg operacji do momentu spełnienia określonego warunku wyrażonego w postaci wyrażenia boolean
// Pętla do wykonuje operacje a następnie sprawdza warunek, natomiast pętla while najpierw sprawdza warunek a potem wykonuje operacje
// Należy pamiętać aby tworzyć warunki, które są spełnialne, aby nie stworzyć nieskończonej pętli (zwłaszcza unikać określania konkretnych wartości).

bool czyPoprawnyWiek;
int wiek;
string wiekTekst;

do // Wykonuje przynajmniej jeden raz kod
{
    Console.Write("Podaj swój wiek: ");
    wiekTekst = Console.ReadLine();
    czyPoprawnyWiek = int.TryParse(wiekTekst, out wiek);

    if (!czyPoprawnyWiek)
    {
        Console.WriteLine("Podany wiek jest niepoprawny. Wpisz wiek w postaci liczby!");
        
    }
    Console.WriteLine();

} while (!czyPoprawnyWiek);

while (wiek < 0 || !czyPoprawnyWiek) // Wykonuje kod 0 lub więcej razy
{
    if (!czyPoprawnyWiek)
    {
        Console.Write("Podany wiek jest niepoprawny. Wpisz wiek w postaci liczby: ");
    }
    else
    {
        Console.Write("Podałeś ujemny wiek, proszę popraw go: ");
    }
    wiekTekst = Console.ReadLine();
    czyPoprawnyWiek = int.TryParse(wiekTekst, out wiek);

    Console.WriteLine();
}

Console.WriteLine($"Twój wiek to: {wiek}");