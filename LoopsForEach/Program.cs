
// Pętla foreach pozwala na dostęp do każdego z elementów tablic oraz list bez potrzeby korzystania z indeksu
// Pierwszy parametr określa typ zmiennych przechowywanych w elementach listy
// Drugi parametr to nazwa elementu program będzie się odwoływał wewnątrz pętli
// Trzeci parametr to nazwa tablicy/listy z której pobierane będą dane

string dane = "Tim,Mariusz,Bob,Jane";
List<string> pierwszeImiona = dane.Split(',').ToList();

foreach (string pierwszeImie in pierwszeImiona)
{
    Console.WriteLine(pierwszeImie); 
}

// W pętli foreach można skorzystać z parametru var zamiast podawania konkretnego typu danych zawartych w tablicy czy na liście
// w takim wypadku każdy element wyjęty z tablicy/listy przyjmie taki sam typ jaki przechowuje dana tablica/lista.
foreach (var pierwszeImie in pierwszeImiona)
{
    Console.WriteLine(pierwszeImie);
}