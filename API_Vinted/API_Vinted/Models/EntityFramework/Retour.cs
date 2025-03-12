using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("retour")]
    public partial class Retour
    {
        [Key]
        [Column("idretour")]
        public int IDRetour { get; set; }

        [Column("idoption")]
        public int IDOption { get; set; }

        [Required]
        [Column("datedernieredemande",TypeName = "Date")]
        public DateTime DateDerniereDemande { get; set; }

        [Required]
        [Column("demandeexpert")]
        public bool DemandeExpert { get; set; }

        [Required]
        [Column("coderetour")]
        [StringLength(50)]
        public string CodeRetour { get; set; } = null!;

        [Required]
        [Column("datecreation",TypeName = "Date")]
        public DateTime DateCreation { get; set; }

        [Column("Accepte")]
        public bool Accepte { get; set; }

        [Required]
        [Column("motifretour")]
        [StringLength(300)]
        public string MotifRetour { get; set; } = null!;

        [InverseProperty(nameof(Achat.Retours))]
        public virtual ICollection<Achat> Achats { get; set; } = null!;

        [ForeignKey(nameof(IDOption))]
        [InverseProperty(nameof(OptionLivraison.Retours))]
        public virtual OptionLivraison Option { get; set; } = null!; //si cette ligne pose problème c'est la faute de Simon.

        [InverseProperty(nameof(PhotoRetour.Retour))]
        public virtual ICollection<PhotoRetour> Photos { get; set; }
    }
}
