using AS_biblioteca.Domain.Entities;
using AS_biblioteca.Domain.Interfaces;
using AS_biblioteca.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AS_biblioteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UserController : ControllerBase
    {
        private readonly IUserRepository repository;

        public UserController()
        {
            this.repository = new UserRepository();
        }

        [HttpGet]
        public IEnumerable<User>Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return repository.GetById(id);
        }

        public IActionResult Post([FromBody] User item)
        {
            repository.Save(item);
            return Ok(new{
                statusCode = 200,
                massage = "Autor cadastrado com sucesso!",
                item
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok(new{
                statusCode = 200,
                message = "Autor deletado com sucesso!",
            });
        }

        [HttpPut]
        public IActionResult Put([FromBody] User item)
        {
            repository.Update(item);
            return Ok(new{
                statusCode = 200,
                message = "Autor alterado com sucesso!",
                item
            });
        }
    }
}