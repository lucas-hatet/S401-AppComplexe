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
        [InverseProperty(nameof(Models.EntityFramework.Client.EnvoisRelais))]
        public virtual Client Client { get; set; } = null!;

        [ForeignKey(nameof(IDMethodeEnvoi))]
        [InverseProperty(nameof(Models.EntityFramework.MethodeEnvoi.EnvoisRelais))]
        public virtual MethodeEnvoi MethodeEnvoi { get; set; } = null!;

        [ForeignKey(nameof(IDRelais))]
        [InverseProperty(nameof(Models.EntityFramework.PointRelais.EnvoisRelais))]
        public virtual PointRelais PointRelais { get; set; } = null!;
    }
}
