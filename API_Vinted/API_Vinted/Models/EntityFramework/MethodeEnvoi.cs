using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("methode_envoi")]
    public class MethodeEnvoi
    {
        [Key]
        [Column("idmethodeenvoi")]
        public int IDMethodeEnvoi { get; set; }

        [Column("nommethodeenvoi")]
        [StringLength(50)]
        public string NomMethodeEnvoi { get; set; } = null!;

        [Column("descriptionmethodeenvoi")]
        [StringLength(200)]
        public string DescriptionMethodeEnvoi { get; set; } = null!;



        [InverseProperty(nameof(EnvoiRelais.MethodeEnvoi))]
        public virtual List<EnvoiRelais> EnvoisRelais { get; set; } = null!;

    }
}
