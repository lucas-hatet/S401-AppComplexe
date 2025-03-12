using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class OptionLivraison
    {

        [InverseProperty(nameof(Achat.OptionLivraison))]
        public List<Achat> Achats { get; set; } = null!;

        [InverseProperty(nameof(Retour.Option))]
        public List<Retour> Retours { get; set; } = null!;
    }
}
