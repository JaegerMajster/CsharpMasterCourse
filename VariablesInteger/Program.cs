
// Integer to typ zawierajacy liczby całkowite od około - 2 mld do 2 mld - domyślnie jest to signed Int32 - co pozwala używać liczb ujemnych.
// Integer unsigned zwiększa maksymalną liczbę dodatnią do około 4 mld, ale nie pozwala używać liczb ujemnych.

// Inicjalizacja zmiennej typu int
int wiek = 0;
// Inicjalizacja zmiennej typu unsigned int:
// UInt32 wiek = 0;

// Przypisanie wartości do zmiennej typu int
wiek = 44;

// Przypisanie nowej wartości na podstawie poprzedniej wartości:
wiek = wiek + 2;

// Działania z wykorzystaniem zmiennej typu int:
int wiekZaDziesiecLat = wiek + 10;

Console.WriteLine($"Aktualny wiek: {wiek}");
Console.WriteLine($"Wiek za dziesięć lat: {wiekZaDziesiecLat}");

// Uwaga dzielenie zmiennej typu integer zwraca wartość całkowitą, bez reszty:
Console.WriteLine(wiek / 3);