using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("option_livraison")]
    public partial class OptionLivraison
    {
        [Key]
        [Column("idoption")]
        public int IDOption { get; set; }

        [Column("libelleoption")]
        [StringLength(50)]
        public string LibelleOption { get; set; }
        
        [Column("nomoption")]
        [StringLength(200)]
        public string DescriptionOption { get; set; }
        
        [Column("frais",TypeName = "numeric(18,2)")]
        public double Frais { get; set; }
        
        [InverseProperty(nameof(Achat.OptionLivraison))]
        public virtual ICollection<Achat> Achats { get; set; } = null!;

        [InverseProperty(nameof(Retour.Option))]
        public virtual ICollection<Retour> Retours { get; set; } = null!;
    }
}
