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
        public Task AddAsync(Article entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Article entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Article>>> GetAllAsync()
        {
            return await _dbContext.Articles.Include(a => a.Vendeur).Include(a => a.Marque).ToListAsync();
        }

        public async Task<ActionResult<Article>> GetByIdAsync(int id)
        {
            return await _dbContext.Articles.Include(a => a.Vendeur).Include(a => a.Marque).FirstOrDefaultAsync(a => a.IDArticle == id);
        }

        public Task UpdateAsync(Article entityToUpdate, Article entity)
        {
            throw new NotImplementedException();
        }
    }
}
