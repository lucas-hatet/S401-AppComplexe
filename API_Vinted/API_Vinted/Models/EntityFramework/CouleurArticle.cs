﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("couleur")]
    [PrimaryKey("IDCouleur", "IDArticle")]
    public partial class CouleurArticle
    {
        [Key]
        [Column("idcouleur")]
        public int IDCouleur { get; set; }

        [Key]
        [Required]
        [Column("idarticle")]
        public int IDArticle { get; set; }


        [ForeignKey(nameof(IDCouleur))]
        [InverseProperty(nameof(Couleur.CouleursArticle))]
        public virtual Couleur Couleur { get; set; } = null!;

        
    }
}
