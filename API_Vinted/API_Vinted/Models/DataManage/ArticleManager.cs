using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class ArticleManager : IDataRepository<Article>
    {
        private VintedDBContext _dbContext;
        public ArticleManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Article entity)
        {
            await _dbContext.Articles.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(Article entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Article>>> GetAllAsync()
        {
            return await _dbContext.Articles.Include(a => a.Vendeur).ToListAsync();
        }

        public async Task<ActionResult<Article>> GetByIdAsync(int id)
        {
            return await _dbContext.Articles.Include(a => a.Vendeur).FirstOrDefaultAsync(a => a.IDArticle == id);
        }

        public Task UpdateAsync(Article entityToUpdate, Article entity)
        {
            throw new NotImplementedException();
        }
    }
}
