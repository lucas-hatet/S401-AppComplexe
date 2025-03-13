using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("valeur")]
    public partial class Valeur
    {
        [Key]
        [Column("idvaleur")]
        public int IDValeur { get; set; }

        [Required]
        [Column("idcaracteristique")]
        public int IDCaracteristique { get; set; }

        [Required]
        [Column("valeur")]
        [StringLength(50)]
        public string LibValeur { get; set; } = null!;


        [ForeignKey(nameof(IDCaracteristique))]
        [InverseProperty(nameof(Models.EntityFramework.Caracteristique.Valeurs))]
        public virtual Caracteristique Caracteristique { get; set; } = null!;

        [InverseProperty(nameof(CaracteristiqueArticle.Valeur))]
        public virtual ICollection<CaracteristiqueArticle> CaracteristiquesArticle { get; set; } = null!;
    }
}
