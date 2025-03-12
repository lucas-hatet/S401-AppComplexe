using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class TypeCarte
    {
        [InverseProperty(nameof(CarteBleue.TypeCarte))]
        public List<CarteBleue> CartesBleues { get; set; } = null!;
    }
}
