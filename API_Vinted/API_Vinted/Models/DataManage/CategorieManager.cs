using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class CategorieManager : IDataRepository<Categorie>
    {
        private VintedDBContext _dbContext;
        public CategorieManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(Categorie entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Categorie entity)
        {
            throw new NotImplementedException();

        }

        public async Task<ActionResult<IEnumerable<Categorie>>> GetAllAsync()
        {
            var res = await _dbContext.Categories.Include(a => a.CategoriesEnfants).ToListAsync();
            var filteredCategories = res.Where(categorie => categorie.IDCategorieParent is null).ToList();

            return filteredCategories;

        }

        public async Task<ActionResult<Categorie>> GetByIdAsync(int id)
        {
            return await _dbContext.Categories.Include(a => a.CategoriesEnfants).FirstOrDefaultAsync(a => a.IDCategorie == id);
        }


        public Task UpdateAsync(Categorie entityToUpdate, Categorie entity)
        {
            throw new NotImplementedException();
        }
    }
}
