using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("avis")]
    [PrimaryKey("IDAcheteur", "IDVendeur")]
    public partial class Avis
    {
        [Key]
        [Column("idacheteur")]
        public int IDAcheteur { get; set; }

        [Key]
        [Column("idvendeur")]
        public int IDVendeur { get; set; }

        [Column("note", TypeName ="numeric(2,1)")]
        public int Note{ get; set; }

        [Column("description")]
        [StringLength(350)]
        public string Description{ get; set; }

        [Column("automatique")]
        public bool Automatique { get; set; }

        [ForeignKey(nameof(IDAcheteur))]
        [InverseProperty(nameof(Client.AvisMis))]
        public Client Acheteur { get; set; } = null!;

        [ForeignKey(nameof(IDVendeur))]
        [InverseProperty(nameof(Client.AvisSur))]
        public Client Vendeur { get; set; } = null!;
    }
}
