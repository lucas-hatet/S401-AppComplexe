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
    public class ArticleController : ControllerBase
    {
        private readonly ArticleManager _repository;

        public ArticleController(ArticleManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Article>>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
            
        }

        [HttpGet("{id}")]
        [ActionName("GetByIdAsync")]
        public async Task<ActionResult<Article>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<IEnumerable<Article>>> GetByIdCategorieAsync(int id)
        {
            return await _repository.GetByIdCategorieAsync(id);
            
        }

        [HttpPost]
        public async Task<ActionResult<Article>> AddAsync([FromBody] Article entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _repository.AddAsync(entity);

            var articleDto = new ArticleDto
            {
                IDArticle = entity.IDArticle,
                IDVendeur = entity.IDVendeur,
                NumTransaction = entity.NumTransaction,
                IDCategorie = entity.IDCategorie,
                IDModePaiement = entity.IDModePaiement,
                IDFormat = entity.IDFormat,
                IDMarque = entity.IDMarque,
                NomArticle = entity.NomArticle,
                DateAjout = entity.DateAjout,
                Description = entity.Description,
                Prix = entity.Prix,
                NBVue = entity.NBVue
            };

            return CreatedAtAction("GetByIdAsync", new { id = entity.IDArticle }, articleDto);
        }



        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] Article entity)
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

        public class ArticleDto
        {
            public int IDArticle { get; set; }
            public int IDVendeur { get; set; }
            public int? NumTransaction { get; set; }
            public int IDCategorie { get; set; }
            public int IDModePaiement { get; set; }
            public int IDFormat { get; set; }
            public int IDMarque { get; set; }
            public string NomArticle { get; set; } = null!;
            public DateTime DateAjout { get; set; }
            public string Description { get; set; } = null!;
            public float Prix { get; set; }
            public int NBVue { get; set; }
        }
    }
}
