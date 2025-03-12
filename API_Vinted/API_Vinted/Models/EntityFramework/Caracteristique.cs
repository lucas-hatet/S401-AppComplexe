using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class Caracteristique
    {
        [InverseProperty(nameof(Valeur.Caracteristique))]
        public List<Valeur> Valeurs { get; set; } = null!;
    }
}
