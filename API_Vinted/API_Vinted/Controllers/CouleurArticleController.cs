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
    public class CouleurArticleController : ControllerBase
    {
        private readonly CouleurArticleManager _repository;

        public CouleurArticleController(CouleurArticleManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CouleurArticle>>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        [HttpGet("{idArticle}/{idCouleur}")]
        [ActionName("GetByIdAsync")]
        public async Task<ActionResult<CouleurArticle>> GetByIdAsync(int idArticle, int idCouleur)
        {
            var entity = await _repository.GetByIdAsync(idArticle, idCouleur);
            if (entity == null) return NotFound();
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<CouleurArticle>> AddAsync([FromBody] CouleurArticleCreateDto createDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var entity = new CouleurArticle
            {
                IDArticle = createDto.IDArticle,
                IDCouleur = createDto.IDCouleur
            };

            await _repository.AddAsync(entity);
            return CreatedAtAction("GetByIdAsync", new { idArticle = entity.IDArticle, idCouleur = entity.IDCouleur }, entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] CouleurArticle entity)
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

    public class CouleurArticleCreateDto
    {
        public int IDArticle { get; set; }
        public int IDCouleur { get; set; }
    }
}