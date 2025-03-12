using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("achat")]
    public partial class Achat
    {
        [Key]
        public int NumTransaction { get; set; }

        [Required]
        public int IDOption { get; set; }

        public int IDRetour { get; set; }

        [Required]
        public int IDClient { get; set; }

        [Column("dateachat", TypeName = "Date")]
        public DateTime DateAchat { get; set; }


        [ForeignKey(nameof(IDOption))]
        [InverseProperty(nameof(Models.EntityFramework.OptionLivraison.Achats))]
        public virtual OptionLivraison OptionLivraison { get; set; } = null!;

        [ForeignKey(nameof(IDRetour))]
        [InverseProperty(nameof(Retour.Achats))]
        public virtual Retour Retours { get; set; } = null!;

        [InverseProperty(nameof(Article.Achat))]
        public virtual Article Articles { get; set; } = null!;

    }
}
