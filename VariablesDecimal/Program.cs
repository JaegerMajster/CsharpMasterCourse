
// Zmienne typu decimal utrzymują podobnie jak zmienne typu decimal liczby rzeczywiste.
// Zmienne typu decimal posiadają większą precyzję
// Zajmują jednak znacznie więcej miejsca w pamięci
// Zmiennych typu decimal używa się praktycznie wyłącznie do pieniędzy lub wartości astronomicznych.

decimal bilansKontaBankowego;

// Przy inicjalizowaniu zmiennej typu decimal należy uważać, aby nie podawać wartości która może być zinterpretowana jako double.
bilansKontaBankowego = 2.34M;

Console.WriteLine(bilansKontaBankowego);