using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class MarqueManager : IDataRepository<Marque>
    {
        private readonly VintedDBContext _dbContext;

        public MarqueManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Marque entity)
        {
            _dbContext.Marque.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Marque entity)
        {
            _dbContext.Marque.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<ActionResult<IEnumerable<Marque>>> GetAllAsync()
        {
            return await _dbContext.Marque.ToListAsync();
        }

        public async Task<ActionResult<Marque>> GetByIdAsync(int id)
        {

            return await _dbContext.Marque.FirstOrDefaultAsync(m => m.IDMarque == id);
        }

        public async Task UpdateAsync(Marque existingEntity, Marque updatedEntity)
        {
            _dbContext.Entry(existingEntity).CurrentValues.SetValues(updatedEntity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
