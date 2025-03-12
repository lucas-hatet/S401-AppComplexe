using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("envoi_relais")]
    public partial class EnvoiRelais
    {
        [Key]
        [Column("idclient")]
        public int IDClient { get; set; }

        [Required]
        [Column("idmethodeenvoi")]
        public int IDMethodeEnvoi { get; set; }

        [Column("idrelais")]
        public int IDRelais { get; set; }


        [ForeignKey(nameof(IDClient))]
        [InverseProperty(nameof(Client.EnvoisRelais))]
        public virtual Client Client { get; set; } = null!;

        [ForeignKey(nameof(IDMethodeEnvoi))]
        [InverseProperty(nameof(MethodeEnvoi.EnvoisRelais))]
        public virtual MethodeEnvoi MethodeEnvoi { get; set; } = null!;

        [ForeignKey(nameof(IDRelais))]
        [InverseProperty(nameof(PointRelais.EnvoisRelais))]
        public virtual PointRelais PointRelais { get; set; } = null!;
    }
}
