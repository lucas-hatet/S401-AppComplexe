using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class Client
    {

        [InverseProperty(nameof(Article.Vendeur))]
        public Article Articles { get; set; } = null!;

        [InverseProperty(nameof(Signalement.Client))]
        public List<Signalement> Signalements { get; set; } = null!;
    }
}
