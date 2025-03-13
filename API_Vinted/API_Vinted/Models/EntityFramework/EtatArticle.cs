using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.EntityFramework
{
    [Table("etat_article")]
    [PrimaryKey("IDArticle","IDEtat")]
    public partial class EtatArticle
    {
        [Key]
        [Column("idarticle")]
        public int IDArticle { get; set; }

        [Key]
        [Column("idetat")]
        public int IDEtat { get; set; }


        [ForeignKey(nameof(IDArticle))]
        [InverseProperty(nameof(Models.EntityFramework.Article.EtatsArticles))]
        public virtual Article Article { get; set; } = null!;

        [ForeignKey(nameof(IDEtat))]
        [InverseProperty(nameof(Models.EntityFramework.Etat.EtatsArticles))]
        public virtual Etat Etat { get; set; } = null!;
    }
}
