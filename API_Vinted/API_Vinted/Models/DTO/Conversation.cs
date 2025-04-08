namespace API_Vinted.Models.DTO
{
    public class Conversation
    {
        public Conversation(int iDClient, int iDArticle)
        {
            IDClient = iDClient;
            IDArticle = iDArticle;
        }

        public int IDClient { get; set; }
        public int IDArticle { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Conversation conversation &&
                   IDClient == conversation.IDClient &&
                   IDArticle == conversation.IDArticle;
        }
    }
}
