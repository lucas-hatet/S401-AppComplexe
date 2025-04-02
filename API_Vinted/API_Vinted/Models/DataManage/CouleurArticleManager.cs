using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class CouleurArticleManager : IDataRepository<CouleurArticle>
    {
        private VintedDBContext _dbContext;

        public CouleurArticleManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(CouleurArticle entity)
        {
            await _dbContext.CouleurArticles.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(CouleurArticle entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<CouleurArticle>>> GetAllAsync()
        {
            return await _dbContext.CouleurArticles.ToListAsync();
        }

        public async Task<ActionResult<CouleurArticle>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<CouleurArticle>> GetByIdAsync(int idArticle, int idCouleur)
        {
            return await _dbContext.CouleurArticles.FirstOrDefaultAsync(a => a.IDArticle == idArticle && a.IDCouleur == idCouleur);
        }


        public Task UpdateAsync(CouleurArticle entityToUpdate, CouleurArticle entity)
        {
            throw new NotImplementedException();
        }


        
    }
}
