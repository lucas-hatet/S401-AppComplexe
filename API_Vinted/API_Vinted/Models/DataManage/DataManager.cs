using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Data;

namespace API_Vinted.Models.DataManage
{
    public class DataManager<T> : IDataRepository<T> where T : class
    {
        protected readonly VintedDBContext _context;
        private readonly DbSet<T> _dbSet;

        public DataManager(VintedDBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<ActionResult<T>> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<ActionResult<IEnumerable<T>>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entityToUpdate, T entity)
        {
            _dbSet.Entry(entityToUpdate).State = EntityState.Modified;
            entityToUpdate = entity;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
