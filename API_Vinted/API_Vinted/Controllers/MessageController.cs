using API_Vinted.Models.DataManage;
using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace API_Vinted.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly MessageManager _repository;

        public MessageController(MessageManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Message>>> GetAllAsync()
        {
            return await _repository.GetAllAsync();

        }

        [HttpGet("{idexpediteur}-{idreceveur}-{idarticle}")]
        public async Task<ActionResult<Message>> GetByIdAsync(int idexpediteur, int idreceveur, int idarticle)
        {
            var entity = await _repository.GetByIdAsync(idexpediteur, idreceveur, idarticle);
            if (entity == null) return NotFound();
            return Ok(entity);
        }


        [HttpPost]
        public async Task<ActionResult> AddAsync([FromBody] Message entity)
        {
            await _repository.AddAsync(entity);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = 1 /* Mettre l'ID de l'entité ici */ }, entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] Message entity)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
