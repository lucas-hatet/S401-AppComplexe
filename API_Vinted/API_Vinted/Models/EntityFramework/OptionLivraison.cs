using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class OptionLivraison
    {

        [InverseProperty(nameof(Achat.OptionLivraison))]
        public List<Achat> Achats { get; set; } = null!;
    }
}
