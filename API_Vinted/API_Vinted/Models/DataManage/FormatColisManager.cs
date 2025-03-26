using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class FormatColisManager : IDataRepository<FormatColis>
    {
        private VintedDBContext _dbContext;
        public FormatColisManager(VintedDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(FormatColis entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(FormatColis entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<FormatColis>>> GetAllAsync()
        {
            return await _dbContext.FormatColis.ToListAsync();
        }

        public async Task<ActionResult<FormatColis>> GetByIdAsync(int id)
        {
            return await _dbContext.FormatColis.FirstOrDefaultAsync(a => a.IDFormat == id);
        }

        public Task UpdateAsync(FormatColis entityToUpdate, FormatColis entity)
        {
            throw new NotImplementedException();
        }
    }
}
