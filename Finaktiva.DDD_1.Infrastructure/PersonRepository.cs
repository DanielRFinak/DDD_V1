using Finaktiva.DDD_1.Domain.Entities;
using Finaktiva.DDD_1.Domain.Repositories;
using Finaktiva.DDD_1.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finaktiva.DDD_1.Infrastructure
{
    public class PersonRepository: IPersonRepository
    {
        DatabaseContex db;

        public PersonRepository(DatabaseContex db)
        {
            this.db = db;

        }

        public async Task AddPerson(Person person) 
        {
            await db.AddAsync(person);
            await db.SaveChangesAsync();
        }

        public async Task<Person> GetPersonById(PersonId id) => await db.Persons.FindAsync((Guid)id);
    }
}
