using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class Retour
    {
        [InverseProperty(nameof(Achat.Retours))]
        public Achat Achats { get; set; } = null!;
    }
}
