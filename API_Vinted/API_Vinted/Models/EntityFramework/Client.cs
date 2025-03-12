using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class Client
    {

        [InverseProperty(nameof(Article.Vendeur))]
        public List<Article> Articles { get; set; } = null!;

        [InverseProperty(nameof(Avis.Vendeur))]
        public List<Avis> AvisSur { get; set; } = null!;

        [InverseProperty(nameof(Avis.Acheteur))]
        public List<Avis> AvisMis { get; set; } = null!;

        [InverseProperty(nameof(CarteBleue.Client))]
        public List<CarteBleue> CartesBleues { get; set; } = null!;
    }
}
