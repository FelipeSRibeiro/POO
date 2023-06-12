using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agenciaBancaria.Domain.Entities;
using agenciaBancaria.Domain.Interfaces;
using agenciaBancaria.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace agenciaBancaria.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleRepository repository;

          public PeopleController(){
            this.repository = new PeopleRepository();
          }


        [HttpGet]
        public IEnumerable<People>Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public People Get(int id)
        {
            return repository.GetById(id);
        }

        public IActionResult Post([FromBody] People item)
        {
            repository.Save(item);
            return Ok( new {
                statusCode = 200,
                message = "Usuário cadastrado com sucesso",
                item
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok( new {
                statusCode = 200,
                message = "Usuário deletado com sucesso",
            });
        }

        [HttpPut]
        public IActionResult put([FromBody] People item)
        {
            repository.Update(item);
             return Ok( new {
                statusCode = 200,
                message = "Usuário Aletrado com sucesso",
                item
            });
        }
    }
}