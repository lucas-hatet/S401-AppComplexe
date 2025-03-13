using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Vinted.Models.EntityFramework
{
    [Table("client")]
    public partial class Client
    {
        [InverseProperty(nameof(Article.Vendeur))]
        public virtual ICollection<Article> Articles { get; set; } = null!;

        [InverseProperty(nameof(Avis.Vendeur))]
        public virtual ICollection<Avis> AvisSur { get; set; } = null!;

        [InverseProperty(nameof(Avis.Acheteur))] 
        public virtual ICollection<Avis> AvisMis { get; set; } = null!;

        [InverseProperty(nameof(CarteBleue.Client))]
        public virtual ICollection<CarteBleue> CartesBleues { get; set; } = null!;

        [InverseProperty(nameof(Signalement.Client))]
        public virtual ICollection<Signalement> Signalements { get; set; } = null!;

        [InverseProperty(nameof(CompteBancaire.Client))]
        public virtual ICollection<CompteBancaire> CompteBancaires { get; set; } = null!;

        [InverseProperty(nameof(EnvoiRelais.Client))]
        public virtual ICollection<EnvoiRelais> EnvoisRelais { get; set; } = null!;


        [Key]
        [Column("idclient")]
        public int IDClient { get; set; }

        [Required]
        [Column("idville")]
        public int IDVille { get; set; }

        [Column("idlangue")]
        public int? IDLangue { get; set; }

        [Required]
        [Column("idadresselivraison")]
        public int IDAdresseLivraison { get; set; }

        [Column("idadressefacturation")]
        public int? IDAdresseFacturation { get; set; }

        [Required]
        [Column("idsexe")]
        public int IDSexe { get; set; }

        [Column("idphoto")]
        public int? IDPhoto { get; set; }

        [Required]
        [Column("pseudo")]
        [StringLength(100)]
        public string Pseudo { get; set; } = null!;

        [Required]
        [Column("mail")]
        [StringLength(50)]
        public string Mail { get; set; } = null!;

        [Required]
        [Column("motdepasse")]
        [StringLength(100)]
        public string MotDePasse { get; set; } = null!;

        [Required]
        [Column("telephone")]
        [StringLength(11)]
        public string Telephone { get; set; } = null!;


        [Column("description")]
        [StringLength(350)]
        public string? Description { get; set; }

        [Column("nomcompteclient")]
        [StringLength(300)]
        public string? NomCompteClient { get; set; }

        [Column("datenaissance", TypeName = "Date")]
        public DateTime? DateNaissance { get; set; }

        [Required]
        [Column("valeurportemonnaie", TypeName = "Numeric(18, 2)")]
        public double ValeurPorteMonnaie { get; set; }

        [Required]
        [Column("datederniereconnexion", TypeName = "Date")]
        public DateTime DateDerniereConnexion { get; set; }

        [Column("numsiret")]
        [StringLength(300)]
        public string? NumSiret { get; set; }

        [Column("raisonsociale")]
        [StringLength(100)]
        public string? RaisonSociale { get; set; }
        

        [ForeignKey(nameof(IDVille))]
        [InverseProperty(nameof(Models.EntityFramework.Ville.Clients))]
        public virtual Ville Ville { get; set; } = null!;

        [ForeignKey(nameof(IDLangue))]
        [InverseProperty(nameof(Models.EntityFramework.Langue.Clients))]
        public virtual Langue Langue { get; set; } = null!;

        [ForeignKey(nameof(IDAdresseLivraison))]
        [InverseProperty(nameof(Adresse.ClientAdresseLivraison))]
        public virtual Adresse AdresseLivraison { get; set; } = null!;

        [ForeignKey(nameof(IDAdresseFacturation))]
        [InverseProperty(nameof(Adresse.ClientAdresseFacturation))]
        public virtual Adresse AdresseFacturation { get; set; } = null!;

        [ForeignKey(nameof(IDSexe))]
        [InverseProperty(nameof(Models.EntityFramework.Sexe.Clients))]
        public virtual Sexe Sexe { get; set; } = null!;

        [ForeignKey(nameof(IDPhoto))]
        [InverseProperty(nameof(Models.EntityFramework.Photo.Clients))]
        public virtual Photo Photo { get; set; } = null!;

        [InverseProperty(nameof(Message.Expediteur))]
        public virtual ICollection<Message> MessagesEnvoyes { get; set; } = null!;

        [InverseProperty(nameof(Message.Destinataire))]
        public virtual ICollection<Message> MessagesRecus { get; set; } = null!;

        [InverseProperty(nameof(Favori.Client))]
        public virtual ICollection<Favori> Favoris { get; set; } = null!;
    }
}
