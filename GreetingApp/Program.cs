
// 1. Powitanie użytkownika
Console.WriteLine("Dzień dobry! Witaj w aplikacji pozdrawiającej");
Console.WriteLine("Ta aplikacja została stworzona prze Mariusza Jaguścika");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine();

// 2. Zapytanie o imię
Console.Write("Jak masz na imię? ");
string? pierwszeImie = "";
pierwszeImie = Console.ReadLine();
Console.WriteLine();

// 3. Pozdrowienie użytkownika po imieniu
Console.WriteLine($"Cześć " + pierwszeImie);

Console.WriteLine("Dziękuję za skorzystanie z mojej aplikacji!");
Console.ReadLine();
