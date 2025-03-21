﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_Vinted.Models.EntityFramework
{
    [Table("point_relais")]
    public partial class PointRelais
    {
        [InverseProperty(nameof(EnvoiRelais.PointRelais))]
        public virtual ICollection<EnvoiRelais> EnvoisRelais { get; set; } = null!;

        [Key]
        [Column("idrelais")]
        public int IDRelais { get; set; }

        [Required]
        [Column("idadresse")]
        public int IDAdresse { get; set; }

        [Required]
        [Column("nomrelais")]
        [StringLength(50)]
        public string nomrelais { get; set; } = null!;
    }
}
