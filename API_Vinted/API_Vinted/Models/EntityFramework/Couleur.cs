using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Vinted.Models.EntityFramework
{
    [Table("couleur")]
    public partial class Couleur
    {
        [InverseProperty(nameof(CouleurArticle.Couleur))]
        public virtual ICollection<CouleurArticle> CouleursArticle { get; set; } = null!;


        [Key]
        [Column("idcouleur")]
        public int IDCouleur { get; set; }

        [Required]
        [Column("nomcouleur")]
        [StringLength(30)]
        public string NomCouleur { get; set; } = null!;

        [Column("codehexa")]
        [StringLength(7)]
        public string? CodeHexa { get; set; }

    }
}
