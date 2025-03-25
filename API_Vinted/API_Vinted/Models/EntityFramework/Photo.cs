
﻿using System.ComponentModel.DataAnnotations.Schema;

﻿using System.ComponentModel.DataAnnotations;


namespace API_Vinted.Models.EntityFramework
{
    [Table("photo")]
    public partial class Photo
    {

        [InverseProperty(nameof(Client.Photo))]
        public virtual ICollection<Client> Clients { get; set; } = null!;
        [InverseProperty(nameof(PhotoArticle.Photo))]
        public virtual ICollection<PhotoArticle> PhotoArticles { get; set; } = null!;

        [Key]
        [Column("idphoto")]
        public int IDPhoto { get; set; }

        [Required]
        [Column("urlphoto")]
        public string URLPhoto { get; set; } = null!;

    }
}
