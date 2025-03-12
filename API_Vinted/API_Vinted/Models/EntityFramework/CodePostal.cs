﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("codepostal")]
    public abstract class CodePostal
    {
        [InverseProperty(nameof(Ville.CodePostal))]
        public List<Ville> Villes { get; set; } = null!;

        [Key]
        [Column("codepostal")]
        [StringLength(5)]
        public string CP { get; set; }
    }
}
