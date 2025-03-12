using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("valeur")]
    public class Valeur
    {
        [Key]
        [Column("idvaleur")]
        public int IDValeur { get; set; }

        [Required]
        [Column("idcaracteristique")]
        public int IDCaracteristique { get; set; }

        [Column("valeur")]
        [StringLength(50)]
        public string LibValeur { get; set; } = null!;

        [ForeignKey(nameof(IDCaracteristique))]
        [InverseProperty(nameof(Caracteristique.Valeurs))]
        public Caracteristique Caracteristique { get; set; }
    }
}
