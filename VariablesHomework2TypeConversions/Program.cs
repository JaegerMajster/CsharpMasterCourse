
// 1.Przywitanie
Console.WriteLine("Witaj w moim programie dotyczącym pracy domowej nr 2");

// 2.Zapytanie o wiek użytkownika
Console.Write("Podaj proszę swój aktualny wiek: ");
int aktualnyWiek = int.Parse(Console.ReadLine());
Console.WriteLine("-------------------------------------");

// 3. Obliczenie wieku za 25 lat
int wiekPozniej = aktualnyWiek + 25;

// 4. Obliczenie wieku sprzed 25 lat
int wiekWczesniej = aktualnyWiek - 25;

// 5. Wypisanie wszystkich danych w konsoli
Console.WriteLine($"Twój aktualny wiek to: {aktualnyWiek} lat");
Console.WriteLine($"Za 25 lat będziesz miał: {wiekPozniej} lat");
Console.WriteLine($"25 lat temu miałeś/aś: {wiekWczesniej} lat");