using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace API_Vinted.Migrations
{
    /// <inheritdoc />
    public partial class VintedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "caracteristique",
                schema: "public",
                columns: table => new
                {
                    idcaracteristique = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomcaracteristique = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caracteristique", x => x.idcaracteristique);
                });

            migrationBuilder.CreateTable(
                name: "categorie",
                schema: "public",
                columns: table => new
                {
                    idcategorie = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idcategorieparent = table.Column<int>(type: "integer", nullable: true),
                    libellecategorie = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorie", x => x.idcategorie);
                    table.ForeignKey(
                        name: "FK_categorie_categorie_idcategorieparent",
                        column: x => x.idcategorieparent,
                        principalSchema: "public",
                        principalTable: "categorie",
                        principalColumn: "idcategorie");
                });

            migrationBuilder.CreateTable(
                name: "code_postal",
                schema: "public",
                columns: table => new
                {
                    codepostal = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_code_postal", x => x.codepostal);
                });

            migrationBuilder.CreateTable(
                name: "couleur",
                schema: "public",
                columns: table => new
                {
                    idcouleur = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomcouleur = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    codehexa = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_couleur", x => x.idcouleur);
                });

            migrationBuilder.CreateTable(
                name: "etat",
                schema: "public",
                columns: table => new
                {
                    idetat = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    libelleetat = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etat", x => x.idetat);
                });

            migrationBuilder.CreateTable(
                name: "format_colis",
                schema: "public",
                columns: table => new
                {
                    idformat = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    libelleformat = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    fraisdeport = table.Column<float>(type: "real", nullable: true),
                    descriptionformat = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_format_colis", x => x.idformat);
                });

            migrationBuilder.CreateTable(
                name: "langue",
                schema: "public",
                columns: table => new
                {
                    idLangue = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    libellelangue = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_langue", x => x.idLangue);
                });

            migrationBuilder.CreateTable(
                name: "marque",
                schema: "public",
                columns: table => new
                {
                    idmarque = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nommarque = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marque", x => x.idmarque);
                });

            migrationBuilder.CreateTable(
                name: "methode_envoi",
                schema: "public",
                columns: table => new
                {
                    idmethodeenvoi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nommethodeenvoi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    descriptionmethodeenvoi = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_methode_envoi", x => x.idmethodeenvoi);
                });

            migrationBuilder.CreateTable(
                name: "mode_paiement",
                schema: "public",
                columns: table => new
                {
                    idmodepaiement = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    libellemodepaiement = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mode_paiement", x => x.idmodepaiement);
                });

            migrationBuilder.CreateTable(
                name: "option_livraison",
                schema: "public",
                columns: table => new
                {
                    idoption = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    libelleoption = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    descriptionoption = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    frais = table.Column<double>(type: "numeric(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_option_livraison", x => x.idoption);
                });

            migrationBuilder.CreateTable(
                name: "pays",
                schema: "public",
                columns: table => new
                {
                    idpays = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nompays = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pays", x => x.idpays);
                });

            migrationBuilder.CreateTable(
                name: "photo",
                schema: "public",
                columns: table => new
                {
                    idphoto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    urlphoto = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photo", x => x.idphoto);
                });

            migrationBuilder.CreateTable(
                name: "point_relais",
                schema: "public",
                columns: table => new
                {
                    idrelais = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idadresse = table.Column<int>(type: "integer", nullable: false),
                    nomrelais = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_point_relais", x => x.idrelais);
                });

            migrationBuilder.CreateTable(
                name: "sexe",
                schema: "public",
                columns: table => new
                {
                    idsexe = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    libellesexe = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sexe", x => x.idsexe);
                });

            migrationBuilder.CreateTable(
                name: "type_carte",
                schema: "public",
                columns: table => new
                {
                    idtypecarte = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    libelletypecarte = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_carte", x => x.idtypecarte);
                });

            migrationBuilder.CreateTable(
                name: "valeur",
                schema: "public",
                columns: table => new
                {
                    idvaleur = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idcaracteristique = table.Column<int>(type: "integer", nullable: false),
                    valeur = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_valeur", x => x.idvaleur);
                    table.ForeignKey(
                        name: "FK_valeur_caracteristique_idcaracteristique",
                        column: x => x.idcaracteristique,
                        principalSchema: "public",
                        principalTable: "caracteristique",
                        principalColumn: "idcaracteristique",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "caracteristique_categorie",
                schema: "public",
                columns: table => new
                {
                    idcategorie = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idcaracteristique = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caracteristique_categorie", x => new { x.idcategorie, x.idcaracteristique });
                    table.ForeignKey(
                        name: "FK_caracteristique_categorie_caracteristique_idcaracteristique",
                        column: x => x.idcaracteristique,
                        principalSchema: "public",
                        principalTable: "caracteristique",
                        principalColumn: "idcaracteristique",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_caracteristique_categorie_categorie_idcategorie",
                        column: x => x.idcategorie,
                        principalSchema: "public",
                        principalTable: "categorie",
                        principalColumn: "idcategorie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "retour",
                schema: "public",
                columns: table => new
                {
                    idretour = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idoption = table.Column<int>(type: "integer", nullable: true),
                    datedernieredemande = table.Column<DateTime>(type: "Date", nullable: false),
                    demandeexpert = table.Column<bool>(type: "boolean", nullable: false),
                    coderetour = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    datecreation = table.Column<DateTime>(type: "Date", nullable: false),
                    Accepte = table.Column<bool>(type: "boolean", nullable: true),
                    motifretour = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_retour", x => x.idretour);
                    table.ForeignKey(
                        name: "FK_retour_option_livraison_idoption",
                        column: x => x.idoption,
                        principalSchema: "public",
                        principalTable: "option_livraison",
                        principalColumn: "idoption");
                });

            migrationBuilder.CreateTable(
                name: "ville",
                schema: "public",
                columns: table => new
                {
                    idville = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codepostal = table.Column<string>(type: "char(5)", nullable: false),
                    idpays = table.Column<int>(type: "integer", nullable: false),
                    nomville = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ville", x => x.idville);
                    table.ForeignKey(
                        name: "FK_ville_code_postal_codepostal",
                        column: x => x.codepostal,
                        principalSchema: "public",
                        principalTable: "code_postal",
                        principalColumn: "codepostal",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ville_pays_idpays",
                        column: x => x.idpays,
                        principalSchema: "public",
                        principalTable: "pays",
                        principalColumn: "idpays",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "achat",
                schema: "public",
                columns: table => new
                {
                    numtransaction = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idoption = table.Column<int>(type: "integer", nullable: false),
                    idretour = table.Column<int>(type: "integer", nullable: true),
                    idclient = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dateachat = table.Column<DateTime>(type: "Date", nullable: true, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_achat", x => x.numtransaction);
                    table.ForeignKey(
                        name: "FK_achat_option_livraison_idoption",
                        column: x => x.idoption,
                        principalSchema: "public",
                        principalTable: "option_livraison",
                        principalColumn: "idoption",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_achat_retour_idretour",
                        column: x => x.idretour,
                        principalSchema: "public",
                        principalTable: "retour",
                        principalColumn: "idretour");
                });

            migrationBuilder.CreateTable(
                name: "photo_retour",
                schema: "public",
                columns: table => new
                {
                    idphoto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idretour = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photo_retour", x => x.idphoto);
                    table.ForeignKey(
                        name: "FK_photo_retour_retour_idretour",
                        column: x => x.idretour,
                        principalSchema: "public",
                        principalTable: "retour",
                        principalColumn: "idretour",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "adresse",
                schema: "public",
                columns: table => new
                {
                    idadresse = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idville = table.Column<int>(type: "integer", nullable: false),
                    nomcompletadresse = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    numetnomrue = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    adresseligne2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adresse", x => x.idadresse);
                    table.ForeignKey(
                        name: "FK_adresse_ville_idville",
                        column: x => x.idville,
                        principalSchema: "public",
                        principalTable: "ville",
                        principalColumn: "idville",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "client",
                schema: "public",
                columns: table => new
                {
                    idclient = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idville = table.Column<int>(type: "integer", nullable: false),
                    idlangue = table.Column<int>(type: "integer", nullable: true),
                    idadresselivraison = table.Column<int>(type: "integer", nullable: false),
                    idadressefacturation = table.Column<int>(type: "integer", nullable: true),
                    idsexe = table.Column<int>(type: "integer", nullable: false),
                    idphoto = table.Column<int>(type: "integer", nullable: true),
                    pseudo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    mail = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    motdepasse = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    telephone = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    description = table.Column<string>(type: "character varying(350)", maxLength: 350, nullable: true),
                    nomcompteclient = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    datenaissance = table.Column<DateTime>(type: "Date", nullable: true),
                    valeurportemonnaie = table.Column<double>(type: "numeric(18,2)", nullable: false),
                    datederniereconnexion = table.Column<DateTime>(type: "Date", nullable: false),
                    numsiret = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    raisonsociale = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client", x => x.idclient);
                    table.ForeignKey(
                        name: "FK_client_adresse_idadressefacturation",
                        column: x => x.idadressefacturation,
                        principalSchema: "public",
                        principalTable: "adresse",
                        principalColumn: "idadresse");
                    table.ForeignKey(
                        name: "FK_client_adresse_idadresselivraison",
                        column: x => x.idadresselivraison,
                        principalSchema: "public",
                        principalTable: "adresse",
                        principalColumn: "idadresse",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_client_langue_idlangue",
                        column: x => x.idlangue,
                        principalSchema: "public",
                        principalTable: "langue",
                        principalColumn: "idLangue");
                    table.ForeignKey(
                        name: "FK_client_photo_idphoto",
                        column: x => x.idphoto,
                        principalSchema: "public",
                        principalTable: "photo",
                        principalColumn: "idphoto");
                    table.ForeignKey(
                        name: "FK_client_sexe_idsexe",
                        column: x => x.idsexe,
                        principalSchema: "public",
                        principalTable: "sexe",
                        principalColumn: "idsexe",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_client_ville_idville",
                        column: x => x.idville,
                        principalSchema: "public",
                        principalTable: "ville",
                        principalColumn: "idville",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "article",
                schema: "public",
                columns: table => new
                {
                    idarticle = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idvendeur = table.Column<int>(type: "integer", nullable: false),
                    numtransation = table.Column<int>(type: "integer", nullable: true),
                    idcategorie = table.Column<int>(type: "integer", nullable: false),
                    idmodepaiement = table.Column<int>(type: "integer", nullable: false),
                    idformat = table.Column<int>(type: "integer", nullable: false),
                    idmarque = table.Column<int>(type: "integer", nullable: false),
                    nomarticle = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    dateajout = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "NOW()"),
                    description = table.Column<string>(type: "text", nullable: false),
                    prix = table.Column<float>(type: "numeric(18,2)", nullable: false),
                    nbvue = table.Column<int>(type: "integer", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article", x => x.idarticle);
                    table.ForeignKey(
                        name: "FK_article_achat_numtransation",
                        column: x => x.numtransation,
                        principalSchema: "public",
                        principalTable: "achat",
                        principalColumn: "numtransaction");
                    table.ForeignKey(
                        name: "FK_article_categorie_idcategorie",
                        column: x => x.idcategorie,
                        principalSchema: "public",
                        principalTable: "categorie",
                        principalColumn: "idcategorie",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_article_client_idvendeur",
                        column: x => x.idvendeur,
                        principalSchema: "public",
                        principalTable: "client",
                        principalColumn: "idclient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_article_format_colis_idformat",
                        column: x => x.idformat,
                        principalSchema: "public",
                        principalTable: "format_colis",
                        principalColumn: "idformat",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_article_marque_idmarque",
                        column: x => x.idmarque,
                        principalSchema: "public",
                        principalTable: "marque",
                        principalColumn: "idmarque",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_article_mode_paiement_idmodepaiement",
                        column: x => x.idmodepaiement,
                        principalSchema: "public",
                        principalTable: "mode_paiement",
                        principalColumn: "idmodepaiement",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "avis",
                schema: "public",
                columns: table => new
                {
                    idacheteur = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idvendeur = table.Column<int>(type: "integer", nullable: false),
                    note = table.Column<decimal>(type: "numeric(2,1)", nullable: true),
                    description = table.Column<string>(type: "character varying(350)", maxLength: 350, nullable: true),
                    automatique = table.Column<bool>(type: "boolean", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_avis", x => new { x.idacheteur, x.idvendeur });
                    table.ForeignKey(
                        name: "FK_avis_client_idacheteur",
                        column: x => x.idacheteur,
                        principalSchema: "public",
                        principalTable: "client",
                        principalColumn: "idclient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_avis_client_idvendeur",
                        column: x => x.idvendeur,
                        principalSchema: "public",
                        principalTable: "client",
                        principalColumn: "idclient",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "carte_bancaire",
                schema: "public",
                columns: table => new
                {
                    idcarte = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idclient = table.Column<int>(type: "integer", nullable: false),
                    idtypecarte = table.Column<int>(type: "integer", nullable: false),
                    numcartebleue = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    dateexpiration = table.Column<string>(type: "char(5)", nullable: false),
                    titulairecarte = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carte_bancaire", x => x.idcarte);
                    table.ForeignKey(
                        name: "FK_carte_bancaire_client_idclient",
                        column: x => x.idclient,
                        principalSchema: "public",
                        principalTable: "client",
                        principalColumn: "idclient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_carte_bancaire_type_carte_idtypecarte",
                        column: x => x.idtypecarte,
                        principalSchema: "public",
                        principalTable: "type_carte",
                        principalColumn: "idtypecarte",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "compte_bancaire",
                schema: "public",
                columns: table => new
                {
                    idcompte = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idclient = table.Column<int>(type: "integer", nullable: false),
                    iban = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    titulairecompte = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compte_bancaire", x => x.idcompte);
                    table.ForeignKey(
                        name: "FK_compte_bancaire_client_idclient",
                        column: x => x.idclient,
                        principalSchema: "public",
                        principalTable: "client",
                        principalColumn: "idclient",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "envoi_relais",
                schema: "public",
                columns: table => new
                {
                    idclient = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idmethodeenvoi = table.Column<int>(type: "integer", nullable: false),
                    idrelais = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_envoi_relais", x => x.idclient);
                    table.ForeignKey(
                        name: "FK_envoi_relais_client_idclient",
                        column: x => x.idclient,
                        principalSchema: "public",
                        principalTable: "client",
                        principalColumn: "idclient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_envoi_relais_methode_envoi_idmethodeenvoi",
                        column: x => x.idmethodeenvoi,
                        principalSchema: "public",
                        principalTable: "methode_envoi",
                        principalColumn: "idmethodeenvoi",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_envoi_relais_point_relais_idrelais",
                        column: x => x.idrelais,
                        principalSchema: "public",
                        principalTable: "point_relais",
                        principalColumn: "idrelais",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "caracteristique_article",
                schema: "public",
                columns: table => new
                {
                    idarticle = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idcaracteristique = table.Column<int>(type: "integer", nullable: false),
                    idvaleur = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caracteristique_article", x => new { x.idarticle, x.idcaracteristique });
                    table.ForeignKey(
                        name: "FK_caracteristique_article_article_idarticle",
                        column: x => x.idarticle,
                        principalSchema: "public",
                        principalTable: "article",
                        principalColumn: "idarticle",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_caracteristique_article_caracteristique_idcaracteristique",
                        column: x => x.idcaracteristique,
                        principalSchema: "public",
                        principalTable: "caracteristique",
                        principalColumn: "idcaracteristique",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_caracteristique_article_valeur_idvaleur",
                        column: x => x.idvaleur,
                        principalSchema: "public",
                        principalTable: "valeur",
                        principalColumn: "idvaleur",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "couleur_article",
                schema: "public",
                columns: table => new
                {
                    idcouleur = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idarticle = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_couleur_article", x => new { x.idcouleur, x.idarticle });
                    table.ForeignKey(
                        name: "FK_couleur_article_article_idarticle",
                        column: x => x.idarticle,
                        principalSchema: "public",
                        principalTable: "article",
                        principalColumn: "idarticle",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_couleur_article_couleur_idcouleur",
                        column: x => x.idcouleur,
                        principalSchema: "public",
                        principalTable: "couleur",
                        principalColumn: "idcouleur",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etat_article",
                schema: "public",
                columns: table => new
                {
                    idarticle = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idetat = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etat_article", x => new { x.idarticle, x.idetat });
                    table.ForeignKey(
                        name: "FK_etat_article_article_idarticle",
                        column: x => x.idarticle,
                        principalSchema: "public",
                        principalTable: "article",
                        principalColumn: "idarticle",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_etat_article_etat_idetat",
                        column: x => x.idetat,
                        principalSchema: "public",
                        principalTable: "etat",
                        principalColumn: "idetat",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "favori",
                schema: "public",
                columns: table => new
                {
                    idclient = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idarticle = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_favori", x => new { x.idclient, x.idarticle });
                    table.ForeignKey(
                        name: "FK_favori_article_idarticle",
                        column: x => x.idarticle,
                        principalSchema: "public",
                        principalTable: "article",
                        principalColumn: "idarticle",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_favori_client_idclient",
                        column: x => x.idclient,
                        principalSchema: "public",
                        principalTable: "client",
                        principalColumn: "idclient",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "message",
                schema: "public",
                columns: table => new
                {
                    idexpediteur = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    iddestinataire = table.Column<int>(type: "integer", nullable: false),
                    idarticle = table.Column<int>(type: "integer", nullable: false),
                    message = table.Column<string>(type: "text", nullable: false),
                    datemessage = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "NOW()"),
                    prixoffre = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_message", x => new { x.idexpediteur, x.iddestinataire, x.idarticle, x.message, x.datemessage });
                    table.ForeignKey(
                        name: "FK_message_article_idarticle",
                        column: x => x.idarticle,
                        principalSchema: "public",
                        principalTable: "article",
                        principalColumn: "idarticle",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_message_client_iddestinataire",
                        column: x => x.iddestinataire,
                        principalSchema: "public",
                        principalTable: "client",
                        principalColumn: "idclient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_message_client_idexpediteur",
                        column: x => x.idexpediteur,
                        principalSchema: "public",
                        principalTable: "client",
                        principalColumn: "idclient",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "photo_article",
                schema: "public",
                columns: table => new
                {
                    idphoto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idarticle = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photo_article", x => x.idphoto);
                    table.ForeignKey(
                        name: "FK_photo_article_article_idarticle",
                        column: x => x.idarticle,
                        principalSchema: "public",
                        principalTable: "article",
                        principalColumn: "idarticle",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_photo_article_photo_idphoto",
                        column: x => x.idphoto,
                        principalSchema: "public",
                        principalTable: "photo",
                        principalColumn: "idphoto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "signalement",
                schema: "public",
                columns: table => new
                {
                    idclient = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idarticle = table.Column<int>(type: "integer", nullable: false),
                    motifsignalement = table.Column<string>(type: "text", nullable: false),
                    datesignalement = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_signalement", x => new { x.idclient, x.idarticle });
                    table.ForeignKey(
                        name: "FK_signalement_article_idarticle",
                        column: x => x.idarticle,
                        principalSchema: "public",
                        principalTable: "article",
                        principalColumn: "idarticle",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_signalement_client_idclient",
                        column: x => x.idclient,
                        principalSchema: "public",
                        principalTable: "client",
                        principalColumn: "idclient",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_achat_idoption",
                schema: "public",
                table: "achat",
                column: "idoption");

            migrationBuilder.CreateIndex(
                name: "IX_achat_idretour",
                schema: "public",
                table: "achat",
                column: "idretour");

            migrationBuilder.CreateIndex(
                name: "IX_adresse_idville",
                schema: "public",
                table: "adresse",
                column: "idville");

            migrationBuilder.CreateIndex(
                name: "IX_article_idcategorie",
                schema: "public",
                table: "article",
                column: "idcategorie");

            migrationBuilder.CreateIndex(
                name: "IX_article_idformat",
                schema: "public",
                table: "article",
                column: "idformat");

            migrationBuilder.CreateIndex(
                name: "IX_article_idmarque",
                schema: "public",
                table: "article",
                column: "idmarque");

            migrationBuilder.CreateIndex(
                name: "IX_article_idmodepaiement",
                schema: "public",
                table: "article",
                column: "idmodepaiement");

            migrationBuilder.CreateIndex(
                name: "IX_article_idvendeur",
                schema: "public",
                table: "article",
                column: "idvendeur");

            migrationBuilder.CreateIndex(
                name: "IX_article_numtransation",
                schema: "public",
                table: "article",
                column: "numtransation");

            migrationBuilder.CreateIndex(
                name: "IX_avis_idvendeur",
                schema: "public",
                table: "avis",
                column: "idvendeur");

            migrationBuilder.CreateIndex(
                name: "IX_caracteristique_article_idcaracteristique",
                schema: "public",
                table: "caracteristique_article",
                column: "idcaracteristique");

            migrationBuilder.CreateIndex(
                name: "IX_caracteristique_article_idvaleur",
                schema: "public",
                table: "caracteristique_article",
                column: "idvaleur");

            migrationBuilder.CreateIndex(
                name: "IX_caracteristique_categorie_idcaracteristique",
                schema: "public",
                table: "caracteristique_categorie",
                column: "idcaracteristique");

            migrationBuilder.CreateIndex(
                name: "IX_carte_bancaire_idclient",
                schema: "public",
                table: "carte_bancaire",
                column: "idclient");

            migrationBuilder.CreateIndex(
                name: "IX_carte_bancaire_idtypecarte",
                schema: "public",
                table: "carte_bancaire",
                column: "idtypecarte");

            migrationBuilder.CreateIndex(
                name: "IX_categorie_idcategorieparent",
                schema: "public",
                table: "categorie",
                column: "idcategorieparent");

            migrationBuilder.CreateIndex(
                name: "IX_client_idadressefacturation",
                schema: "public",
                table: "client",
                column: "idadressefacturation");

            migrationBuilder.CreateIndex(
                name: "IX_client_idadresselivraison",
                schema: "public",
                table: "client",
                column: "idadresselivraison");

            migrationBuilder.CreateIndex(
                name: "IX_client_idlangue",
                schema: "public",
                table: "client",
                column: "idlangue");

            migrationBuilder.CreateIndex(
                name: "IX_client_idphoto",
                schema: "public",
                table: "client",
                column: "idphoto");

            migrationBuilder.CreateIndex(
                name: "IX_client_idsexe",
                schema: "public",
                table: "client",
                column: "idsexe");

            migrationBuilder.CreateIndex(
                name: "IX_client_idville",
                schema: "public",
                table: "client",
                column: "idville");

            migrationBuilder.CreateIndex(
                name: "IX_compte_bancaire_idclient",
                schema: "public",
                table: "compte_bancaire",
                column: "idclient");

            migrationBuilder.CreateIndex(
                name: "IX_couleur_article_idarticle",
                schema: "public",
                table: "couleur_article",
                column: "idarticle");

            migrationBuilder.CreateIndex(
                name: "IX_envoi_relais_idmethodeenvoi",
                schema: "public",
                table: "envoi_relais",
                column: "idmethodeenvoi");

            migrationBuilder.CreateIndex(
                name: "IX_envoi_relais_idrelais",
                schema: "public",
                table: "envoi_relais",
                column: "idrelais");

            migrationBuilder.CreateIndex(
                name: "IX_etat_article_idetat",
                schema: "public",
                table: "etat_article",
                column: "idetat");

            migrationBuilder.CreateIndex(
                name: "IX_favori_idarticle",
                schema: "public",
                table: "favori",
                column: "idarticle");

            migrationBuilder.CreateIndex(
                name: "IX_message_idarticle",
                schema: "public",
                table: "message",
                column: "idarticle");

            migrationBuilder.CreateIndex(
                name: "IX_message_iddestinataire",
                schema: "public",
                table: "message",
                column: "iddestinataire");

            migrationBuilder.CreateIndex(
                name: "IX_photo_article_idarticle",
                schema: "public",
                table: "photo_article",
                column: "idarticle");

            migrationBuilder.CreateIndex(
                name: "IX_photo_retour_idretour",
                schema: "public",
                table: "photo_retour",
                column: "idretour");

            migrationBuilder.CreateIndex(
                name: "IX_retour_idoption",
                schema: "public",
                table: "retour",
                column: "idoption");

            migrationBuilder.CreateIndex(
                name: "IX_signalement_idarticle",
                schema: "public",
                table: "signalement",
                column: "idarticle");

            migrationBuilder.CreateIndex(
                name: "IX_valeur_idcaracteristique",
                schema: "public",
                table: "valeur",
                column: "idcaracteristique");

            migrationBuilder.CreateIndex(
                name: "IX_ville_codepostal",
                schema: "public",
                table: "ville",
                column: "codepostal");

            migrationBuilder.CreateIndex(
                name: "IX_ville_idpays",
                schema: "public",
                table: "ville",
                column: "idpays");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "avis",
                schema: "public");

            migrationBuilder.DropTable(
                name: "caracteristique_article",
                schema: "public");

            migrationBuilder.DropTable(
                name: "caracteristique_categorie",
                schema: "public");

            migrationBuilder.DropTable(
                name: "carte_bancaire",
                schema: "public");

            migrationBuilder.DropTable(
                name: "compte_bancaire",
                schema: "public");

            migrationBuilder.DropTable(
                name: "couleur_article",
                schema: "public");

            migrationBuilder.DropTable(
                name: "envoi_relais",
                schema: "public");

            migrationBuilder.DropTable(
                name: "etat_article",
                schema: "public");

            migrationBuilder.DropTable(
                name: "favori",
                schema: "public");

            migrationBuilder.DropTable(
                name: "message",
                schema: "public");

            migrationBuilder.DropTable(
                name: "photo_article",
                schema: "public");

            migrationBuilder.DropTable(
                name: "photo_retour",
                schema: "public");

            migrationBuilder.DropTable(
                name: "signalement",
                schema: "public");

            migrationBuilder.DropTable(
                name: "valeur",
                schema: "public");

            migrationBuilder.DropTable(
                name: "type_carte",
                schema: "public");

            migrationBuilder.DropTable(
                name: "couleur",
                schema: "public");

            migrationBuilder.DropTable(
                name: "methode_envoi",
                schema: "public");

            migrationBuilder.DropTable(
                name: "point_relais",
                schema: "public");

            migrationBuilder.DropTable(
                name: "etat",
                schema: "public");

            migrationBuilder.DropTable(
                name: "article",
                schema: "public");

            migrationBuilder.DropTable(
                name: "caracteristique",
                schema: "public");

            migrationBuilder.DropTable(
                name: "achat",
                schema: "public");

            migrationBuilder.DropTable(
                name: "categorie",
                schema: "public");

            migrationBuilder.DropTable(
                name: "client",
                schema: "public");

            migrationBuilder.DropTable(
                name: "format_colis",
                schema: "public");

            migrationBuilder.DropTable(
                name: "marque",
                schema: "public");

            migrationBuilder.DropTable(
                name: "mode_paiement",
                schema: "public");

            migrationBuilder.DropTable(
                name: "retour",
                schema: "public");

            migrationBuilder.DropTable(
                name: "adresse",
                schema: "public");

            migrationBuilder.DropTable(
                name: "langue",
                schema: "public");

            migrationBuilder.DropTable(
                name: "photo",
                schema: "public");

            migrationBuilder.DropTable(
                name: "sexe",
                schema: "public");

            migrationBuilder.DropTable(
                name: "option_livraison",
                schema: "public");

            migrationBuilder.DropTable(
                name: "ville",
                schema: "public");

            migrationBuilder.DropTable(
                name: "code_postal",
                schema: "public");

            migrationBuilder.DropTable(
                name: "pays",
                schema: "public");
        }
    }
}
