using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("client")]
    public abstract class Client
    {

        [InverseProperty(nameof(Article.Vendeur))]
        public virtual List<Article> Articles { get; set; } = null!;

        [InverseProperty(nameof(Avis.Vendeur))]
        public virtual List<Avis> AvisSur { get; set; } = null!;

        [InverseProperty(nameof(Avis.Acheteur))] 
        public virtual List<Avis> AvisMis { get; set; } = null!;

        [InverseProperty(nameof(CarteBleue.Client))]
        public virtual List<CarteBleue> CartesBleues { get; set; } = null!;

        [InverseProperty(nameof(Signalement.Client))]
        public virtual List<Signalement> Signalements { get; set; } = null!;

        [InverseProperty(nameof(CompteBancaire.Client))]
        public virtual List<CompteBancaire> CompteBancaires { get; set; } = null!;

        [InverseProperty(nameof(EnvoiRelais.Client))]
        public virtual List<EnvoiRelais> EnvoisRelais { get; set; } = null!;


        [Key]
        [Column("idclient")]
        public int IDClient { get; set; }

        [Required]
        [Column("idville")]
        public int IDVille { get; set; }

        [Column("idlangue")]
        public int IDLangue { get; set; }

        [Required]
        [Column("idadresselivraison")]
        public int IDAdresseLivraison { get; set; }

        [Column("idadressefacturation")]
        public int IDAdresseFacturation { get; set; }

        [Required]
        [Column("idsexe")]
        public int IDSexe { get; set; }

        [Column("idphoto")]
        public int IDPhoto { get; set; }

        [Required]
        [Column("pseudo")]
        [StringLength(30)]
        public string Pseudo { get; set; } = null!;

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
        public DateTime DateDerniereConnexion { get; set; }

        [Required]
        [Column("numsiret")]
        [StringLength(300)]
        public string NumSiret { get; set; }

        [Column("raisonsociale")]
        [StringLength(100)]
        public string RaisonSociale { get; set; }
        

        [ForeignKey(nameof(IDVille))]
        [InverseProperty(nameof(Ville.Clients))]
        public virtual Ville Ville { get; set; } = null!;

        [ForeignKey(nameof(IDLangue))]
        [InverseProperty(nameof(Langue.Clients))]
        public virtual Langue Langue { get; set; } = null!;

        [ForeignKey(nameof(IDAdresseLivraison))]
        [InverseProperty(nameof(Adresse.ClientAdresseLivraison))]
        public virtual Adresse AdresseLivraison { get; set; } = null!;

        [ForeignKey(nameof(IDAdresseFacturation))]
        [InverseProperty(nameof(Adresse.ClientAdresseFacturation))]
        public virtual Adresse AdresseFacturation { get; set; } = null!;

        [ForeignKey(nameof(IDSexe))]
        [InverseProperty(nameof(Sexe.Clients))]
        public virtual Sexe Sexe { get; set; } = null!;

        [ForeignKey(nameof(IDPhoto))]
        [InverseProperty(nameof(Photo.Clients))]
        public virtual Photo Photo { get; set; } = null!;
    }
}
