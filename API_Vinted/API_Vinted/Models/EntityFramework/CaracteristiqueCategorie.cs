using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("caracteristique_categorie")]
    [PrimaryKey("IDCategorie","IDCaracteristique")]
    public partial class CaracteristiqueCategorie
    {
        [Key]
        [Column("idcategorie")]
        public int IDCategorie { get; set; }

        [Key]
        [Column("idcaracteristique")]
        public int IDCaracteristique { get; set; }

        [ForeignKey(nameof(IDCategorie))]
        [InverseProperty(nameof(Models.EntityFramework.Categorie.CaracteristiquesCategorie))]
        public virtual Categorie? Categorie { get; set; } = null!;

        [ForeignKey(nameof(IDCaracteristique))]
        [InverseProperty(nameof(Models.EntityFramework.Caracteristique.CaracteristiquesCategorie))]
        public virtual Caracteristique? Caracteristique { get; set; } = null!;
    }
}
