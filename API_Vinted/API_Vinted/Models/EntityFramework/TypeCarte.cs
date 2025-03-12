using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("typecarte")]
    public class TypeCarte
    {
        [InverseProperty(nameof(CarteBleue.TypeCarte))]
        public List<CarteBleue> CartesBleues { get; set; } = null!;
        [Key]
        [Column("idtypecarte")]
        public int IDTypeCarte { get; set; }

        [Column("libelletypecarte")]
        [StringLength(50)]
        public String LibelleTypeCarte { get; set; } = null!;
    }
}
