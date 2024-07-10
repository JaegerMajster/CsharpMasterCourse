
string dane;
List<string> imiona = new();

//1.Powitanie
Console.WriteLine("Witaj w mojej domowej aplikacji dotyczącej pętli for");
Console.WriteLine("----------------------------------------------------");

//2.Prośba o wpisanie imion oddzielonych przecinkami bez spacji
Console.Write("Wpisz proszę kilka imion rodzielonych przecinkami. Proszę nie stosuj spacji: ");
dane = Console.ReadLine();

//3. Podzielenie stringa na tablicę
imiona = dane.Split(',').ToList();

//4. Wypisanie pozdrowienia dla każdej z osób zapisanych w tablicy
Console.Clear();
for (int i = 0; i < imiona.Count; i++)
{
    Console.WriteLine($"Cześć {imiona[i]}!");
}

//5. Podziękowanie
Console.WriteLine();
Console.WriteLine("Dziękuję za skorzystanie z mojej aplikacji!");