using Microsoft.EntityFrameworkCore;
using PersonSearch.Context;
using PersonSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonSearch.Repositories
{
    public class PersonRepository
    {
        private readonly ApiDbContext _context;

        public PersonRepository(ApiDbContext context)
        {
            _context = context;
        }

        public async Task<Person> GetPersonAsync(int personId)
        {
            return await _context.People.FindAsync(personId);
        }

        public async Task<List<Person>> GetPeopleAsync()
        {
            return await _context.People.Include("Address").ToListAsync();
        }

        public async Task<Person> AddPersonAsync(Person person)
        {
            _context.People.Add(person);
            await _context.SaveChangesAsync();

            return person;
        }
    }
}
