using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("mode_paiement")]
    public partial class ModePaiement
    {
        [Key]
        [Column("idmodepaiement")]
        public int IDModePaiement { get; set; }

        [Required]
        [Column("libellemodepaiement")]
        [StringLength(50)]
        public string LibelleModePaiement { get; set; } = null!;

        [InverseProperty(nameof(Article.ModePaiement))]
        public virtual ICollection<Article> Articles { get; set; } = null!;
    }
}
