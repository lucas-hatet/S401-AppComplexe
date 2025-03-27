using API_Vinted.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class LangueManager
    {
        private VintedDBContext _dbContext;
        public LangueManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(Langue entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Langue entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Langue>>> GetAllAsync()
        {
            return await _dbContext.Langues.ToListAsync();
        }

        public async Task<ActionResult<Langue>> GetByIdAsync(int id)
        {
            return await _dbContext.Langues.FirstOrDefaultAsync(a => a.IDLangue == id);
        }

        public Task UpdateAsync(Langue entityToUpdate, Langue entity)
        {
            throw new NotImplementedException();
        }
    }
}
