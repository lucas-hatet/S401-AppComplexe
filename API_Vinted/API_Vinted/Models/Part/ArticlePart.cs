

namespace API_Vinted.Models.EntityFramework
{
    public partial class Article
    {
        public override bool Equals(object? obj)
        {
            return obj is Article article &&
                   EqualityComparer<List<EtatArticle>?>.Default.Equals(EtatsArticles, article.EtatsArticles) &&
                   IDArticle == article.IDArticle &&
                   IDVendeur == article.IDVendeur &&
                   NumTransaction == article.NumTransaction &&
                   IDCategorie == article.IDCategorie &&
                   IDModePaiement == article.IDModePaiement &&
                   IDFormat == article.IDFormat &&
                   IDMarque == article.IDMarque &&
                   NomArticle == article.NomArticle &&
                   DateAjout == article.DateAjout &&
                   Description == article.Description &&
                   Prix == article.Prix &&
                   NBVue == article.NBVue &&
                   EqualityComparer<Client?>.Default.Equals(Vendeur, article.Vendeur) &&
                   EqualityComparer<Achat?>.Default.Equals(Achat, article.Achat) &&
                   EqualityComparer<Categorie?>.Default.Equals(Categorie, article.Categorie) &&
                   EqualityComparer<ModePaiement?>.Default.Equals(ModePaiement, article.ModePaiement) &&
                   EqualityComparer<FormatColis?>.Default.Equals(FormatColis, article.FormatColis) &&
                   EqualityComparer<Marque?>.Default.Equals(Marque, article.Marque) &&
                   EqualityComparer<ICollection<Signalement>?>.Default.Equals(Signalements, article.Signalements) &&
                   EqualityComparer<ICollection<CaracteristiqueArticle>?>.Default.Equals(CaracteristiquesArticle, article.CaracteristiquesArticle) &&
                   EqualityComparer<ICollection<PhotoArticle>?>.Default.Equals(Photos, article.Photos) &&
                   EqualityComparer<ICollection<Message>?>.Default.Equals(Messages, article.Messages) &&
                   EqualityComparer<ICollection<Favori>?>.Default.Equals(Favoris, article.Favoris) &&
                   EqualityComparer<ICollection<CouleurArticle>?>.Default.Equals(CouleursArticle, article.CouleursArticle);
        }
    }
}
