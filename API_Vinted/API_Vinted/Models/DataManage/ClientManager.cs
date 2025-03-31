using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.DataManage
{
    public class ClientManager : IDataRepository<Client>
    {
        private VintedDBContext _context;
        public ClientManager(VintedDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Client entity)
        {
            await _context.Clients.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Client entity)
        {
            _context.Clients.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<ActionResult<IEnumerable<Client>>> GetAllAsync()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<ActionResult<Client>> GetByIdAsync(int id)
        {
            return await _context.Clients.Include(c => c.AdresseLivraison.Ville).Include(c => c.AvisSur).ThenInclude(a => a.Acheteur).Include(c => c.Articles).ThenInclude(a => a.Marque).Include(c => c.Articles).ThenInclude(a => a.Photos).ThenInclude(pa => pa.Photo).Include(c => c.Photo).FirstOrDefaultAsync(a => a.IDClient == id);
            
        }

        public async Task UpdateAsync(Client entityToUpdate, Client entity)
        {
            _context.Entry(entityToUpdate).State = EntityState.Modified;
            entityToUpdate.Pseudo = entity.Pseudo;
            await _context.SaveChangesAsync();
        }
    }
}
