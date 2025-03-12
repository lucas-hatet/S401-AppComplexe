using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public partial class Langue
    {
        [InverseProperty(nameof(Client.Langue))]
        public ICollection<Client> Clients { get; set; } = null!;
    }
}
