
// Listy są "nowocześniejszą" formą przechowywania zbioru danych, ponieważ w przeciwieństwie do tablic nie muszą mieć określonej wielkości
// Inicicjalizacja listy polega na wywołaniu zmiennej typu lista i stworzeniu pustej listy
List<string> pierwszeImiona = new List<string>();

// Dodawanie kolejnych elementów listy wykonuje się używając metody Add
pierwszeImiona.Add("Tim");
pierwszeImiona.Add("Mariusz");
pierwszeImiona.Add("Julia");
pierwszeImiona.Add("Konstanty");
pierwszeImiona.Add("Barak");

// Wypisanie elementu listy odbywa się identycznie jak w przypadku tablic, korzystając z indeksu (indeksy list także rozpoczynają się od 0)
Console.WriteLine($"Pierwsze imię z listy to: {pierwszeImiona[0]}");

// Do zmierzenia wielkości listy używa się metody Count,
// aby wyświetlić ostatni element należy od wielkości listy odjąć 1 aby uzyskać indekst ostatniego elementu listy.
Console.WriteLine($"Ostatnie imię z listy to: {pierwszeImiona[pierwszeImiona.Count - 1]}");

// Podobnie  jak w przypadku tablic, listy mogą przechowywać dane także innych typów.
List<int> wieki = new List<int>();
wieki.Add(41);
wieki.Add(44);
wieki.Add(18);
wieki.Add(21);
wieki.Add(35);

// List<T> - generic

// Podobnie jak w przypadku tablic, można stworzyć listę przez podział ciągu znaków (string), wykorzystując metodę Split().
// W przypadku list należy jednak dodatkowo użyć metody ToList().
string dane = "Corey,Nowak,Chrzan,Bolok";
List<string> nazwiska = dane.Split(',').ToList();
nazwiska.Add("Stanowski");

Console.WriteLine($"Pierwsza osoba z listy to: {pierwszeImiona[0]} {nazwiska[0]}");
Console.WriteLine($"Ostatnia osoba z listy to: {pierwszeImiona[pierwszeImiona.Count - 1]} {nazwiska[nazwiska.Count - 1]}");
