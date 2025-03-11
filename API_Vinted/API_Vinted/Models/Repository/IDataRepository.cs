using Microsoft.AspNetCore.Mvc;

namespace API_Vinted.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        Task<ActionResult<IEnumerable<TEntity>>> GetAllAsync();
        Task<ActionResult<TEntity>> GetAsync(int id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entityToUpdate, TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
