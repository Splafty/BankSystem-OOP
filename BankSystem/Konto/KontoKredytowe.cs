namespace BankSystem.Konto;

/// <summary>
/// Klasa reprezentująca konto kredytowe.
/// Pozwala na wypłatę do określonego limitu kredytowego.
/// </summary>
public class KontoKredytowe : KontoBankowe
{
    private readonly decimal LimitKredytowy;

    public KontoKredytowe(decimal limit)
        : base(0)
    {
        LimitKredytowy = limit;
    }

    /// <summary>
    /// Wpłata zwiększa saldo.
    /// </summary>
    public override void Wplata(decimal kwota)
    {
        Saldo += kwota;
    }

    /// <summary>
    /// Wypłata zmniejsza saldo do limitu kredytowego.
    /// </summary>
    public override bool Wyplata(decimal kwota)
    {
        if (Saldo - kwota >= -LimitKredytowy)
        {
            Saldo -= kwota;
            return true;
        }
        return false;
    }

    public override string TypKonta()
    {
        return "Konto Kredytowe";
    }

}
