using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Vinted.Models.EntityFramework
{
    [Table("comptebancaire")]
    public partial class CompteBancaire
    {
        [Key]
        [Column("idcompte")]
        public int IDCompte { get; set; }

        [Required]
        [Column("idclient")]
        public int IDClient { get; set; }

        [Required]
        [Column("iban")]
        [StringLength(50)]
        public string Iban { get; set; }

        [Required]
        [Column("titulairecompte")]
        [StringLength(50)]
        public string TitulaireCompte { get; set; }


        [ForeignKey(nameof(IDClient))]
        [InverseProperty(nameof(Client.CompteBancaires))]
        public Client Client { get; set; } = null!;
    }
}
