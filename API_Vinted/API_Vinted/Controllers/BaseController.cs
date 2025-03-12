using API_Vinted.Models.DataManage;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API_Vinted.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<T> : ControllerBase where T : class
    {
        private readonly DataManager<T> _repository;

        public BaseController(DataManager<T> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<T>>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<T>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync([FromBody] T entity)
        {
            await _repository.AddAsync(entity);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = 1 /* Mettre l'ID de l'entité ici */ }, entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] T entity)
        {
            var entityToUpdate = await _repository.GetByIdAsync(id);
            if (entityToUpdate == null) return NotFound(); 
            await _repository.UpdateAsync(entityToUpdate.Value,entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();

            await _repository.DeleteAsync(entity.Value);
            return NoContent();
        }
    }

}
