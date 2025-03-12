using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    public class Photo
    {
        [InverseProperty(nameof(Client.Photo))]
        public List<Client> Clients { get; set; } = null!;
    }
}
