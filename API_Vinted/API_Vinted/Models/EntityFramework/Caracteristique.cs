using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("caracteristique")]
    public partial class Caracteristique
    {
        [Key]
        [Column("idcaracteristique")]
        public int IDCaracteristique{ get; set; }

        [Column("nomcaracteristique")]
        [StringLength(50)]
        public string NomCaracteristique { get; set; } = null!;

        [InverseProperty(nameof(Valeur.Caracteristique))]
        public virtual ICollection<Valeur>? Valeurs { get; set; } = null!;

        [InverseProperty(nameof(CaracteristiqueArticle.Caracteristique))]
        public virtual ICollection<CaracteristiqueArticle>? CaracteristiquesArticle { get; set; } = null!;

        [InverseProperty(nameof(CaracteristiqueCategorie.Caracteristique))]
        public virtual ICollection<CaracteristiqueCategorie>? CaracteristiquesCategorie { get; set; } = null!;
    }
}
