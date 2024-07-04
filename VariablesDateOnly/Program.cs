
// Od .Net 6.0 wprowadzono nowy typ zmiennych zawierający jedynie samą datę
DateOnly jakasData = DateOnly.Parse(s: "5/5/1995");
DateTime jakasData2 = DateTime.Parse(s: "5/5/1995");

Console.WriteLine($"Sama data: {jakasData}");
Console.WriteLine($"Sama data z czasem: {jakasData2}");
