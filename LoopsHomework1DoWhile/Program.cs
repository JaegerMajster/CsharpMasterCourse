
//1.Powitanie
Console.WriteLine("Witaj w moje aplikacji domowej dotyczącej użycia pętli");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine();
string pierwszeImie;

do
{
    //2.Zapytanie o imię
    Console.Write("Podaj swoje imię (lub wpisz exit aby zakończyć działanie programu: ");
    pierwszeImie = Console.ReadLine();
    //3. Sprawdzenie czy podane zostało imię Tim
    if (pierwszeImie.ToLower() == "tim")
    //- jeśli tak to powitanie jako profesora i powrót do punktu 2.
    {
        Console.WriteLine($"Witaj Profesorze {pierwszeImie}!");
        Console.ReadKey();
        Console.Clear();
    }
    //- jeśli nie to powitanie jako studenta i powrót do punktu 2.
    else if (pierwszeImie.ToLower() == "exit")
    {
        //4. Podziękowanie i zakońćzenie aplikacji
        Console.WriteLine("Dziękuję za skorzystanie z mojej aplikacji!");
    }
    else
    {
        Console.WriteLine($"Witaj Studencie {pierwszeImie}!");
        Console.ReadKey();
        Console.Clear();
    }
}
//- jeśli wpisano exit to wyjście z pętli
while (pierwszeImie.ToLower() != "exit");





