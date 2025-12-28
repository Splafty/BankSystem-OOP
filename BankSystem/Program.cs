using System;
using BankSystem.Konto;

namespace BankSystem;

class Program
{
    /// <summary>
    /// Funkcja demonstrująca polimorfizm i różne scenariusze operacji.
    /// Przyjmuje referencję do klasy bazowej KontoBankowe.
    /// </summary>
    static void ObsluzKonto(KontoBankowe konto, decimal wplataKwota, decimal wyplataKwota)
    {
        Console.WriteLine("-------------=== Nowa operacja ===-------------");

        // Typ konta
        Console.WriteLine($"Typ konta: {konto.TypKonta()}");

        // Saldo przed wpłatą
        Console.WriteLine($"Saldo przed wpłatą: {konto.PobierzSaldo()}");

        // Wpłata
        Console.WriteLine($"Wpłata: {wplataKwota}");
        konto.Wplata(wplataKwota);
        Console.WriteLine($"Saldo po wpłacie: {konto.PobierzSaldo()}");

        // Próba wypłaty
        Console.WriteLine($"Wypłata: {wyplataKwota}");
        bool sukces = konto.Wyplata(wyplataKwota);
        if (sukces)
        {
            Console.WriteLine($"Wypłata zakończona sukcesem. Saldo: {konto.PobierzSaldo()}");
        }
        else
        {
            Console.WriteLine($"Wypłata odrzucona. Saldo: {konto.PobierzSaldo()}");
        }

        Console.WriteLine("-----------------------------------------------\n");
    }

    static void Main(string[] args)
    {
        // Tworzenie kont
        KontoBankowe kontoOsobiste = new KontoOsobiste(500);
        KontoBankowe kontoOszczednosciowe = new KontoOszczednosciowe(500);
        KontoBankowe kontoKredytowe = new KontoKredytowe(1000);

        // Test 1: Konto osobiste, normalna wpłata i wypłata
        ObsluzKonto(kontoOsobiste, 200, 100);

        // Test 2: Konto osobiste, próba wypłaty większej niż saldo
        ObsluzKonto(kontoOsobiste, 0, 700);

        // Test 3: Konto oszczędnościowe, wpłata z odsetkami i normalna wypłata
        ObsluzKonto(kontoOszczednosciowe, 300, 100);

        // Test 4: Konto kredytowe, wypłata w ramach limitu
        ObsluzKonto(kontoKredytowe, 0, 800);

        // Test 5: Konto kredytowe, próba wypłaty powyżej limitu kredytowego
        ObsluzKonto(kontoKredytowe, 0, 300);

        // Test 6: Konto kredytowe, wpłata na konto zadłużone
        ObsluzKonto(kontoKredytowe, 500, 0);
    }
}
