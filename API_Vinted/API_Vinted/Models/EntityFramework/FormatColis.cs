using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("formatcolis")]
    public class FormatColis
    {

        [Key]
        [Column("idformat")]
        public int IDFormat { get; set; }

        [Column("libelleformat")]
        [StringLength(20)]
        public string LibelleFormat { get; set; } = null!;

        [Column("fraisport")]
        public float FraisDePort { get; set; }

        [Column("descriptionformat")]
        [StringLength(300)]
        public string DescriptonFormat { get; set; } = null!;

        [InverseProperty(nameof(Article.FormatColis))]
        public ICollection<Article> Articles { get; set; } = null!;
    }
}
