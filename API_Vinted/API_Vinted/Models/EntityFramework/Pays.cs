using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class Pays
    {
        [InverseProperty(nameof(Ville.Pays))]
        public virtual ICollection<Ville> Villes { get; set; } = null!;
    }
}
