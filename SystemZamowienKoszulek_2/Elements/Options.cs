namespace SystemZamowienKoszulek_2.Elements
{
    public enum Type
    {
        Male,
        Female,
        NieDotyczy
    }

    public enum Size
    {
        Xs,
        S,
        M,
        L,
        Xl,
        Xxl,
        Xxxl,
        NieDotyczy
    }
    /// <summary>
    /// Payment - Czeka na opłatę
    /// Checked - Zapłacone, czeka na realizacje
    /// Release - Zrealizowane, czeka na wydanie
    /// </summary>
    public enum State
    {
        Payment,
        Checked,
        Release
    }

    public enum Name
    {
        Koszulka,
        Kubek,
        None
    }
}