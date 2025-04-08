
namespace API_Vinted.Models.EntityFramework
{
    public partial class CaracteristiqueArticle
    {
        public override bool Equals(object? obj)
        {
            return obj is CaracteristiqueArticle article &&
                   IDArticle == article.IDArticle &&
                   IDCaracteristique == article.IDCaracteristique &&
                   IDValeur == article.IDValeur &&
                   EqualityComparer<Article?>.Default.Equals(Article, article.Article) &&
                   EqualityComparer<Caracteristique?>.Default.Equals(Caracteristique, article.Caracteristique) &&
                   EqualityComparer<Valeur?>.Default.Equals(Valeur, article.Valeur);
        }
    }
}
