using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("langue")]
    public class Langue
    {
        [Key]
        [Column("idLangue")]
        public int IDLangue { get; set; }

        [Column("libellelangue")]
        [StringLength(50)]
        public string Libellelangue { get; set; } = null!;

        [InverseProperty(nameof(Client.Langue))]
        public ICollection<Client> Clients { get; set; } = null!;
    }
}
