using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Vinted.Models.EntityFramework
{
    [Table("couleur")]
    public abstract class Couleur
    {
        [InverseProperty(nameof(CouleurArticle.Couleur))]
        public List<Couleur> CouleursArticle { get; set; } = null!;


        [Key]
        [Column("idcouleur")]
        public int IDCouleur { get; set; }

        [Required]
        [Column("nomcouleur")]
        [StringLength(30)]
        public string NomCouleur { get; set; }

        [Column("titulairecompte")]
        [StringLength(7)]
        public string CodeHexa { get; set; }

    }
}
