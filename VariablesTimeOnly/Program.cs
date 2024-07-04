
// Podobnie jak DateOnly tak TimeOnly przechowuje jedynie wskazaną godzinę
DateTime dzien = DateTime.Parse(s: "12/05/1998 14:00");
TimeOnly godzina = TimeOnly.FromDateTime(dzien);

Console.WriteLine(dzien);
Console.WriteLine(godzina);