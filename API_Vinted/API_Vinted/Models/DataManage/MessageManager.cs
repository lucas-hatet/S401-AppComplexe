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

        public async Task<ActionResult<IEnumerable<int>>> GetConversationByIdAsync(int idexpediteur)
        {
            var result = await _dbContext.Messages.Where(m => m.IDExpediteur == idexpediteur || m.IDDestinataire == idexpediteur).ToListAsync();
            List<int> idConversation = new List<int>();
            foreach(var message in result)
            {
                if (!idConversation.Contains(message.IDDestinataire) && message.IDDestinataire != idexpediteur)
                {
                    idConversation.Add(message.IDDestinataire);
                }
                if (!idConversation.Contains(message.IDExpediteur) && message.IDExpediteur != idexpediteur)
                {
                    idConversation.Add(message.IDExpediteur);
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
