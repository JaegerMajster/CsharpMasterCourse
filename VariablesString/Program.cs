
// inicjowanie pustej zmiennej
string pierwszeImie = string.Empty;

// inicjowanie zmiennej zawierającej 0 znaków
string nazwisko = "";

// inicjowanie pustej zmiennej - niezalecane
string sciezkaPliku;

// można zmienić nazwę zmiennej a następnie kliknąć na klawiaturze ctrl + . aby zmienić nazwę we wszystkich miejscach w kodzie, gdzie została użyta

pierwszeImie = "Mariusz";
nazwisko = "Jaguścik";

// W przypadku przypisywania do zmiennej string znaku \ należy dodać do niego jeszcze jeden znak \, np:
sciezkaPliku = "C:\\Temp\\Demo";
// albo użyć znaku @ przed wartością stringa:
sciezkaPliku = @"C:\Temp\Demo";

// Mozna wykorzystywać zarówno notacji literalnej jak i interpolacji w stringach:
string testowy = $@"Pliki znajdujące się w lokaliacji C:\SampleFiles należą do użytkownika o imieniu {pierwszeImie}";

// Różne sposoby wypisania kilku zmiennych typu string:
// Przy użyciu dodawania stringów:
Console.WriteLine(pierwszeImie + " " + nazwisko);

// Przy użyciu interpolacji stringów:
Console.WriteLine($"{pierwszeImie} {nazwisko} Ścieżka do plików: {sciezkaPliku}");
