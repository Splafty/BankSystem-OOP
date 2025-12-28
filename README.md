# BankSystem-OOP

## Opis projektu
System bankowy demonstrujący:
- Enkapsulację (pola chronione, metody dostępowe)
- Dziedziczenie (różne typy kont)
- Polimorfizm (funkcja obsługująca konto bazowe)

Typy kont:
- KontoBankowe (baza)
- KontoOsobiste
- KontoOszczednosciowe
- KontoKredytowe

Każde konto implementuje własną logikę wpłat i wypłat.

## Struktura katalogów
BankSystem/  
├── BankSystem.csproj  
├── Program.cs  
└── Konto/  
‎ ‎‎ ‎  ├── KontoBankowe.cs  
‎ ‎‎ ‎  ├── KontoOsobiste.cs  
‎ ‎‎ ‎  ├── KontoOszczednosciowe.cs  
‎ ‎‎ ‎  └── KontoKredytowe.cs  

## Kompilacja i uruchomienie
1. Sklonować repozytorium na swój komputer
2. Otworzenie folderu "BankSystem-OOP" w Visual Studio 2022
3. Otworzenie "BankSystem.sln" w eksplorerze po prawej
4. Przejście do pliku Program.cs
5. Zapoznanie się z komentarzami i outputem
6. Naciśnięcie zamalowanego zielonego trójkąta w navbarze z napisem "BankSystem"
7. Powinna pojawić się konsola z outputem programu
8. Koniec
