﻿using API_Vinted.Models.DataManage;
using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace API_Vinted.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CaracteristiqueController : ControllerBase
    {
        private readonly IDataRepository<Caracteristique> _repository;

        public CaracteristiqueController(IDataRepository<Caracteristique> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Caracteristique>>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Caracteristique>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync([FromBody] Caracteristique entity)
        {
            await _repository.AddAsync(entity);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = 1 /* Mettre l'ID de l'entité ici */ }, entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] Caracteristique entity)
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
