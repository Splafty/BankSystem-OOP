namespace BankSystem.Konto;

/// <summary>
/// Abstrakcyjna klasa bazowa reprezentująca konto bankowe.
/// Zawiera wspólne dane i deklaracje metod dla wszystkich kont.
/// </summary>
public abstract class KontoBankowe
{
    // Pole chronione przechowujące saldo konta (enkapsulacja częściowa)
    protected decimal Saldo;

    /// <summary>
    /// Konstruktor klasy bazowej.
    /// Inicjalizuje saldo początkowe.
    /// </summary>
    protected KontoBankowe(decimal saldoPoczatkowe)
    {
        Saldo = saldoPoczatkowe;
    }

    /// <summary>
    /// Metoda dostępowa do pobrania salda.
    /// Zapewnia enkapsulację danych.
    /// </summary>
    public decimal PobierzSaldo()
    {
        return Saldo;
    }

    /// <summary>
    /// Abstrakcyjna metoda wpłaty.
    /// Każda klasa pochodna implementuje własną logikę wpłaty.
    /// </summary>
    public abstract void Wplata(decimal kwota);

    /// <summary>
    /// Abstrakcyjna metoda wypłaty.
    /// Każda klasa pochodna implementuje własną logikę wypłaty.
    /// </summary>
    public abstract bool Wyplata(decimal kwota);

    /// <summary>
    /// Metoda zwracająca typ konta.
    /// Klasy pochodne nadpisują ją w celu zwrócenia właściwej nazwy.
    /// </summary>
    public abstract string TypKonta();
}
