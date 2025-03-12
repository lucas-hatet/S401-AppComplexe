using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public partial class ModePaiement
    {

        [InverseProperty(nameof(Article.ModePaiement))]
        public List<Article> Articles { get; set; } = null!;
    }
}
