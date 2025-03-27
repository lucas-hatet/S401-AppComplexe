using API_Vinted.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class PhotoManager
    {
        private VintedDBContext _dbContext;
        public PhotoManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(Photo entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Photo entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Photo>>> GetAllAsync()
        {
            return await _dbContext.Photos.ToListAsync();
        }

        public async Task<ActionResult<Photo>> GetByIdAsync(int id)
        {
            return await _dbContext.Photos.FirstOrDefaultAsync(a => a.IDPhoto == id);
        }

        public Task UpdateAsync(Photo entityToUpdate, Photo entity)
        {
            throw new NotImplementedException();
        }
    }
}
