using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("ville")]
    public partial class Ville
    {
        [InverseProperty(nameof(Adresse.Ville))]
        public virtual ICollection<Adresse> Adresses { get; set; } = null!;

        [InverseProperty(nameof(Client.Ville))]
        public virtual ICollection<Client> Clients { get; set; } = null!;

        [Key]
        [Column("idville")]
        public int IDVille { get; set; }

        [Required]
        [Column("codepostal", TypeName = "char(5)")]
        public string CP { get; set; } = null!;

        [Required]
        [Column("idpays")]
        public int IDPays { get; set; }

        [Required]
        [Column("nomville")]
        [StringLength(50)]
        public string NomVille { get; set; } = null!;

        [ForeignKey(nameof(IDPays))]
        [InverseProperty(nameof(Models.EntityFramework.Pays.Villes))]
        public virtual Pays Pays { get; set; } = null!;

        [ForeignKey(nameof(CP))]
        [InverseProperty(nameof(Models.EntityFramework.CodePostal.Villes))]
        public virtual CodePostal CodePostal { get; set; } = null!;
    }
}
