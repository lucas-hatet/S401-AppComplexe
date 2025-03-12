using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class FormatColis
    {

        [InverseProperty(nameof(Article.FormatColis))]
        public List<Article> Articles { get; set; } = null!;
    }
}
