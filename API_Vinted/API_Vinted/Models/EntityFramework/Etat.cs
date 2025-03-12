using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Vinted.Models.EntityFramework
{
    [Table("etat")]
    public partial class Etat
    {
        [InverseProperty(nameof(EtatArticle.Etat))]
        public virtual ICollection<EtatArticle> EtatsArticles { get; set; } = null!;


        [Key]
        [Column("idetat")]
        public int IDEtat { get; set; }

        [Required]
        [Column("libelleetat")]
        public int LibelleEtat { get; set; }

    }
}
