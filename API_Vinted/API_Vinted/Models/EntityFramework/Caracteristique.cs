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
        public List<Valeur> Valeurs { get; set; } = null!;

        [InverseProperty(nameof(CaracteristiqueArticle.Article))]
        public List<CaracteristiqueArticle> CaracteristiquesArticle { get; set; } = null!;

        [InverseProperty(nameof(CaracteristiqueCategorie.Categorie))]
        public List<CaracteristiqueCategorie> CaracteristiquesCategorie { get; set; } = null!;
    }
}
