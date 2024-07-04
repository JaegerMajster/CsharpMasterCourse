
// Do tworzenia wyrażeń warunkowych można wykorzystywać wielu warunków:
Console.Write("Podaj proszę swoje imię: ");
string pierwszeImie = Console.ReadLine();

Console.Write("Podaj proszę swoje nazwisko: ");
string nazwisko = Console.ReadLine();

if (pierwszeImie.ToLower() == "mariusz" && 
    nazwisko.ToLower() == "jaguścik") // Wyrażenia warunkowe można łamać dowolnie, interpreter kieruje się znakami zamknięcia, nie spacjami czy liniami
{
    Console.WriteLine("Dzień dobry Panie Mariuszu J.!");
}
else if (pierwszeImie.ToLower() == "mariusz") // Jeśli któryś z powyższych warunków nie został spełniony, sprawdzi ten warunek
{
    Console.WriteLine("Dzień dobry masz zajefajne imię!");
}
else if (nazwisko.ToLower() == "jaguścik")
{
    Console.WriteLine("Masz wspaniałe nazwisko!"); // Jeśli któryś z pierwszego zestawu warunków nie zostanie spełniony, sprawdzi ten warunek
}
else
{
    Console.WriteLine("Przykro mi, że nie masz fajnego imienia ani nazwiska");
}

//W zależności od tego co chcemy uzyskać można również rozdzielać warunki 
if (pierwszeImie.ToLower() == "mariusz")
{
    Console.WriteLine("Cześć Mariusz!");
}
else
{
    Console.WriteLine("Cześć nie-Mariusz");
}
if (nazwisko.ToLower() == "jaguścik")
{
    Console.WriteLine("Cześć Jaguścik");
}
else
{
    Console.WriteLine("Cześć nie-Jaguścik");
}

// lub
if (pierwszeImie.ToLower() == "mariusz")
{
    Console.Write("Witaj Mariusz");
}
else if (nazwisko.ToLower() == "jaguścik")
{
    Console.WriteLine("Witaj Jaguścik");
}
else
{
    Console.WriteLine("Witaj ciulu!");
}

// Można także porównywać wielkość liczb
Console.Write("Podaj swój wiek: ");
int wiek = int.Parse(Console.ReadLine());
if (wiek > 50)
{
    Console.WriteLine("Jesteś stary");
}

if (wiek <= 50)
{
    Console.WriteLine("Jesteś jeszcze nie stary");
}

if (wiek >= 40 &&
    wiek < 50)
{
    Console.WriteLine("Jesteś czterdziestolatkiem");
}
else if (wiek >= 50)
{
    Console.WriteLine("Nie jesteś już czterdziestolatkiem");
}
else
{
    Console.WriteLine("Nie jesteś jeszcze czterdziestolatkiem");
}

// W budowaniu wyrażeń warunkowych można korzystać również z innych operatorów niż && (AND), np. || (OR):

if (pierwszeImie.ToLower() == "mariusz" && nazwisko.ToLower() == "jaguścik") // W przypadku łączenia warunków AND i OR ważna jest ich kolejność!
{
    Console.WriteLine("Nazywasz się Mariusz Jaguścik.");
}
else if (pierwszeImie.ToLower() == "mariusz" || nazwisko.ToLower() == "jaguścik") // Warunek zostanie spełnieniony zarówno w wypadku gdy imię to Mariusz, jak nazwisko to Jaguścik
{
    Console.WriteLine("Masz fajne imię lub nazwisko");
}
else
{
    Console.WriteLine("Nie masz ani fajnego imienia ani nazwiska.");
}

// Można również budować skomplikowane struktury warunków, aby sprawdzać rózne warianty:

if ((wiek >= 40 && wiek < 50) || 
    (wiek >= 70 && wiek < 80))
{
    Console.WriteLine("Jesteś w czwartej lub siódmej dekadzie swojego życia");
}
