using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class ClientManager : IDataRepository<Client>
    {
        private VintedDBContext _dbContext;
        public ClientManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(Client entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Client entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Client>>> GetAllAsync()
        {
            return await _dbContext.Clients.Include(c => c.Articles).ToListAsync();
        }

        public async Task<ActionResult<Client>> GetByIdAsync(int id)
        {
            return await _dbContext.Clients.Include(c => c.Articles).FirstOrDefaultAsync(a => a.IDClient == id);
            
        }

        public Task UpdateAsync(Client entityToUpdate, Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
