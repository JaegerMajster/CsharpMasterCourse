
Console.WriteLine("Witaj w mojej aplikacji do pracy domowej z intrukcji warunkowych");
//1.Zapytać się imię użytkownika
Console.Write("Podaj prosze swoje imię: ");
string? pierwszeimie  = Console.ReadLine();
Console.WriteLine("--------------------------------");

//2. Wykorzystać podane imię użytkownika i w zależności od tego czy podał imię Tim, Timothy, czy inne odpowiednioe powitać:
Console.WriteLine("Z wykorzystaniem instrukcji warunkowej if:");
if (pierwszeimie.ToLower() == "tim" || pierwszeimie.ToLower() == "timothy")
//-Tim lub Timothy - "Witaj profesorku"
{
    Console.WriteLine("Witaj profesorku!");
}
//- inne - "Witaj młody padawanie"
else
{
    Console.WriteLine("Witaj młody padawanie!");
}
Console.WriteLine("--------------------------------");

//3. Do powyższego zadania wykorzystać również instrukcję warunkową switch
Console.WriteLine("Z wykorzystaniem instrukcji warunkowej switch:");
switch (pierwszeimie.ToLower())
{
    case "tim" or "timothy":
        Console.WriteLine("Witaj profesorku!");
        break;
    default:
        Console.WriteLine("Witaj młody padawanie!");
        break;
}