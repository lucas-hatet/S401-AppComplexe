﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Vinted.Models.EntityFramework
{
    [Table("article")]
    public partial class Article
    {
        [InverseProperty(nameof(EtatArticle.Article))]
        public virtual List<EtatArticle>? EtatsArticles { get; set; } = null!;

        [Key]
        [Column("idarticle")]
        public int IDArticle { get; set; }

        [Required]
        [Column("idvendeur")]
        public int IDVendeur { get; set; }

        [Column("numtransation")]  
        public int? NumTransaction { get; set; }

        [Required]
        [Column("idcategorie")]
        public int IDCategorie { get; set; }

        [Required]
        [Column("idmodepaiement")]
        public int IDModePaiement { get; set; }

        [Required]
        [Column("idformat")]
        public int IDFormat { get; set; }

        [Required]
        [Column("idmarque")]
        public int IDMarque { get; set; }

        [Column("nomarticle")]
        [StringLength(50)]
        public string NomArticle { get; set; } = null!;

        [Column("dateajout", TypeName = "Date")]
        [Required]
        public DateTime DateAjout { get; set; }

        [Column("description")]
        public string Description { get; set; } = null!;

        [Column("prix", TypeName ="numeric(18,2)")]
        [Required]
        public float Prix{ get; set; }

        [Column("nbvue")]
        [Required]
        public int NBVue { get; set; }

        [ForeignKey(nameof(IDVendeur))]
        [InverseProperty(nameof(Client.Articles))]
        public virtual Client? Vendeur { get; set; } = null!;

        [ForeignKey(nameof(NumTransaction))]
        [InverseProperty(nameof(Models.EntityFramework.Achat.Articles))]
        public virtual Achat? Achat { get; set; } = null!;

        [ForeignKey(nameof(IDCategorie))]
        [InverseProperty(nameof(Models.EntityFramework.Categorie.Articles))]
        public virtual Categorie? Categorie { get; set; } = null!;

        [ForeignKey(nameof(IDModePaiement))]
        [InverseProperty(nameof(Models.EntityFramework.ModePaiement.Articles))]
        public virtual ModePaiement? ModePaiement { get; set; } = null!;

        [ForeignKey(nameof(IDFormat))]
        [InverseProperty(nameof(Models.EntityFramework.FormatColis.Articles))]
        public virtual FormatColis? FormatColis { get; set; } = null!;

        [ForeignKey(nameof(IDMarque))]
        [InverseProperty(nameof(Models.EntityFramework.Marque.Articles))]
        public virtual Marque? Marque { get; set; } = null!;

        [InverseProperty(nameof(Signalement.Article))]
        public virtual ICollection<Signalement>? Signalements { get; set; } = null!;

        [InverseProperty(nameof(CaracteristiqueArticle.Article))]
        public virtual ICollection<CaracteristiqueArticle>? CaracteristiquesArticle { get; set; } = null!;

        [InverseProperty(nameof(PhotoArticle.Article))]
        public virtual ICollection<PhotoArticle>? Photos { get; set; } = null!;
        
        [InverseProperty(nameof(Message.Article))]
        public virtual ICollection<Message>? Messages { get; set; } = null!;

        [InverseProperty(nameof(Favori.Article))]
        public virtual ICollection<Favori>? Favoris { get; set; } = null!;

        [InverseProperty(nameof(CouleurArticle.Article))]
        public virtual ICollection<CouleurArticle>? CouleursArticle { get; set; } = null!;
    }
}
