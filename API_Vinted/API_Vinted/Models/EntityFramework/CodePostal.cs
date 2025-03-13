using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("code_postal")]
    public partial class CodePostal
    {
        [InverseProperty(nameof(Ville.CodePostal))]
        public virtual ICollection<Ville> Villes { get; set; } = null!;

        [Key]
        [Column("codepostal")]
        [StringLength(5)]
        public string CP { get; set; }
    }
}
