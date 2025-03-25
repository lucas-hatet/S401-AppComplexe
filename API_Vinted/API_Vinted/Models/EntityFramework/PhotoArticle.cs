using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("photo_article")]
    public partial class PhotoArticle
    {
        [Key]
        [Column("idphoto")]
        public int IDPhoto { get; set; }

        [Required]
        [Column("idarticle")]
        public int IDArticle { get; set; }

        [ForeignKey(nameof(IDArticle))]
        [InverseProperty(nameof(Models.EntityFramework.Article.Photos))]
        public virtual Article Article { get; set; } = null!;

        [ForeignKey(nameof(IDPhoto))]
        [InverseProperty(nameof(Models.EntityFramework.Photo.PhotoArticles))]
        public virtual Photo Photo { get; set; } = null!;
    }
}
