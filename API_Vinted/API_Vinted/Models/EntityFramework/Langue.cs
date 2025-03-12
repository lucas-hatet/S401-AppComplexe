using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("langue")]
    public class Langue
    {
            [Key]
            [Column("IDLangue")]
            public int IDLangue { get; set; }

            [Column("libellelangue")]
            [StringLength(50)]
            public string Libellelangue { get; set; } = null!;

        }
}
