using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class Pays
    {
        [InverseProperty(nameof(Ville.Pays))]
        public List<Ville> Villes { get; set; } = null!;
    }
}
