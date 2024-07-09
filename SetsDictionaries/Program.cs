
// Słowniki pozwalają na tworzenie zbiorów danych z własnym zestawem kluczy (indeksów). 
// Każdy słownik składa się z dwóch zmiennych o określonych typach.
// Pierwsza z nich to klucz (musi być niepowtarzalny), oraz definicji

// Mogą to być np. liczba i ciąg (int i string):
Dictionary<int, string> pracownicy = new Dictionary<int, string>();
pracownicy[89] = "Tim Corey";
pracownicy[193] = "Mariusz Jaguścik";
pracownicy[222] = "Julia Chachała";
Console.WriteLine($"Pracownikiem miesiąca aktualnie jest: {pracownicy[193]}");
// Choć wydaje się to rozwiązaniem podobnym do list lub tablic, to tutaj klucze (indeksy) mogą mieć dowolną wartość (nie ciągłą).
Console.WriteLine();

// Słowniki mogą równie dobrze zawierać klucze w postaci ciągu znaków (stringa)
Dictionary<string, string> stworzenia = new Dictionary<string, string>();
stworzenia["zwierze"] = "nie człowieki";
stworzenia["ryba"] = "stworzenie żyjące w wodzie";
stworzenia["czlowiek"] = "człowieki";
Console.WriteLine($"Przykładem stworzeń żyjących w wodzie są ryby, czyli {stworzenia["ryba"]}");
Console.WriteLine();

// Równie dobrze słowniki mogą mieć ciągi znaków jako klucze oraz liczby jako definicje
Dictionary<string,int> dzienTygodnia = new Dictionary<string,int>();
dzienTygodnia["Środa"] = 3;
dzienTygodnia["Czwartek"] = 4;
dzienTygodnia["Piątek"] = 5;
Console.WriteLine($"Czwartek to {dzienTygodnia["Czwartek"]}. dzień tygodnia.");