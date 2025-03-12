using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("message")]
    [PrimaryKey("IDExpediteur", "IDDestinataire", "IDArticle", "ContenuMessage", "DateMessage")]
    public partial class Message
    {
        [Column("idexpediteur")]
        public int IDExpediteur { get; set; }

        [Column("iddestinataire")]
        public int IDDestinataire { get; set; }

        [Column("idarticle")]
        public int IDArticle { get; set; }

        [Column("message")]
        public string ContenuMessage { get; set; } = null!;

        [Column("datemessage")]
        public DateTime DateMessage { get; set; }

        [Column("prixoffre")]
        public double PrixOffre { get; set; }

        [ForeignKey(nameof(IDExpediteur))]
        [InverseProperty(nameof(Client.MessagesEnvoyes))]
        public virtual Client Expediteur { get; set; } = null!;

        [ForeignKey(nameof(IDDestinataire))]
        [InverseProperty(nameof(Client.MessagesRecus))]
        public virtual Client Destinataire { get; set; } = null!;

        [ForeignKey(nameof(IDArticle))]
        [InverseProperty(nameof(Article.Messages))]
        public virtual Article Article { get; set; } = null!;
    }
}
