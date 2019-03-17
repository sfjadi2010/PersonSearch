using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonSearch.Models;
using PersonSearch.Repositories;

namespace PersonSearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonRepository _repository;

        public PersonController(PersonRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Person
        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPeopleAsync()
        {
            return await _repository.GetPeopleAsync();
        }

        // GET: api/Person/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Person
        [HttpPost]
        public async Task<Person> AddPersonAsync(Person person)
        {
            return await _repository.AddPersonAsync(person);
        }

        // PUT: api/Person/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
