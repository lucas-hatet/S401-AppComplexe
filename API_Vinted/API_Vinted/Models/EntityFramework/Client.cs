using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Vinted.Models.EntityFramework
{
    [Table("client")]
    public partial class Client
    {

        [InverseProperty(nameof(Article.Vendeur))]
        public List<Article> Articles { get; set; } = null!;

        [InverseProperty(nameof(Avis.Vendeur))]
        public List<Avis> AvisSur { get; set; } = null!;

        [InverseProperty(nameof(Avis.Acheteur))] 
        public List<Avis> AvisMis { get; set; } = null!;

        [InverseProperty(nameof(CarteBleue.Client))]
        public List<CarteBleue> CartesBleues { get; set; } = null!;

        [InverseProperty(nameof(Signalement.Client))]
        public List<Signalement> Signalements { get; set; } = null!;


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
        public Ville Ville { get; set; } = null!;

        [ForeignKey(nameof(IDLangue))]
        [InverseProperty(nameof(Langue.Clients))]
        public Langue Langue { get; set; } = null!;

        [ForeignKey(nameof(IDAdresseLivraison))]
        [InverseProperty(nameof(Adresse.ClientAdresseLivraison))]
        public Adresse AdresseLivraison { get; set; } = null!;

        [ForeignKey(nameof(IDAdresseFacturation))]
        [InverseProperty(nameof(Adresse.ClientAdresseFacturation))]
        public Adresse AdresseFacturation { get; set; } = null!;

        [ForeignKey(nameof(IDSexe))]
        [InverseProperty(nameof(Sexe.Clients))]
        public Sexe Sexe { get; set; } = null!;

        [ForeignKey(nameof(IDPhoto))]
        [InverseProperty(nameof(Photo.Clients))]
        public Photo Photo { get; set; } = null!;

        [InverseProperty(nameof(Message.Expediteur))]
        public virtual ICollection<Message> MessagesEnvoyes { get; set; } = null!;

        [InverseProperty(nameof(Message.Destinataire))]
        public virtual ICollection<Message> MessagesRecus { get; set; } = null!;

        [InverseProperty(nameof(Favori.Client))]
        public virtual ICollection<Favori> Favoris { get; set; } = null!;
    }
}
