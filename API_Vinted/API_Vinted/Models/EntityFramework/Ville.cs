using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class Ville
    {
        [InverseProperty(nameof(Adresse.Ville))]
        public List<Adresse> Adresses { get; set; } = null!;
    }
}
