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
            return await _dbContext.Articles.Include(a => a.Vendeur).Include(a => a.Marque).Include(a => a.Photos).ThenInclude(pa => pa.Photo).ToListAsync();
        }

        public async Task<ActionResult<Article>> GetByIdAsync(int id)
        {
            return await _dbContext.Articles.Include(a => a.Vendeur).Include(a => a.Marque).Include(a => a.Photos).ThenInclude(pa => pa.Photo).Include(a => a.CaracteristiquesArticle).FirstOrDefaultAsync(a => a.IDArticle == id);
        }

        public async Task<ActionResult<IEnumerable<Article>>> GetByIdCategorieAsync(int id)
        {
            List<Article> list = new List<Article>();
            List<int> listID = await GetAllCategorieChildrenByIdAsync(id, []);
            foreach (int idCategorie in listID) {
                list = list.Concat(await _dbContext.Articles.Include(a => a.Vendeur).Include(a => a.Marque).Include(a => a.Photos).ThenInclude(pa => pa.Photo).Include(a => a.CaracteristiquesArticle).Where(a => a.Categorie.IDCategorie == idCategorie).ToListAsync()).ToList();
            };
            return list;

        }

        public Task UpdateAsync(Article entityToUpdate, Article entity)
        {
            throw new NotImplementedException();
        }


        public async Task<List<int>> GetAllCategorieChildrenByIdAsync(int id, List<int> listID)
        {


            Categorie cat = await _dbContext.Categories.Include(c => c.CategoriesEnfants).FirstOrDefaultAsync(a => a.IDCategorie == id);
            listID.Add(cat.IDCategorie);

            if (cat.CategoriesEnfants.Count > 0)
            {
                foreach (Categorie catEnfant in cat.CategoriesEnfants)
                {
                    listID = await GetAllCategorieChildrenByIdAsync(catEnfant.IDCategorie, listID);
                }
            }

            return listID;
        }
    }
}
