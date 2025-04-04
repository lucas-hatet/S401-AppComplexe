using API_Vinted.Models.DataManage;
using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using static API_Vinted.Controllers.PhotoController;

namespace API_Vinted.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PhotoArticleController : ControllerBase
    {
        private readonly PhotoArticleManager _repository;

        public PhotoArticleController(PhotoArticleManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhotoArticle>>> GetAllAsync()
        {
            return await _repository.GetAllAsync();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PhotoArticle>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }


        [HttpPost]
        public async Task<ActionResult> AddAsync([FromBody] PhotoArticleCreateDto createDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = new PhotoArticle
            {
                IDPhoto = createDto.IDPhoto,
                IDArticle = createDto.IDArticle
            };
            await _repository.AddAsync(entity);
            return Created($"/api/PhotoArticle/{entity.IDPhoto}", entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] PhotoArticle entity)
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

        public class PhotoArticleCreateDto
        {
            public int IDPhoto { get; set; }
            public int IDArticle { get; set; }
        }
    }
}
