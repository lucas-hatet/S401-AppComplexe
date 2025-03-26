using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class CaracteristiqueManager : IDataRepository<Caracteristique>
    {
        private VintedDBContext _dbContext;
        public CaracteristiqueManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(Caracteristique entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Caracteristique entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Caracteristique>>> GetAllAsync()
        {
            return await _dbContext.Caracteristiques.Include(a => a.Valeurs).ToListAsync();
        }

        public async Task<ActionResult<Caracteristique>> GetByIdAsync(int id)
        {
            return await _dbContext.Caracteristiques.Include(a => a.Valeurs).FirstOrDefaultAsync(a => a.IDCaracteristique == id);
        }

        public Task UpdateAsync(Caracteristique entityToUpdate, Caracteristique entity)
        {
            throw new NotImplementedException();
        }
    }
}
