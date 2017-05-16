namespace BookConsole
{
    internal abstract class ProduitBase : IProduit
    {
        int Id { get; set}
        string Designation { get; set; }
        string Quantite { get; set; }
        public string Afficher()
        {
            return "PRODUIT DE BASE";
        }
    }
}