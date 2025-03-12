using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("ville")]
    public partial class Ville
    {
        [InverseProperty(nameof(Adresse.Ville))]
        public ICollection<Adresse> Adresses { get; set; } = null!;

        [InverseProperty(nameof(Client.Ville))]
        public ICollection<Client> Clients { get; set; } = null!;

        [Key]
        [Column("idville")]
        public int IDVille { get; set; }

        [Column("codepostal", TypeName = "char(5)")]
        public string CodePostal { get; set; } = null!;

        [Required]
        [Column("idpays")]
        public int IDPays { get; set; }
        
        [Required]
        [Column("nomville")]
        [StringLength(50)]
        public int NomVille { get; set; }

        [ForeignKey(nameof(IDPays))]
        [InverseProperty(nameof(Pays.Villes))]
        public Pays Pays { get; set; } = null!;
    }
}
