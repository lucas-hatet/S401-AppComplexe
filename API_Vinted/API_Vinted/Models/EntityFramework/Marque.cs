using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("marque")]
    public class Marque
    {

        [Key]
        [Column("idmarque")]
        public int IDMarque { get; set; }

        [Column("nommarque")]
        public string? NomMarque { get; set; }

        [InverseProperty(nameof(Article.Marque))]
        public ICollection<Article> Articles { get; set; } = null!;
    }
}
