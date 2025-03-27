using API_Vinted.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class SexeManager
    {
        private VintedDBContext _dbContext;
        public SexeManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(Sexe entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Sexe entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Sexe>>> GetAllAsync()
        {
            return await _dbContext.Sexes.ToListAsync();
        }

        public async Task<ActionResult<Sexe>> GetByIdAsync(int id)
        {
            return await _dbContext.Sexes.FirstOrDefaultAsync(a => a.IDSexe == id);
        }

        public Task UpdateAsync(Sexe entityToUpdate, Sexe entity)
        {
            throw new NotImplementedException();
        }
    }
}
