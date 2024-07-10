
string imieTekst;
List<string> imiona = new();

//1. Powitanie
Console.WriteLine("Witaj w mojej aplikacji domowej dotyczącej użcia pętli foreach");
Console.WriteLine("--------------------------------------------------------------");

//2. Pytanie o imię w pętli (pozostaw puste aby zakończyć)
do
{
    Console.Write("Proszę podaj swoje imię (aby nie dodawać imienia i zakończyć dodawanie nowych imion kliknij Enter): ");
    imieTekst = Console.ReadLine();
    if (imieTekst != "")
    {
        imiona.Add(imieTekst);
    }
} while (imieTekst != "");

//3. Korzystając z pętli foreach przywitaj wszystkie wpisane osoby
Console.Clear();
foreach (var imie in imiona)
{
    Console.WriteLine($"Cześć {imie}!");
}

//4. Podziękowanie
Console.WriteLine();
Console.WriteLine("Dziękuję za skorzystanie  z mojej aplikacji!");