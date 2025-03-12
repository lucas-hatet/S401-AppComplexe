using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Vinted.Models.EntityFramework
{
    public partial class EtatArticle
    {
        [InverseProperty(nameof(EtatArticle.Etat))]
        public virtual List<EtatArticle> EtatsArticle { get; set; } = null!;


        [Required]
        [Column("idarticle")]
        public int IDArticle { get; set; }

        [Key]
        [Column("idetat")]
        public int IDEtat { get; set; }


        [ForeignKey(nameof(IDArticle))]
        [InverseProperty(nameof(Article.EtatsArticles))]
        public virtual Article Article { get; set; } = null!;

        [ForeignKey(nameof(IDEtat))]
        [InverseProperty(nameof(Etat.EtatsArticles))]
        public virtual Etat Etat { get; set; } = null!;
    }
}
