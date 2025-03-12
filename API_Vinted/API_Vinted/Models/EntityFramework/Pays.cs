using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("Pays")]
    public class Pays
    {
        [Key]
        [Column("idpays")]
        public int IDPays { get; set; }

        [Required]
        [Column("nompays")]
        public string NomPays { get; set; } = null!;

        [InverseProperty(nameof(Ville.Pays))]
        public virtual ICollection<Ville> Villes { get; set; } = null!;
    }
}
