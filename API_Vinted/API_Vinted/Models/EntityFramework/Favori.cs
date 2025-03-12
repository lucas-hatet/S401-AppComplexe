using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("favori")]
    [PrimaryKey("IDClient", "IDArticle")]
    public partial class Favori
    {
        [Column("idclient")]
        public int IDClient { get; set; }

        [Column("idarticle")]
        public int IDArticle { get; set; }

        [ForeignKey(nameof(IDClient))]
        [InverseProperty(nameof(Client.Favoris))]
        public virtual Client Client { get; set; } = null!;

        [ForeignKey(nameof(IDArticle))]
        [InverseProperty(nameof(Article.Favoris))]
        public virtual Article Article { get; set; } = null!;
    }
}
