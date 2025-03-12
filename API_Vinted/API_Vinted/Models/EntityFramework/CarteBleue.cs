using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("carte_bancaire")]
    public partial class CarteBleue
    {
        [Key]
        [Column("idcarte")]
        public int IDCarte { get; set; }

        [Required]
        [Column("idclient")]
        public int IDClient { get; set; }

        [Column("idtypecarte")]
        [Required]
        public int IDTypeCarte { get; set; }

        [Column("numcartebleue")]
        [StringLength(300)]
        public string NumCarteBleue { get; set; } = null!;

        [Column("dateexpiration", TypeName ="char(5)")]
        public string DateExpiration { get; set; } = null!;

        [Column("titulairecarte")]
        [StringLength(300)]
        public string TitulaireCarte { get; set; } = null!;

        [ForeignKey(nameof(IDClient))]
        [InverseProperty(nameof(Models.EntityFramework.Client.CartesBleues))]
        public Client Client { get; set; } = null!;

        [ForeignKey(nameof(IDTypeCarte))]
        [InverseProperty(nameof(Models.EntityFramework.TypeCarte.CartesBleues))]
        public TypeCarte TypeCarte { get; set; } = null!;
    }
}
