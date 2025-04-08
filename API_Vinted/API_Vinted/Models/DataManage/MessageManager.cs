using API_Vinted.Models.DTO;
using API_Vinted.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class MessageManager
    {
        private VintedDBContext _dbContext;
        public MessageManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Message entity)
        {
            await _dbContext.Messages.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(Message entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Message>>> GetAllAsync()
        {
            return await _dbContext.Messages.ToListAsync();
        }

        public async Task<ActionResult<IEnumerable<Message>>> GetByIdAsync(int idexpediteur, int idreceveur, int idarticle)
        {
            return await _dbContext.Messages.Where(m => m.IDExpediteur == idexpediteur && m.IDDestinataire == idreceveur && m.IDArticle == idarticle).ToListAsync();
        }

        public async Task<IEnumerable<Conversation>> GetConversationByIdAsync(int idexpediteur)
        {
            var result = await _dbContext.Messages.Where(m => m.IDExpediteur == idexpediteur || m.IDDestinataire == idexpediteur).ToListAsync();
            List<Conversation> idConversation = new List<Conversation>();
            foreach(var message in result)
            {
                //Récup les messages envoyés
                if (!idConversation.Contains( new Conversation(message.IDDestinataire, message.IDArticle)) && message.IDDestinataire != idexpediteur)
                {
                    idConversation.Add(new Conversation(message.IDDestinataire, message.IDArticle));
                }
                //récup les messages reçus
                if (!idConversation.Contains(new Conversation(message.IDExpediteur, message.IDArticle)) && message.IDExpediteur != idexpediteur)
                {
                    idConversation.Add(new Conversation(message.IDExpediteur, message.IDArticle));
                }
            }
            return idConversation;
        }

        public Task UpdateAsync(Message entityToUpdate, Message entity)
        {
            throw new NotImplementedException();
        }
    }
}
