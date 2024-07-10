
// Pętla for pozwala wykonać powtórzenie określoną z góry ilość razy, zawiera licznik, który jest zwiększany do określonego momentu, w którym pętla zostaje przerwana
// i - to licznik wskazujący która pętla jest aktualnie wykonywana
// i < length - to warunek, którego spełnienie przerywa pętlę (gdy i osiągnie konkretną wartość określoną parametrem length)
// i++ - wskazuje o ile licznik ma się powiększać przy każdym kolejnym przejściu
// UWAGA - przy zmianie wielkości "kroku" można łatwo stworzyć pętlę nieskończoną, ponieważ warunek może nigdy nie zostać spełniony

// Klasyczna pętla for, zostanie wykonana 10 razy, ponieważ zostanie przerwana gdy licznik i osiągnie 10 (dla wartości 10 nie zostanie już wykonana pętla)
using System.Diagnostics.CodeAnalysis;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Wartość i to: {i}");
}

// Pętle for można również wykorzystać do uzyskania dostępu do każdej wartości tablic czy list, wykorzystując licznik i jako indeks
string dane = "Tim,Mariusz,Bob,Julia,Anna,Monika";
List<string> pierwszeImiona= dane.Split(new char[] { ',' }).ToList();

for (int i = 0; i < pierwszeImiona.Count; i++)
{
    Console.WriteLine($"Pierwsze imię pracownika nr {i+1}: {pierwszeImiona[i]}");
}

// Pętle for można również w łatwy sposób wykorzystać do np. sumowania wszystkich wartości liczbowych zawartych w tablicach czy listach
List<decimal> obciazenia = new();
obciazenia.Add(21.33M);
obciazenia.Add(223.44M);
obciazenia.Add(65.42M);
obciazenia.Add(76.23M);

decimal suma = 0;

for (int i = 0; i < obciazenia.Count; i++)
{
    suma += obciazenia[i];
}

Console.WriteLine($"Suma wszystkich wydatków: {suma} zł");