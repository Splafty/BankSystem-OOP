namespace BankSystem.Konto;

/// <summary>
/// Klasa reprezentująca konto osobiste.
/// Dziedziczy po KontoBankowe.
/// </summary>
public class KontoOsobiste : KontoBankowe
{
    public KontoOsobiste(decimal saldoPoczatkowe)
        : base(saldoPoczatkowe) { }

    /// <summary>
    /// Wpłata zwiększa saldo o kwotę.
    /// </summary>
    public override void Wplata(decimal kwota)
    {
        Saldo += kwota;
    }

    /// <summary>
    /// Wypłata zmniejsza saldo o kwotę, jeśli saldo wystarcza.
    /// Zwraca true jeśli operacja powiodła się.
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
        return "Konto Osobiste";
    }
}
