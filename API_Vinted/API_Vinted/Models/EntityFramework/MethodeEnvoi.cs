using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public abstract class MethodeEnvoi
    {

        [InverseProperty(nameof(EnvoiRelais.MethodeEnvoi))]
        public virtual List<EnvoiRelais> EnvoisRelais { get; set; } = null!;

    }
}
