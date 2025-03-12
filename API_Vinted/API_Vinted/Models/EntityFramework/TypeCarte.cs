using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("typecarte")]
    public class TypeCarte
    {
        [Key]
        [Column("idtypecarte")]
        public int IDTypeCarte { get; set; }

        [Column("libelletypecarte")]
        [StringLength(50)]
        public String LibelleTypeCarte { get; set; } = null!;
    }
}
