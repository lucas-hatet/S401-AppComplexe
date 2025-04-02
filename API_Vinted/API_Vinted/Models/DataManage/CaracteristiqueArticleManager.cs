using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class CaracteristiqueArticleManager : IDataRepository<CaracteristiqueArticle>
    {
        private VintedDBContext _dbContext;

        public CaracteristiqueArticleManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(CaracteristiqueArticle entity)
        {
            await _dbContext.CaracteristiqueArticles.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(CaracteristiqueArticle entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<CaracteristiqueArticle>>> GetAllAsync()
        {
            return await _dbContext.CaracteristiqueArticles.ToListAsync();
        }

        public async Task<ActionResult<CaracteristiqueArticle>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<CaracteristiqueArticle>> GetByIdAsync(int idArticle, int idCaracteristique)
        {
            return await _dbContext.CaracteristiqueArticles.FirstOrDefaultAsync(a => a.IDArticle == idArticle && a.IDCaracteristique == idCaracteristique);
        }


        public Task UpdateAsync(CaracteristiqueArticle entityToUpdate, CaracteristiqueArticle entity)
        {
            throw new NotImplementedException();
        }


        
    }
}
