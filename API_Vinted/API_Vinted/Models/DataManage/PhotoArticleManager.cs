using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class PhotoArticleManager : IDataRepository<PhotoArticle>
    {
        private readonly VintedDBContext _dbContext;

        public PhotoArticleManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(PhotoArticle entity)
        {
            _dbContext.PhotoArticles.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(PhotoArticle entity)
        {
            _dbContext.PhotoArticles.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<ActionResult<IEnumerable<PhotoArticle>>> GetAllAsync()
        {
            return await _dbContext.PhotoArticles.ToListAsync();
        }

        public async Task<ActionResult<PhotoArticle>> GetByIdAsync(int id)
        {

            return await _dbContext.PhotoArticles.FirstOrDefaultAsync(m => m.IDPhoto == id);
        }

        public async Task UpdateAsync(PhotoArticle existingEntity, PhotoArticle updatedEntity)
        {
            _dbContext.Entry(existingEntity).CurrentValues.SetValues(updatedEntity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
