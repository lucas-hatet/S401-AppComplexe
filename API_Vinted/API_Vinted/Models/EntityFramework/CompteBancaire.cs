using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Vinted.Models.EntityFramework
{
    public class CompteBancaire
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
        public int Iban { get; set; }

        [Required]
        [Column("titulairecompte")]
        [StringLength(50)]
        public int TitulaireCompte { get; set; }
    }
}
