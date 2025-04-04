using API_Vinted.Models.DataManage;
using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace API_Vinted.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PhotoController : ControllerBase
    {
        private readonly PhotoManager _repository;

        public PhotoController(PhotoManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Photo>>> GetAllAsync()
        {
            return await _repository.GetAllAsync();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Photo>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }


        [HttpPost]
        public async Task<ActionResult<Photo>> AddAsync([FromBody] PhotoCreateDto createDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = new Photo
            {
                IDPhoto = createDto.IDPhoto,
                URLPhoto = createDto.URLPhoto
            };
            await _repository.AddAsync(entity);
            return Created($"/api/Photo/{entity.IDPhoto}", entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] Photo entity)
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
        public class PhotoCreateDto
        {
            public int IDPhoto { get; set; }
            public string URLPhoto { get; set; }
        }

    }
}
