using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("client")]
    public partial class Client
    {

        [InverseProperty(nameof(Article.Vendeur))]
        public Article Articles { get; set; } = null!;

        [InverseProperty(nameof(Signalement.Client))]
        public List<Signalement> Signalements { get; set; } = null!;
        [Key]
        [Column("idclient")]
        public int IdClient { get; set; }

        [Required]
        [Column("idville")]
        public int IdVille { get; set; }

        [Column("idlangue")]
        public int IdLangue { get; set; }

        [Required]
        [Column("idadresselivraison")]
        public int IdAdresseLivraison { get; set; }

        [Column("idadressefacturation")]
        public int IdAdresseFacturation { get; set; }

        [Required]
        [Column("idsexe")]
        public int IdSexe { get; set; }

        [Column("idphoto")]
        public int IdPhoto { get; set; }

        [Required]
        [Column("pseudo")]
        [StringLength(30)]
        public string Pseudo { get; set; }

        [Required]
        [Column("mail")]
        [StringLength(50)]
        public string Mail { get; set; }

        [Required]
        [Column("motdepasse")]
        [StringLength(100)]
        public string MotDePasse { get; set; }
        
        [Required]
        [Column("telephone")]
        [StringLength(11)]
        public string Telephone { get; set; }


        [Column("description")]
        [StringLength(300)]
        public string Description { get; set; }

        [Column("nomcompteclient")]
        [StringLength(50)]
        public string NomCompteClient { get; set; }

        [Column("datenaissance", TypeName = "Date")]
        public DateTime DateNaissance { get; set; }

        [Required]
        [Column("valeurportemonnaie", TypeName = "Numeric(18, 2)")]
        public double ValeurPorteMonnaie { get; set; }

        [Required]
        [Column("datederniereconnexion", TypeName = "Date")]
        public string DateDerniereConnexion { get; set; }

        [Required]
        [Column("numsiret")]
        [StringLength(300)]
        public string NumSiret { get; set; }

        [Column("raisonsociale")]
        [StringLength(100)]
        public string RaisonSociale { get; set; }
        

        [ForeignKey(nameof(IdVille))]
        [InverseProperty(nameof(Ville.Adresses))]
        public Ville Ville { get; set; } = null!;

        // Langue, ...
    }
}
