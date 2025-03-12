using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("categorie")]
    public partial class Categorie
    {
        [Key]
        [Column("idcategorie")]
        public int IDCategorie { get; set; }

        [Column("idcategorieparent")]
        public int IDCategorieParent { get; set; }

        [Column("libellecategorie")]
        [StringLength(50)]
        public string LibelleCategorie { get; set; }


        [InverseProperty(nameof(Article.Categorie))]
        public Article Articles { get; set; } = null!;


        [InverseProperty(nameof(CaracteristiqueCategorie.Categorie))]
        public virtual ICollection<CaracteristiqueCategorie> CaracteristiquesCategorie { get; set; } = null!;

        [ForeignKey(nameof(IDCategorieParent))]
        [InverseProperty(nameof(Categorie.CategoriesEnfants))]
        public virtual Categorie CategorieParent { get; set; } = null!;

        [InverseProperty(nameof(Categorie.CategorieParent))]
        public virtual ICollection<Categorie> CategoriesEnfants { get; set; } = null!;
    }
}
