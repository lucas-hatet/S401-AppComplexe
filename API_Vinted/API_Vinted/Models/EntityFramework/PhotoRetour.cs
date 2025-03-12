using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("photo_retour")]
    public partial class PhotoRetour
    {

        [Key]
        [Column("idphoto")]
        public int IDPhoto { get; set; }

        [Required]
        [Column("idretour")]
        public int IDRetour { get; set; }

        [ForeignKey(nameof(IDRetour))]
        [InverseProperty(nameof(Retour.Photos))]
        public virtual Retour Retour { get; set; }
    }
}
