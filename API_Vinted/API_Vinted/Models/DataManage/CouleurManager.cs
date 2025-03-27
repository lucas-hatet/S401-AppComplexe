using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class CouleurManager : IDataRepository<Couleur>
    {
        private VintedDBContext _dbContext;
        public CouleurManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(Couleur entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Couleur entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Couleur>>> GetAllAsync()
        {
            return await _dbContext.Couleurs.ToListAsync();
        }

        public async Task<ActionResult<Couleur>> GetByIdAsync(int id)
        {
            return await _dbContext.Couleurs.FirstOrDefaultAsync(a => a.IDCouleur == id);
        }

        public Task UpdateAsync(Couleur entityToUpdate, Couleur entity)
        {
            throw new NotImplementedException();
        }
    }
}
