
// Metody to zbiory operacji które można wykonać odwołując się do nazwy metody
// Metody powinno się tworzyć w oddzielnym pliku z klasą (patrz plik z klasą KomendyKonsoli)
// W głównym programie powinno się jedynie wywoływać klasy, tak aby nie zaciemniać jego treści

// Aby móc skorzystać z metod zapisanych w danej bibliotece, bez podawania pełnej ścieżki przy wywołaniu metody trzeba na początku pliku
// zadeklarować użycie tej biblioteki. Wtedy można wywołać metodę jedynie przez powołanie się na nazwę klasy i odpowiednią zapisaną
// w niej metodę. Patrz niżej, bez using Methods; trzeba by wywoływać metodę Methods.KomendyKonsoli.PowiedzCzesc();
using Methods;

// Mozna także zadeklarować bibliotekę razem z klasą:
// using static Methods.KomendyKonsoli;
// korzystając dodatkowo z parametru static, pozwoli to na "importowanie" metod do głównego pliku, ale może powodować komplikacje 
// w postaci chociażby duplikacji nazw metod pochodzących z różnych bibliotek, zatem nie zaleca się tego używać.

string imie = KomendyKonsoli.PobierzNazweUzytkownika();

// Aby przekazać dane do metody należy przekazać je za pomocą parametrów
KomendyKonsoli.PowiedzCzesc(imie);

// DRY - Don't Repeat Yourself
// Zasada polegająca na unikaniu powtarzania partii kodu, przez wrzucanie go w metody i odwoływanie się do nich

// SOLID - zestawa pięciu zasad
// S - SRP - Single Responsibility Principle
// Metoda powinna odpowiadać za jeden jedyny spójny logicznie fragment kodu (wykonywać jedną logicznie spójną czynność)
// Tworzenie metod to nie tylko unikanie powtarzania, warto fragmenty kodu spójne logicznie otaczać metodą ponieważ poprawia to
// czytelność kodu, pozwalając jednocześnie uniknąć użwania zbędnch komentarzy

// Na danych przekazanych do wewnątrz metody można wykonywać odpowiednie do ich typów operacje
MatSkroty.Suma(15, 12);

// Metodę można także wywołać wewnątrz wypisania w kosnoli tak samo jak zwykłe wartości
Console.WriteLine($"Wynik odejmowania liczby 13 i 12 to {MatSkroty.Roznica(13,12)}");

// Do metody można także przekazywać całe tablice
double[] zestawLiczb = new double[] { 1, 34, 56, 74, 22, 11, 345 };
MatSkroty.SumaWszystkich(zestawLiczb);

// Tuple z metody można przekazać do tupli bezpośrednio ją deklarując podając jedynie typy zmiennych:
(string, string) pelneDane = KomendyKonsoli.PobierzPelneDaneUzytkownika();
// Wtedy do odwołania się do nich potrzebny są słowa kluczowe Item wraz z nr wskazującym na pozycję pobieranej wartośc:
Console.WriteLine($"Pierwszę imię to: {pelneDane.Item1}");
Console.WriteLine($"Nazwisko to: {pelneDane.Item2}");

// Można także nadać kolejnym pozycjom tubli nazwy ułatwiające identyfikację konkretnej wartości:
(string imie, string nazwisko) pelneDane2 = KomendyKonsoli.PobierzPelneDaneUzytkownika();
Console.WriteLine($"Pierwszę imię to: {pelneDane2.imie}");
Console.WriteLine($"Nazwisko to: {pelneDane2.nazwisko}");

// Mozna także pozwolić aby automatycznie został rozpoznany typ zmiennych:
var pelneDane3 = KomendyKonsoli.PobierzPelneDaneUzytkownika();
Console.WriteLine($"Pierwszę imię to: {pelneDane3.pierwszeImie}");
Console.WriteLine($"Nazwisko to: {pelneDane3.nazwisko}");

// Można takze przekazać dane z tupli z metody bezpośrednio do zmiennych
(string pierwszeImie, string nazwisko) = KomendyKonsoli.PobierzPelneDaneUzytkownika();
Console.WriteLine($"Pierwszę imię to: {pierwszeImie}");
Console.WriteLine($"Nazwisko to: {nazwisko}");

// Przy użyciu znaku "podlogi" _ można zignorować zwracaną z metody wartość:
(string pierwszeImie2, _) = KomendyKonsoli.PobierzPelneDaneUzytkownika();

KomendyKonsoli.Zegnaj(imie);