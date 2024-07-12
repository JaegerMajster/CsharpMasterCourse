
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

Console.Write("Jak masz na imię: ");
string imie = Console.ReadLine();

KomendyKonsoli.PowiedzCzesc(imie);

// DRY - Don't Repeat Yourself
// Zasada polegająca na unikaniu powtarzania partii kodu, przez wrzucanie go w metody i odwoływanie się do nich

// SOLID - zestawa pięciu zasad
// S - SRP - Single Responsibility Principle
// Metoda powinna odpowiadać za jeden jedyny spójny logicznie fragment kodu (wykonywać jedną logicznie spójną czynność)
// Tworzenie metod to nie tylko unikanie powtarzania, warto fragmenty kodu spójne logicznie otaczać metodą ponieważ poprawia to
// czytelność kodu, pozwalając jednocześnie uniknąć użwania zbędnch komentarzy

Console.WriteLine("Tu znajduje się główna część programu");

KomendyKonsoli.Zegnaj(imie);