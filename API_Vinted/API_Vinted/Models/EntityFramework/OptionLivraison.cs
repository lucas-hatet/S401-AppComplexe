using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class OptionLivraison
    {

        [InverseProperty(nameof(Achat.OptionLivraison))]
        public virtual ICollection<Achat> Achats { get; set; } = null!;

        [InverseProperty(nameof(Retour.Option))]
        public virtual ICollection<Retour> Retours { get; set; } = null!;
    }
}
