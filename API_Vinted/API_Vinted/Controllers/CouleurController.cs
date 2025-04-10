﻿using API_Vinted.Models.DataManage;
using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace API_Vinted.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CouleurController : ControllerBase
    {
        private readonly IDataRepository<Couleur> _repository;

        public CouleurController(IDataRepository<Couleur> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Couleur>>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Couleur>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync([FromBody] Couleur entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _repository.AddAsync(entity);
            return CreatedAtAction("GetByIdAsync", new { idCouleur = entity.IDCouleur }, entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] Couleur entity)
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
