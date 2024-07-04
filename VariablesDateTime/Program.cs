
// Konieczne dodanie biblioteki Globalization do wskazania parametru CulutreInfo przy podawaniu daty według wzorca
using System.Globalization;
// Typ zmiennej DateTime przechowuje dane dotyczące daty i czasu

// Data i czas przedstawiane są zgodnie z ustawieniami systemu na którym program został uruchomiony

// Inicjalizacja zmiennej przechowującej datę i czas z chwili jej wywołania
DateTime dzisiaj = DateTime.Now;

// Inicjalizacja zmiennej przechowującej uniwersalną datę i czas z chwili jej wywołania
DateTime dzisiajUTC = DateTime.UtcNow;

Console.WriteLine($"Dzisiejsza data w Polsce: {dzisiaj}");
Console.WriteLine($"Dzisiejsza data zgodna z uniwersalnym czasem (UTC): {dzisiajUTC}");

// Formatowanie daty i czasu odbywa się za pomocą metody ToString z parametrem format o odpowiedniej wartości:
Console.WriteLine($"Dzisiejsza data w formacie skróconym: {dzisiaj.ToString(format:"d")}"); // wyświetla samą skróconą datę
Console.WriteLine($"Dzisiejsza data w pełnym formacie: {dzisiaj.ToString(format: "d MMMM yyyy, H:mm")}"); // wyświetla pełną datę oraz godzinę według określonego wzorca

// Podanie konkretnej daty wymaga skorzystania z metody Parse z parametrem s:
DateTime urodziny = DateTime.Parse(s: "5/8/1980");
Console.WriteLine($"Data urodzin: {urodziny}");

// Podanie daty według konkretnego wzorca (np. amerykańskiego) wymaga skorzystania z metody ParseExact, podania wzorca
// i wywołania parametru CultureInfo co wymaga dodatkowo dodania biblioteki Globalization
DateTime jakasData = DateTime.ParseExact("12/2/1998","M/d/yyyy", CultureInfo.InvariantCulture);
Console.WriteLine($"Data: {jakasData}");