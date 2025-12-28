namespace BankSystem.Konto;

/// <summary>
/// Klasa reprezentująca konto oszczędnościowe.
/// Dodaje oprocentowanie do wpłaty. (nie ma sensu ale...)
/// </summary>
public class KontoOszczednosciowe : KontoBankowe
{
    // Troche nie ma sensu ale... implementacja tylko w celach edukacyjnych
    private const decimal Oprocentowanie = 0.02m; // 2% od wpłaty

    public KontoOszczednosciowe(decimal saldoPoczatkowe)
        : base(saldoPoczatkowe) { }

    /// <summary>
    /// Wpłata zwiększa saldo o kwotę + odsetki.
    /// </summary>
    public override void Wplata(decimal kwota)
    {
        Saldo += kwota + kwota * Oprocentowanie;
    }

    /// <summary>
    /// Wypłata zmniejsza saldo o kwotę, jeśli saldo wystarcza.
    /// </summary>
    public override bool Wyplata(decimal kwota)
    {
        if (kwota <= Saldo)
        {
            Saldo -= kwota;
            return true;
        }
        return false;
    }

    public override string TypKonta()
    {
        return "Konto Oszczędnościowe";
    }

}
