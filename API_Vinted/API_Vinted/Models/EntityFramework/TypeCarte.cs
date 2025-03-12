using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;

namespace API_Vinted.Models.EntityFramework
{
    [Table("type_carte")]
    public partial class TypeCarte
    {
        [InverseProperty(nameof(CarteBleue.TypeCarte))]
        public List<CarteBleue> CartesBleues { get; set; } = null!;
        [Key]
        [Column("idtypecarte")]
        public int IDTypeCarte { get; set; }

        [Required]
        [Column("libelletypecarte")]
        [StringLength(50)]
        public String LibelleTypeCarte { get; set; } = null!;
    }
}
