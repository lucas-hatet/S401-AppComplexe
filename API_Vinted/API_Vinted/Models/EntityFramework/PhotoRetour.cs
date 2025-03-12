﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("photo_retour")]
    public class PhotoRetour
    {

        [Key]
        [Column("idphoto")]
        public int IDPhoto { get; set; }

        [Column("idretour")]
        public int IDRetour { get; set; }

        [ForeignKey(nameof(IDRetour))]
        [InverseProperty(nameof(Retour.Photos))]
        public virtual Retour Retour { get; set; }
    }
}
