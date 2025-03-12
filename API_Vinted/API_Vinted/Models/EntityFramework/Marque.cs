using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public partial class Marque
    {

        [InverseProperty(nameof(Article.Marque))]
        public ICollection<Article> Articles { get; set; } = null!;
    }
}
