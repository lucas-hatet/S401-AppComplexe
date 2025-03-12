using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class Marque
    {

        [InverseProperty(nameof(Article.Marque))]
        public List<Article> Articles { get; set; } = null!;
    }
}
