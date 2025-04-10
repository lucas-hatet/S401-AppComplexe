﻿using API_Vinted.Models;
using API_Vinted.Models.DataManage;
using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using BCrypt.Net;
using Microsoft.AspNetCore.Mvc;

namespace API_Vinted.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IDataRepository<Client> _repository;
        private readonly AdresseManager _repositoryAdresse;
        private readonly LoginController _loginController;


        public ClientController(IDataRepository<Client> repository, AdresseManager repositoryAdresse, LoginController loginController)
        {
            _repository = repository;
            _repositoryAdresse = repositoryAdresse;
            _loginController = loginController;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        [HttpGet("{id}")]
        [ActionName("GetByIdAsync")]
        public async Task<ActionResult<Client>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<Client>> AddAsync([FromBody] Client entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            entity.MotDePasse = PasswordManager.HashPassword(entity.MotDePasse);
            await _repositoryAdresse.AddAsync(entity.AdresseLivraison);
            await _repository.AddAsync(entity);
            _loginController.AddUserByClient(entity);
            return CreatedAtAction("GetByIdAsync", new { id = entity.IDClient }, entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] Client entity)
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
