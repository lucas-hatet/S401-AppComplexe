using API_Vinted.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class VilleManager
    {
        private VintedDBContext _dbContext;
        public VilleManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(Ville entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Ville entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Ville>>> GetAllAsync()
        {
            return await _dbContext.Villes.ToListAsync();
        }

        public async Task<ActionResult<Ville>> GetByIdAsync(int id)
        {
            return await _dbContext.Villes.FirstOrDefaultAsync(a => a.IDVille == id);
        }

        public Task UpdateAsync(Ville entityToUpdate, Ville entity)
        {
            throw new NotImplementedException();
        }
    }
}
