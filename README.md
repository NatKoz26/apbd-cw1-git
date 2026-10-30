# Projekt Konsolowy 

## Opis Działania programu: 
Prosty program konsolowy podzielony na klasy
* `Program.cs` – główny plik wykonawczy (punkt wejścia). Tworzy tablicę liczb całkowitych (`{ 2, 4, 6 }`), a następnie wywołuje metody z pozostałych klas, aby wypisać tekst oraz wyniki w konsoli.
* `Greeting.cs`– zawiera statyczną klasę `Greeting` z metodą `GetMessage()`, która po prostu zwraca tekst powitalny ("Hello, APBD!").
* `StatisticsHelper.cs` – zawiera statyczną klasę `StatisticsHelper` z metodą `CalculateSum()`. Metoda ta przyjmuje tablicę liczb, sumuje je za pomocą pętli `foreach` i zwraca całkowity wynik (w tym przypadku `12`).

Po uruchomieniu program wypisuje w terminalu powitanie oraz zsumowaną wartość z tablicy

## Instrukcja uruchomienia:

### Jak uruchomić:
0.Pobierz projekt 
1. Otwórz terminal 
2. Przejdź do głównego folderu projektu 
3. Wykonaj polecenie: 
"dotnet run"