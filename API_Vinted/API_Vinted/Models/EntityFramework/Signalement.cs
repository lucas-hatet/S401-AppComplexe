using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("signalement")]
    [PrimaryKey("IDClient","IDArticle")]
    public class Signalement
    {
        [Key]
        [Column("idclient")]
        public int IDClient { get; set; }
        [Key]
        [Column("idarticle")]
        public int IDArticle { get; set; }

        [Column("motifsignalement")]
        public string MotifSignalement { get; set; } = null!;

        [Column("datesignalement",TypeName = "Date")]
        public DateTime DateSignalement { get; set; }

        [ForeignKey(nameof(IDClient))]
        [InverseProperty(nameof(Client.Signalements))]
        public Client Client { get; set; } = null!;

        [ForeignKey(nameof(IDArticle))]
        [InverseProperty(nameof(Article.Signalements))]
        public virtual Article Article { get; set; } = null!;
    }
}
