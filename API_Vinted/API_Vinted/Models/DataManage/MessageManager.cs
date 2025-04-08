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

        public async Task<IEnumerable<(int,int)>> GetConversationByIdAsync(int idexpediteur)
        {
            var result = await _dbContext.Messages.Where(m => m.IDExpediteur == idexpediteur || m.IDDestinataire == idexpediteur).ToListAsync();
            List<(int, int)> idConversation = new List<(int,int)>();
            foreach(var message in result)
            {
                //Récup les messages envoyés
                if (!idConversation.Contains( (message.IDDestinataire, message.IDArticle)) && message.IDDestinataire != idexpediteur)
                {
                    idConversation.Add((message.IDDestinataire, message.IDArticle));
                }
                //récup les messages reçus
                if (!idConversation.Contains((message.IDExpediteur, message.IDArticle)) && message.IDExpediteur != idexpediteur)
                {
                    idConversation.Add((message.IDExpediteur, message.IDArticle));
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
