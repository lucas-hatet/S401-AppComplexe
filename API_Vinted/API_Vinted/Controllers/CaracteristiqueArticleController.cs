using API_Vinted.Models;
using API_Vinted.Models.DataManage;
using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace API_Vinted.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CaracteristiqueArticleController : ControllerBase
    {
        private readonly CaracteristiqueArticleManager _repository;

        public CaracteristiqueArticleController(CaracteristiqueArticleManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CaracteristiqueArticle>>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
            
        }

        [HttpGet("{idArticle}/{idCaracteristique}")]
        [ActionName("GetByIdAsync")]
        public async Task<ActionResult<CaracteristiqueArticle>> GetByIdAsync(int idArticle, int idCaracteristique)
        {
            var entity = await _repository.GetByIdAsync(idArticle,idCaracteristique);
            if (entity == null) return NotFound();
            return Ok(entity);
        }


        [HttpPost]
        public async Task<ActionResult<CaracteristiqueArticle>> AddAsync([FromBody] CaracteristiqueArticle entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _repository.AddAsync(entity);
            return CreatedAtAction("GetByIdAsync", new { idArticle = entity.IDArticle, idCaracteristique = entity.IDCaracteristique }, entity); 
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] CaracteristiqueArticle entity)
        {
            var entityToUpdate = await _repository.GetByIdAsync(id);
            if (entityToUpdate == null) return NotFound();
            await _repository.UpdateAsync(entityToUpdate.Value, entity);
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
