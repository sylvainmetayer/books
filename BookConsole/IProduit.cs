namespace BookConsole
{
    internal interface IProduit
    {
        int Id { get; set}
        string Designation { get; set; }
        string Quantite { get; set; }
        string Afficher();
    }
}