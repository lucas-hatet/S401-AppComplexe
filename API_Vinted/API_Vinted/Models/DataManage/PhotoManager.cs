using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class PhotoManager : IDataRepository<Photo>
    {
        private readonly VintedDBContext _dbContext;

        public PhotoManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Photo entity)
        {
            _dbContext.Photos.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Photo entity)
        {
            _dbContext.Photos.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<ActionResult<IEnumerable<Photo>>> GetAllAsync()
        {
            return await _dbContext.Photos.ToListAsync();
        }

        public async Task<ActionResult<Photo>> GetByIdAsync(int id)
        {

            return await _dbContext.Photos.FirstOrDefaultAsync(m => m.IDPhoto == id);
        }

        public async Task UpdateAsync(Photo existingEntity, Photo updatedEntity)
        {
            _dbContext.Entry(existingEntity).CurrentValues.SetValues(updatedEntity);
            await _dbContext.SaveChangesAsync();
        }

    }
}
