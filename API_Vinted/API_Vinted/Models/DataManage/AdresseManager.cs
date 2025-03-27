using API_Vinted.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class AdresseManager
    {
        private VintedDBContext _dbContext;
        public AdresseManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Adresse entity)
        {
            await _dbContext.Adresses.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(Adresse entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Adresse>>> GetAllAsync()
        {
            return await _dbContext.Adresses.ToListAsync();
        }

        public async Task<ActionResult<Adresse>> GetByIdAsync(int id)
        {
            return await _dbContext.Adresses.FirstOrDefaultAsync(a => a.IDAdresse == id);
        }

        public Task UpdateAsync(Adresse entityToUpdate, Adresse entity)
        {
            throw new NotImplementedException();
        }
    }
}
