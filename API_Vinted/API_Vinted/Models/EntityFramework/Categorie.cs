using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class Categorie
    {

        [InverseProperty(nameof(Article.Categorie))]
        public Article Articles { get; set; } = null!;
    }
}
