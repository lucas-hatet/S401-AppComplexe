using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("sexe")]
    public partial class Sexe
    {
        [InverseProperty(nameof(Client.Sexe))]
        public List<Client> Clients { get; set; } = null!;

        [Key]
        [Column("idsexe")]
        public int IDSexe { get; set; }

        [Column("libellesexe")]
        [StringLength(20)]
        public string LibelleSexe { get; set; } = null!;
    }
}
