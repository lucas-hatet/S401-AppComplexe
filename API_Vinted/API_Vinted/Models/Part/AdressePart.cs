
namespace API_Vinted.Models.EntityFramework
{
    public partial class Adresse
    {
        public override bool Equals(object? obj)
        {
            return obj is Adresse adresse &&
                   EqualityComparer<ICollection<Client>?>.Default.Equals(ClientAdresseLivraison, adresse.ClientAdresseLivraison) &&
                   EqualityComparer<ICollection<Client>?>.Default.Equals(ClientAdresseFacturation, adresse.ClientAdresseFacturation) &&
                   IDAdresse == adresse.IDAdresse &&
                   IDVille == adresse.IDVille &&
                   NomCompletAdresse == adresse.NomCompletAdresse &&
                   NumEtNomRue == adresse.NumEtNomRue &&
                   AdresseLigne2 == adresse.AdresseLigne2 &&
                   EqualityComparer<Ville?>.Default.Equals(Ville, adresse.Ville);
        }
    }
}
