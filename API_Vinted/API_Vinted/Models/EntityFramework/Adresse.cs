using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("adresse")]
    public class Adresse
    {

        [InverseProperty(nameof(Client.AdresseLivraison))]
        public Client ClientAdresseLivraison { get; set; } = null!;
        
        [InverseProperty(nameof(Client.AdresseLivraison))]
        public Client ClientAdresseFacturation { get; set; } = null!;


        [Key]
        [Column("idadresse")]
        public int IDAdresse { get; set; }

        [Required]
        [Column("idville")]
        public int IDVille { get; set; }

        [Column("nomcompletadresse")]
        [StringLength(50)]
        public string NomCompletAdresse { get; set; } = null!;

        [Column("numetnomrue")]
        [StringLength(50)]
        public string NumEtNomRue { get; set; } = null!;

        [Column("adresseligne2")]
        [StringLength(50)]
        public string AdresseLigne2 { get; set; }

        [ForeignKey(nameof(IDVille))]
        [InverseProperty(nameof(Ville.Adresses))]
        public virtual Ville Ville { get; set; } = null!;
    }
}
