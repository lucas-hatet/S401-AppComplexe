using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("sexe")]
    public partial class Sexe
    {
        [InverseProperty(nameof(Client.Sexe))]
        public virtual ICollection<Client> Clients { get; set; } = null!;

        [Key]
        [Column("idsexe")]
        public int IDSexe { get; set; }

        [Required]
        [Column("libellesexe")]
        [StringLength(20)]
        public string LibelleSexe { get; set; } = null!;
    }
}
