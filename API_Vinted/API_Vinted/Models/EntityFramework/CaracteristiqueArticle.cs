using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("caracteristique_article")]
    [PrimaryKey("IDArticle", "IDCaracteristique")]
    public partial class CaracteristiqueArticle
    {
        [Key]
        [Column("idarticle")]
        public int IDArticle{ get; set; }

        [Key]
        [Column("idcaracteristique")]
        public int IDCaracteristique { get; set; }

        [Column("idvaleur")]
        [Required]
        public int IDValeur { get; set; }

        [ForeignKey(nameof(IDArticle))]
        [InverseProperty(nameof(Models.EntityFramework.Article.CaracteristiquesArticle))]
        public Article Article { get; set; } = null!;

        [ForeignKey(nameof(IDCaracteristique))]
        [InverseProperty(nameof(Models.EntityFramework.Caracteristique.CaracteristiquesArticle))]
        public Caracteristique Caracteristique { get; set; } = null!;

        [ForeignKey(nameof(IDValeur))]
        [InverseProperty(nameof(Models.EntityFramework.Valeur.CaracteristiquesArticle))]
        public Valeur Valeur { get; set; } = null!;
    }
}
